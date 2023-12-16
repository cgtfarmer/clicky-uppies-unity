using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMovement: MonoBehaviour {

  public Player player;

  private Rigidbody2D rb;

  // private Vector2 movement;

  void Start() {
    this.rb = gameObject.GetComponent<Rigidbody2D>();

    Assert.IsNotNull(this.player);
    Assert.IsNotNull(this.rb);
  }

  // void Update() {
  //   this.rb.MovePosition(this.rb.position + (
  //     this.player.movement.normalized * this.player.moveSpeed * Time.fixedDeltaTime
  //   ));
  // }

  void FixedUpdate() {
    this.rb.MovePosition(this.rb.position + (
      this.player.movement.normalized * this.player.moveSpeed * Time.fixedDeltaTime
    ));
  }

  // public void SetMovement(float horizontal, float vertical) {
  //   this.player.movement = new Vector2(horizontal, vertical);
  // }
}
