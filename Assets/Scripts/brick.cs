﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class brick : MonoBehaviour {

    public int maxHits;
    public int timesHit;
	
    // Use this for initialization
	void Start () {
        timesHit = 0;
	}
	
	// Update is called once per frame
	void Update ()
    {

    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        timesHit++;
    }



}
