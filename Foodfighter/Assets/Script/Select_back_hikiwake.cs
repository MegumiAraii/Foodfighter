using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Select_back_hikiwake : MonoBehaviour
{
    private int m_timer;
    float startTime;

    void Start()
    {
        startTime = Time.time;
    }

    void Update()
    {
        m_timer++;

        if (m_timer <= 1) return;
        // 25秒経過したか
        if (Time.time - startTime > 25f)
        {
            // シーン切り替え
            SceneManager.LoadScene("Food_fightter's_select");
        }
    }
}