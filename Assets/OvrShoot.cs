using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OvrShoot : MonoBehaviour
{
    public OVRInput.Button shootButton;
    public OVRGrabbable ovrGrab;

    // Start is called before the first frame update
    void Start()
    {
        ovrGrab = GetComponent<OVRGrabbable>();    
    }

    // Update is called once per frame
    void Update()
    {
        if (ovrGrab.isGrabbed && OVRInput.GetDown(shootButton, OVRInput.Controller.RTouch))
        {

        }
    }
}
