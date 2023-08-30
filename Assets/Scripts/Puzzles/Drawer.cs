using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drawer : MonoBehaviour {
    public bool isOpen;

    private Animator animatr;

    private void Start() {
        animatr = GetComponent<Animator>();
    }

    public void ToggleDrawer() {
        isOpen = !isOpen;
        animatr.SetBool("Open", isOpen);
    }
}
