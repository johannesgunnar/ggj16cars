﻿using UnityEngine;
using System.Collections;

public class startingCollision : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnCollisionEnter(Collision col)
    {
        print(col.gameObject.tag == "player");
        if(col.gameObject.tag == "player")
        {
            col.gameObject.GetComponent<playerCollision>().timerOn = true;
            Destroy(gameObject);
        }
        else
        {
            print("hussa");
            col.gameObject.GetComponentInParent<playerCollision>().timerOn = true;
        }
    }
}
