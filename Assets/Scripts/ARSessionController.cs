using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class ARSessionController : MonoBehaviour
{
    [SerializeField]
    private ARSession arSession;

    public void SetARSessionActive(bool isActive)
    {
        arSession.enabled = isActive;
    }
}
