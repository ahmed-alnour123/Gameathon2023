using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrontDoorItem : MonoBehaviour {
    public int n;

    public bool right { get { return n == 5; } }



    private void OnMouseDown() {
        transform.rotation = Quaternion.Euler(Vector3.forward * (n++ % 4) * 90);
    }

}
