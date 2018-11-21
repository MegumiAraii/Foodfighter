using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetSpriteToHP : MonoBehaviour {
    public Sprite[] sprites;
    public int currentHP = -1;
    public GameObject whiteMark;
    public GameObject fireMark;

	// Use this for initialization
	void Start () {
        gameObject.GetComponent<SpriteRenderer>().sprite = null;
        whiteMark.SetActive(true);
        fireMark.SetActive(false);
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

            // Maxになった時に炎にする
            if ( currentHP == sprites.Length -1){
                whiteMark.SetActive(false);
                fireMark.SetActive(true);
            }
        }
    }

    public void resetHP(){
        currentHP = -1;
        gameObject.GetComponent<SpriteRenderer>().sprite = null;
        whiteMark.SetActive(true);
        fireMark.SetActive(false);
    }

}
