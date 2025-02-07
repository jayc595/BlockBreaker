﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {
    public Paddle paddle;
    public Rigidbody2D rb;
    private Vector3 paddleToBallVector;
    private bool hasStarted = false;
    
	// Use this for initialization
	void Start () {
        paddleToBallVector = this.transform.position - paddle.transform.position;
        rb = GetComponent<Rigidbody2D>();
    }
	
	// Update is called once per frame
	void Update () {
        if (!hasStarted)
        {
            this.transform.position = paddle.transform.position + paddleToBallVector;

            if (Input.GetMouseButtonDown(0))
            {
                print("mouse button clicked");
                hasStarted = true;
                rb.velocity = new Vector2(2f, 10f);
            }
        }
	}
}
