﻿using UnityEngine;
using System.Collections;

public class Playsound : MonoBehaviour
{

    private AudioSource sound01;

    void Start()
    {
        //AudioSourceコンポーネントを取得し、変数に格納
        sound01 = GetComponent<AudioSource>();
    }

    void Update()
    {
        //指定のキーが押されたら音声ファイル再生
        if (Input.GetKeyDown(KeyCode.Return))
        {
            sound01.PlayOneShot(sound01.clip);
        }
    }
}