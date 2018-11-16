using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Select : MonoBehaviour {

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.Return))
        {
            SceneManager.LoadScene("Food_fighter's_VS");
        }
        if (Input.GetKey(KeyCode.Space))
        {
            SceneManager.LoadScene("Food_fighter's_title");
        }
    }
}