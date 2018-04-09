using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {
    public Camera staticCamera;
    public Camera followCamera;
    public Camera springCamera;
    public Camera orbitCamera;
    public Camera firstPersonCamera;
    public Camera splineCamera;

        // Use this for initialization
    void Start () {
        staticCamera.enabled = true;
        followCamera.enabled = false;
        springCamera.enabled = false;
        orbitCamera.enabled = false;
        firstPersonCamera.enabled = false;
        splineCamera.enabled = false;
    }

    void Update()
    {
      setCamera();
    }

    void setCamera()
    {
      if(Input.GetKeyDown("a"))
      {
         staticCamera.enabled = true;
         followCamera.enabled = false;
         springCamera.enabled = false;
         orbitCamera.enabled = false;
         firstPersonCamera.enabled = false;
         splineCamera.enabled = false;
      }
      else if(Input.GetKeyDown("b"))
      {
        staticCamera.enabled = false;
        followCamera.enabled = true;
        springCamera.enabled = false;
        orbitCamera.enabled = false;
        firstPersonCamera.enabled = false;
        splineCamera.enabled = false;
      }
      else if(Input.GetKeyDown("c"))
      {
        staticCamera.enabled = false;
        followCamera.enabled = false;
        springCamera.enabled = true;
        orbitCamera.enabled = false;
        firstPersonCamera.enabled = false;
        splineCamera.enabled = false;
      }
      else if(Input.GetKeyDown("d"))
      {
        staticCamera.enabled = false;
        followCamera.enabled = false;
        springCamera.enabled = false;
        orbitCamera.enabled = true;
        firstPersonCamera.enabled = false;
        splineCamera.enabled = false;
      }
      else if(Input.GetKeyDown("e"))
      {
        staticCamera.enabled = false;
        followCamera.enabled = false;
        springCamera.enabled = false;
        orbitCamera.enabled = false;
        firstPersonCamera.enabled = true;
        splineCamera.enabled = false;
      }
      else if(Input.GetKeyDown("f"))
      {
        staticCamera.enabled = false;
        followCamera.enabled = false;
        springCamera.enabled = false;
        orbitCamera.enabled = false;
        firstPersonCamera.enabled = false;
        splineCamera.enabled = true;
      }
    }
}
