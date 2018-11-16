using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DamagePlayer2 : MonoBehaviour
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
        Debug.Log("Hit2");

        if (!GetComponent<Player1>().IsAttacking)
            return;

        //  on damage
        if (col.gameObject.tag == "enemy")
        {
            var slider = hpbar.GetComponent<Slider>();
            var hp = slider.value;
            hp -= 5;

            slider.value = hp;

            GetComponent<Player1>().Damage();
        }
    }
}