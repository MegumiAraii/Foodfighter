using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class batorusound : MonoBehaviour {
    private AudioSource sound01;
    public bool IsDamaged;


	// Use this for initialization
	void Start () {
		
        //AudioSourceコンポーネントを取得し、変数に格納
        sound01 = GetComponent<AudioSource>();
    }
	
	// Update is called once per frame
	void Update () {
        //ダメージを受けたら音声ファイル再生
        if (IsDamaged)
        {
            sound01.PlayOneShot(sound01.clip);
        }
    }
}