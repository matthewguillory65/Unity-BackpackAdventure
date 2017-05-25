using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AndroidMovement : MonoBehaviour
{
	// Update is called once per frame
	void Update ()
    {
        GetComponent<Rigidbody2D>().AddForce(Input.acceleration * 10);
    }
}
