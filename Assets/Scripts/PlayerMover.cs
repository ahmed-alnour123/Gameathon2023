using System.Collections.Generic;
using Cinemachine;
using UnityEngine;

public class PlayerMover : MonoBehaviour {
    public static PlayerMover Instance;

    public CinemachineTrackedDolly[] tracks;

    public CinemachineVirtualCamera cam;
    private CinemachineTrackedDolly dolly;

    // private Stack<Transform> lastTracks = new Stack<Transform>();
    bool isBack = false;
    private float targetPosition;

    private void Awake() {
        Instance = this;
    }

    void Start() {
        // cam = GetComponent<CinemachineVirtualCamera>();
        dolly = cam.GetCinemachineComponent<CinemachineTrackedDolly>();
    }

    private void Update() {
        if (Input.GetMouseButtonDown(1)) {
            // dolly.m_PathPosition = 1;
            // dolly.m_PathPosition = !isBack ? 1 : 0;
        }
        if (Input.GetKeyDown(KeyCode.Backspace)) {
            // if (lastTracks.Count <= 0) return;
            // ChangeTrack(lastTracks.Pop(), true);
            cam.LookAt = null;
        }
        float rot = Input.GetAxisRaw("Horizontal");
        if (rot != 0) {
            cam.LookAt = null;
            cam.transform.Rotate(Vector3.up * 15 * rot);
        }
    }

    public void ChangeTrack(Transform trackTransform, bool isBack = false) {
        if (trackTransform == null) return;

        this.isBack = isBack;
        cam.Priority = 9;

        cam = trackTransform.GetComponentInChildren<CinemachineVirtualCamera>();
        dolly = cam.GetCinemachineComponent<CinemachineTrackedDolly>();

        var path = trackTransform.GetComponent<CinemachineSmoothPath>();
        dolly.m_PathPosition = isBack ? 1 : 0;
        dolly.m_Path = path;
        cam.LookAt = trackTransform.GetChild(isBack ? 1 : 0);
        cam.Priority = 10;
        if (!isBack) {
            // dolly.m_PathPosition = 1;
            // lastTracks.Push(trackTransform);
        }
        dolly.m_PathPosition = isBack ? 0 : 1;
    }

}
