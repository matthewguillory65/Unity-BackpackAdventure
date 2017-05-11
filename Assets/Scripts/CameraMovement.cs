using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour {

    public Transform m_Player;

    Rigidbody camera;
	// Use this for initialization
	void Start ()
    {
        camera = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        //Follow the player smoothly
        camera.velocity = new Vector3((m_Player.position.x - camera.position.x) * 2 + (m_Player.gameObject.GetComponent<Rigidbody2D>().velocity.x / 2), (m_Player.position.y + 2 - camera.position.y) * 2);
	}
}