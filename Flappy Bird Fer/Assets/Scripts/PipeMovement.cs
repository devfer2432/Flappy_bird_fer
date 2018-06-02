﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMovement : MonoBehaviour {
    public float speed =0f;
    public float switchTime = 2;
	// Use this for initialization
	void Start () {
        GetComponent<Rigidbody2D>().velocity = Vector2.up * speed;
        InvokeRepeating("SwitchMovement", 0, switchTime);
	}
	void SwitchMovement()
    {
        GetComponent<Rigidbody2D>().velocity *= -1;


    }
	// Update is called once per frame
	void Update () {
		
	}
}
