﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseColider : MonoBehaviour {

    public LevelManager levelManager;

    void OnTriggerEnter2D(Collider2D trigger)
    {
        print("Trigger");
        levelManager.LoadLevel("Lose Screen");
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        print("Collision");
    }

}

