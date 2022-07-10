using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CameraManager : MonoBehaviour
{
    [SerializeField] private CinemachineVirtualCamera _mainVcam;
    [SerializeField] private CinemachineVirtualCamera _rigVcam;

    private int _frontPriority = 10;
    private int _backPriority = 5;

    private void Start()
    {
        _mainVcam.Priority = _frontPriority;
        _rigVcam.Priority = _backPriority;
    }
    public void FrontMainCam()
    {
        _mainVcam.Priority = _frontPriority;
        _rigVcam.Priority = _backPriority;
    }

    public void BackMainCam()
    {
        _mainVcam.Priority = _backPriority;
        _rigVcam.Priority = _frontPriority;
    }
}
