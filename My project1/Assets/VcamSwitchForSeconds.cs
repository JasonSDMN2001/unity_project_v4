using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

[RequireComponent(typeof(CinemachineVirtualCamera))]
public class VcamSwitchForSeconds : MonoBehaviour
{
    CinemachineVirtualCamera vCam;
    public float delay=5;
    // Start is called before the first frame update
    void Start()
    {
        vCam = GetComponent<CinemachineVirtualCamera>();
    }
    public  void TakeControl()
    {
        StartCoroutine(TakeControlCo());
    }

    public IEnumerator TakeControlCo()
    {
        vCam.m_Priority = 10;
        yield return new WaitForSeconds(delay);
        vCam.m_Priority = -5;
    }
}
