﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PenguinChargeMovement : MonoBehaviour {

    // Use this for initialization
    float timr;
	void Start ()
    {
        this.gameObject.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
        timr = 0.0f;
    }
	
	// Update is called once per frame
	void Update () {
 
        if(timr >= 0.551f)
        {
            this.gameObject.SetActive(false);
        }

        timr += Time.deltaTime;
	}
}
