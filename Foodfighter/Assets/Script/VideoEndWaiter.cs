using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VideoEndWaiter : MonoBehaviour
{
    VideoPlayer videoPlayer_;

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
    }
}
