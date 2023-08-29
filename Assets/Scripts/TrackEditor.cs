using System.Collections.Generic;
using Cinemachine;
using UnityEngine;

[ExecuteInEditMode]
public class TrackEditor : MonoBehaviour {

    public bool isEnabled = false;
    public TrackDirection direction = TrackDirection.Forward;

    PlayerMover player;
    CinemachineSmoothPath myPath;
    CinemachineVirtualCamera myCam;
    CinemachineTrackedDolly myDolly;

    TrackDirection lastDirection = TrackDirection.Forward;

    void Start() {
        player = FindObjectOfType<PlayerMover>();
        myPath = GetComponent<CinemachineSmoothPath>();
        myCam = GetComponentInChildren<CinemachineVirtualCamera>();
        myDolly = myCam.GetCinemachineComponent<CinemachineTrackedDolly>();
    }


    void Update() {
        if (isEnabled) {
            isEnabled = false;
            myPath.GetComponentInChildren<CinemachineVirtualCamera>().Priority = 10;
            foreach (CinemachineSmoothPath path in player.paths) {
                if (path.gameObject == myPath.gameObject) continue;
                DisablePath(path);
            }
        }

        if (lastDirection != direction) {
            lastDirection = direction;
            if (direction == TrackDirection.Forward) {
                myCam.LookAt = transform.GetChild(0);
                myDolly.m_PathPosition = 0;
            } else {
                myCam.LookAt = transform.GetChild(1);
                myDolly.m_PathPosition = 1;
            }
        }
    }

    void DisablePath(CinemachineSmoothPath path) {
        path.GetComponentInChildren<CinemachineVirtualCamera>().Priority = 0;
    }
}

public enum TrackDirection { Forward, Backward }
