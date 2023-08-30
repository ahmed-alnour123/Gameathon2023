using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemsManager : MonoBehaviour {
    public static ItemsManager Instance;

    public bool usingHammer;
    public bool hasUpdoorKey;
    public bool hasBoxKey;
    public bool hasGrapper;

    private void Awake() {
        Instance = this;
    }

    public void PickDoorKey() { hasUpdoorKey = true; }

    public void PickBoxKey() { hasBoxKey = true; }

    public void PickGrapper() { hasGrapper = true; }
}
