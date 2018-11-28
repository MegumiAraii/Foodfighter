using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class select_back : MonoBehaviour
{
    float startTime;

    void Start()
    {
        startTime = Time.time;
    }

    void Update()
    {
        // 17秒経過したか
        if (Time.time - startTime > 17f)
        {
            // シーン切り替え
            SceneManager.LoadScene("Food_fightter's_select");
        }
    }
}