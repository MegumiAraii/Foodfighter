using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerController : MonoBehaviour
{
    public Text timerText;

    public float totalTime;
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
            GameManager.Instance.GameSet(GameManager.Player.Void);
        }
            
        seconds = (int)Mathf.Ceil( totalTime );
        timerText.text = seconds.ToString();
    }
}