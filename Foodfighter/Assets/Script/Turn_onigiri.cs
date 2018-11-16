using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turn_onigiri : MonoBehaviour {
    float speed = 1.0f;

    Rigidbody2D rb;
	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(new Vector3(0, 0, -1));
	}
}
