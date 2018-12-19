using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Foodfighter: MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButtonDown("Back"))
        {
            SceneManager.LoadScene("Food_fighter's_title");
        }
        if (Input.GetButtonDown("Start"))
        {
            SceneManager.LoadScene("Food_fighter's_sousasetumei");
        }
		
	}
}
