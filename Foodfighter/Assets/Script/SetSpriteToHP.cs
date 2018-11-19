using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetSpriteToHP : MonoBehaviour {
    public Sprite[] sprites;
    public int currentHP = -1;

	// Use this for initialization
	void Start () {
        gameObject.GetComponent<SpriteRenderer>().sprite = null;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void addHP()
    {
        currentHP++;
        if (currentHP < sprites.Length)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = sprites[currentHP];
        }
    }

}
