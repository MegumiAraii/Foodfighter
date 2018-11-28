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