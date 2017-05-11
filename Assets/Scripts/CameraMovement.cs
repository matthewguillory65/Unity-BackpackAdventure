using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour {

    public Transform m_Player;

    Rigidbody thiscamera;
	// Use this for initialization
	void Start ()
    {
        thiscamera = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        //Follow the player smoothly
        thiscamera.velocity = new Vector3((m_Player.position.x - thiscamera.position.x) * 2 + (m_Player.gameObject.GetComponent<Rigidbody2D>().velocity.x / 2), (m_Player.position.y + 2 - thiscamera.position.y) * 2);
	}
}