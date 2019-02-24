using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereMovement : MonoBehaviour {

    private Rigidbody2D rb2d;

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
        rb2d = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void FixedUpdate()
    {

    }

    private void OnDisable()
    {
        Debug.Log("OnDisable");

    }
}
