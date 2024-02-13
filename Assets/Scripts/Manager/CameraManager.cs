using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CameraManager
{
    private bool isCorutine = false;
    public GameObject Cameras { get; private set; }
    private Transform playerTransform;
    public Transform PlayerTransform 
    {
        get 
        { 
            if (playerTransform == null) 
                playerTransform = GameManager.PlayerM.Elin.GetComponent<Transform>(); 
            return playerTransform; 
        } 
    }
    public CinemachineVirtualCamera virtualCamera;
    public void Init()
    {
        if (Cameras == null)
        {
            Cameras = GameObject.FindGameObjectWithTag("Cameras");
            virtualCamera = Cameras.GetComponentInChildren<CinemachineVirtualCamera>();
        }
    }

    public void IsFollowPlayer(bool _isFollow)
    {
        if (_isFollow)
            virtualCamera.Follow = PlayerTransform;
        else
            virtualCamera.Follow = null;
    }
}
