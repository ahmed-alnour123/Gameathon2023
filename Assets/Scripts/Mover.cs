using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour {
    private void OnMouseDown() {
        PlayerMover.Instance.ChangeTrack(transform.parent);
    }
}
