using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerController : MonoBehaviour
{
    public Text timerText;
    public GameObject player1Slider;
    public GameObject player2Slider;
    public GameObject drawGame;

    public float totalTime;
    public float hikiwakeScore = 10f;
    int seconds;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
            /*
        if (Input.GetKeyDown("joystick button 0"))
        {
            Debug.Log("button0");
        }
        if (Input.GetKeyDown("joystick button 1"))
        {
            Debug.Log("button1");
        }
        if (Input.GetKeyDown("joystick button 2"))
        {
            Debug.Log("button2");
        }
        if (Input.GetKeyDown("joystick button 3"))
        {
            Debug.Log("button3");
        }
        if (Input.GetKeyDown("joystick button 4"))
        {
            Debug.Log("button4");
        }
        if (Input.GetKeyDown("joystick button 5"))
        {
            Debug.Log("button5");
        }
        if (Input.GetKeyDown("joystick button 6"))
        {
            Debug.Log("button6");
        }
        if (Input.GetKeyDown("joystick button 7"))
        {
            Debug.Log("button7");
        }
        if (Input.GetKeyDown("joystick button 8"))
        {
            Debug.Log("button8");
        }
        if (Input.GetKeyDown("joystick button 9"))
        {
            Debug.Log("button9");
        }
        if (Input.GetKeyDown("joystick button 10"))
        {
            Debug.Log("button10");
        }
        if (Input.GetKeyDown("joystick button 11"))
        {
            Debug.Log("button11");
        }
        if (Input.GetKeyDown("joystick button 12"))
        {
            Debug.Log("button12");
        }
        if (Input.GetKeyDown("joystick button 13"))
        {
            Debug.Log("button13");
        }
        if (Input.GetKeyDown("joystick button 14"))
        {
            Debug.Log("button14");
        }
        if (Input.GetKeyDown("joystick button 15"))
        {
            Debug.Log("button15");
        }
        if (Input.GetKeyDown("joystick button 16"))
        {
            Debug.Log("button16");
        }
        if (Input.GetKeyDown("joystick button 17"))
        {
            Debug.Log("button17");
        }
        if (Input.GetKeyDown("joystick button 18"))
        {
            Debug.Log("button18");
        }
        if (Input.GetKeyDown("joystick button 19"))
        {
            Debug.Log("button19");
        }

        /*
        if (Input.GetKeyDown("joystick button 20"))
        {
            Debug.Log("button20");
        }
        if (Input.GetKeyDown("joystick button 21"))
        {
            Debug.Log("button21");
        }
        if (Input.GetKeyDown("joystick button 22"))
        {
            Debug.Log("button22");
        }
        if (Input.GetKeyDown("joystick button 23"))
        {
            Debug.Log("button23");
        }
        if (Input.GetKeyDown("joystick button 24"))
        {
            Debug.Log("button24");
        }
        if (Input.GetKeyDown("joystick button 25"))
        {
            Debug.Log("button25");
        }
        if (Input.GetKeyDown("joystick button 26"))
        {
            Debug.Log("button26");
        }
        if (Input.GetKeyDown("joystick button 27"))
        {
            Debug.Log("button27");
        }
        if (Input.GetKeyDown("joystick button 28"))
        {
            Debug.Log("button28");
        }
        if (Input.GetKeyDown("joystick button 29"))
        {
            Debug.Log("button29");
        }
        if (Input.GetKeyDown("joystick button 30"))
        {
            Debug.Log("button30");
        }
        */

        if (Input.GetButtonDown("Left"))
        {
            Debug.Log("Left");
        }

        if (totalTime <= 0.0f)
            return;
        
        totalTime -= Time.deltaTime;


        //  タイムアウト！ 引き分け
        if( totalTime <= 0.0f )
        {
            totalTime = 0;
            float scoreDiff = player1Slider.GetComponent<Slider>().value - player2Slider.GetComponent<Slider>().value;
            //Debug.Log(player1Slider.GetComponent<Slider>().value);
            //Debug.Log(player2Slider.GetComponent<Slider>().value);

            Debug.Log(scoreDiff);
            int winnerNumber = 0;
            if ( Mathf.Abs(scoreDiff) < hikiwakeScore){
                //Debug.Log("Draw!!!");
                winnerNumber = 0;
            }else{
                if ( player1Slider.GetComponent<Slider>().value > player2Slider.GetComponent<Slider>().value ){
                    winnerNumber = 1;
                }else{
                    winnerNumber = 2;
                }
            }

            GameManager.Instance.GameSet(winnerNumber);
        }
            
        seconds = (int)Mathf.Ceil( totalTime );
        timerText.text = seconds.ToString();
    }
}