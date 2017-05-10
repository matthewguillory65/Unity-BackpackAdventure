using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

    public Camera camera1;
    public Vector3 myPos;
    public Transform myPlay;
 
    void Update()
    {
        camera1.transform.position = myPlay.position + myPos;
    }
}
