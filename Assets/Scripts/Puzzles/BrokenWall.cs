using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrokenWall : MonoBehaviour {

    public Rigidbody[] rbs;

    public void StartRigidbodies() {
        if (!ItemsManager.Instance.usingHammer) return;

        foreach (var r in rbs) {
            r.isKinematic = false;
        }
    }
}
