using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour {
    public float moveSpeed;
    Animator anim;
    Rigidbody2D r2d;

	// Use this for initialization
	void Start () {
        anim = gameObject.GetComponent<Animator>();
        r2d = gameObject.GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {

        r2d.velocity = Vector2.zero;

        if ( Input.GetKey(KeyCode.UpArrow)){
            anim.SetBool("Idle", false);
            anim.SetBool("Up", true);
            r2d.velocity = Vector2.up * moveSpeed;
        }
        else{
            anim.SetBool("Up", false);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            anim.SetBool("Idle", false);
            anim.SetBool("Down", true);
            r2d.velocity = Vector2.down * moveSpeed;
        }
        else
        {
            anim.SetBool("Down", false);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            anim.SetBool("Idle", false);
            anim.SetBool("Right", true);
            r2d.velocity = Vector2.right * moveSpeed;
        }
        else
        {
            anim.SetBool("Right", false);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            anim.SetBool("Idle", false);
            anim.SetBool("Left", true);
            r2d.velocity = Vector2.left * moveSpeed;
        }
        else
        {
            anim.SetBool("Left", false);
        }
        if ( Input.GetKeyUp(KeyCode.UpArrow) || Input.GetKeyUp(KeyCode.DownArrow) ||
            Input.GetKeyUp(KeyCode.LeftArrow) || Input.GetKeyUp(KeyCode.RightArrow) ){
            anim.SetBool("Idle", true);
        }
        
    }
}
