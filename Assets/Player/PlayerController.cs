using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

public class PlayerController: MonoBehaviour {

  // public static event System.Action<string> onInteract;

  public InteractEvent interactEvent;

  public Player player;

  // public LayerMask interactableLayers;

  // new Camera camera;
  // private PlayerMovement playerMovement;

  private PlayerAbilityManager playerAbilityManager;

  void Start() {
    // this.camera = Camera.main;
    // this.player = this.GetComponent<Player>();
    // this.playerMovement = this.GetComponent<PlayerMovement>();
    this.playerAbilityManager = this.GetComponent<PlayerAbilityManager>();

    Assert.IsNotNull(this.interactEvent);
    Assert.IsNotNull(this.player);
    // Assert.IsNotNull(this.playerMovement);
    Assert.IsNotNull(this.playerAbilityManager);
  }

  void Update() {
    // this.playerMovement.SetMovement(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
    this.player.SetMovement(
      Input.GetAxis("Horizontal"),
      Input.GetAxis("Vertical")
    );
    // this.player.SetMovement(
    //   Input.GetAxisRaw("Horizontal"),
    //   Input.GetAxisRaw("Vertical")
    // );

    if (Input.GetKeyDown(KeyCode.Space)) {
      this.Interact();
    }
  }

  private void Interact() {
    Debug.Log("[PlayerController#Interact]");

    this.playerAbilityManager.Interact();
  }
}
