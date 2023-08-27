using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour {
    public bool isBack = false;

    private void OnMouseDown() {
        PlayerMover.Instance.ChangeTrack(transform.parent, isBack);
    }
}
