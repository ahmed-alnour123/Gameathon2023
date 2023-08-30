using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrontDoor : MonoBehaviour {

    public FrontDoorItem[] items;
    public Transform frontDoor;

    bool unlockedFrontDoor = false;

    void Update() {
        if (unlockedFrontDoor) return;

        if (items[0].right) {
            unlockedFrontDoor = true;
            print("Openning");
            GetComponent<Animator>().SetTrigger("Open");
            items[0].enabled = false;
        }
    }
}
