using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

public class GameConfigurationController: MonoBehaviour {

  public Counter counter;

  public ResourceSpawner resourceSpawner;

  void Start() {
    Assert.IsNotNull(this.counter);
    Assert.IsNotNull(this.resourceSpawner);
  }

  public void SetSomeConfiguration() {
    print($"[GameConfigurationController#SetSomeConfiguration]");

    this.resourceSpawner.quantity = 10;
    this.counter.count = 0;
    this.counter.maxCount = 10;
  }

  public void SetLotsConfiguration() {
    print($"[GameConfigurationController#SetLotsConfiguration]");

    this.resourceSpawner.quantity = 100;
    this.counter.count = 0;
    this.counter.maxCount = 100;
  }

  public void SetTonsConfiguration() {
    print($"[GameConfigurationController#SetTonsConfiguration]");

    this.resourceSpawner.quantity = 1000;
    this.counter.count = 0;
    this.counter.maxCount = 1000;
  }
}
