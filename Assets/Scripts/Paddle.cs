﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 paddlePos = new Vector3(0.5f, this.transform.position.y, 0f);
        
            
            float mousePosInBlocks = Input.mousePosition.x / Screen.width * 8;

        paddlePos.x = Mathf.Clamp(mousePosInBlocks, 0.4f, 7.6f);
        this.transform.position = paddlePos;
    }

}
