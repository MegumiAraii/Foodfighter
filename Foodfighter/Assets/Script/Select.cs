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

        if (Input.GetButtonDown("Kettei"))
        {
            SceneManager.LoadScene("Food_fighter's_VS");
        }
        if (Input.GetButtonDown("Back"))
        {
            SceneManager.LoadScene("Food_fighter's_title");
        }
        if (Input.GetButtonDown("Right"))
        {
            SceneManager.LoadScene("Food_fightter's_select2");
        }
       
        if (Input.GetButtonDown("Left"))
        {
            SceneManager.LoadScene("Food_fightter's_select2");
        }
    }
}