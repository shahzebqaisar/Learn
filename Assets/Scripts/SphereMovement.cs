﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereMovement : MonoBehaviour {


    private void Awake()
    {
        Debug.Log("Awake");
    }

    private void OnEnable()
    {
        Debug.Log("OnEnable");

    }


    // Use this for initialization
    void Start () {
        Debug.Log("Start");
	}
	
	// Update is called once per frame
	void Update () {
		
	}


    private void OnDisable()
    {
        Debug.Log("OnDisable");

    }
}
