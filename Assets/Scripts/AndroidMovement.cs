﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AndroidMovement : MonoBehaviour
{
	// Update is called once per frame
	void Update ()
    {
        transform.Translate(Input.acceleration.x, 0, 0);
    }
}