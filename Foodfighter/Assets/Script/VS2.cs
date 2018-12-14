using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VS2 : MonoBehaviour
{
    float startTime;

    void Start()
    {
        startTime = Time.time;
    }

    void Update()
    {
        // 4秒経過したか
        if (Time.time - startTime > 4f)
        {
            // シーン切り替え
            SceneManager.LoadScene("Food_fighter's_sousasetumei2");
        }
    }
}
