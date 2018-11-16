using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HPBarControl : MonoBehaviour
{

    GameObject player;
    Player1HP hpcomp;
    Slider hpslider;
    private int hp;

    void Start()
    {

        player = GameObject.Find("Player");
        hpcomp = player.GetComponent<Player1HP>();

        hpslider = GameObject.Find("HPBar").GetComponent<Slider>();
        hp = 100;　// 最大HPの値
        hpslider.value = hp; //sliderのValueの値を最大HPにする
    }


    void Update()
    {
        
        int PyHP = hpcomp.HP;　//PlayerHP内の変数HPをPyHPとして使用
        hpslider.value = PyHP;　//Valueの値をPyHPの値にする

    }

}