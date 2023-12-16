using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

public class MousePlayerController: MonoBehaviour {

  public InteractEvent interactEvent;

  public Camera cam;

  void Start() {
    Assert.IsNotNull(this.interactEvent);
    Assert.IsNotNull(this.cam);
  }

  void Update() {
    if (!Input.GetMouseButtonDown(0)) return;

    Interact();
  }
  private void Interact() {
    print("[MousePlayerController#Interact]");

    Vector3 mousePos = this.cam.ScreenToWorldPoint(Input.mousePosition);

    RaycastHit2D hit = Physics2D.Raycast((Vector2) mousePos, Vector2.zero);

    if (hit.collider == null) return;

    string intersectionName = hit ? hit.collider?.gameObject?.name : "NONE";

    print($"[MousePlayerController#Interact] {intersectionName}");
    this.interactEvent.e.Invoke(intersectionName);
  }
}
