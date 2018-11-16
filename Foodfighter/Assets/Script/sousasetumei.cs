using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sousasetumei : MonoBehaviour
{
    float startTime;

    void Start()
    {
        startTime = Time.time;
    }

    void Update()
    {
        // 8秒経過したか
        if (Time.time - startTime > 8f)
        {
            // シーン切り替え
            SceneManager.LoadScene("Food_fighter's");
        }
        if (Input.GetKey(KeyCode.Return))
        {
            SceneManager.LoadScene("Food_fighter's");
        }
    }
}
