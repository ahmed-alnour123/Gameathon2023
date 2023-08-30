using UnityEngine;

public class Updoor : MonoBehaviour {
    public void OpenDoor() {
        if (!ItemsManager.Instance.hasUpdoorKey) return;
        GetComponent<Animator>().SetTrigger("Open");
    }
}
