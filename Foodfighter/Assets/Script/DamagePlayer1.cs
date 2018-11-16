using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DamagePlayer1 : MonoBehaviour
{
    public GameObject hpbar;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnCollisionEnter2D(Collision2D col)
    {
        Debug.Log("Hit");

        if (!GetComponent<Player2>().IsAttacking)
            return;
        
        //  on damage
        if (col.gameObject.tag == "player")
        {
            var slider = hpbar.GetComponent<Slider>();
            var hp = slider.value;
            hp -= 5;

            GetComponent<Player2>().Damage();

            slider.value = hp;
        }
    }
}