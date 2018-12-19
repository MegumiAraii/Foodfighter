using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VideoEndWaiter : MonoBehaviour
{
    VideoPlayer videoPlayer_;
    public Player2 Player2_Object;
    public Player1 Player1_Object;
    public GameObject damageTarget;
    public bool jam = false;

    // Use this for initialization
    void Start()
    {
        videoPlayer_ = GetComponent<VideoPlayer>();
        videoPlayer_.loopPointReached += OnVideoEnded;
    }

    void OnVideoEnded( VideoPlayer player )
    {
        //ビデオの再生が終了したら、非アクティブにする
            gameObject.SetActive(false);
        Player2_Object.pause = false;
       Player1_Object.pause = false;
         


        if ( damageTarget.GetComponent<Player1>() != null){
            damageTarget.GetComponent<Player1>().damaged(20);
        }

        if (damageTarget.GetComponent<Player2>() != null) {
            if (jam){
                damageTarget.GetComponent<Player2>().damaged(-20);    
            }else{
                damageTarget.GetComponent<Player2>().damaged(20);    
            }
        }
    }
}
