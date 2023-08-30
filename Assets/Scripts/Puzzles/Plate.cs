using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plate : MonoBehaviour {
    public GameObject plateCover;
    public GameObject plateFull;
    public GameObject key;
    public Vector3 coverPos;

    public void RemoveCover() {
        plateCover.transform.localPosition = coverPos;
    }

    public void EatRice() {
        plateFull.SetActive(false);
    }

    public void TakeKey() {
        key.SetActive(false);
        ItemsManager.Instance.PickBoxKey();
    }
}
