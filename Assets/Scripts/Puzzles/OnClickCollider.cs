using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(BoxCollider))]
public class OnClickCollider : MonoBehaviour {
    public UnityEvent Event;
    public bool oneShot;

    private void OnMouseDown() {
        Event?.Invoke();
        if (oneShot) {
            Destroy(this);
        }
    }
}
