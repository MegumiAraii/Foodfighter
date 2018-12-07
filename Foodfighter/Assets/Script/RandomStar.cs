using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomStar : MonoBehaviour {
    public GameObject Star;

    //　出現させるアイテムを入れておく
    [SerializeField] GameObject[] star;
    //　次にアイテムが出現するまでの時間
    [SerializeField] float appearNextTime;
    //　この場所から出現するアイテムの数
    [SerializeField] int maxNumOfEnemys;
    //　今何個のアイテムを出現させたか
    private int numberOfEnemys;
    //　待ち時間計測フィールド
    private float elapsedTime;

    // Use this for initialization
    void Start()
    {
        numberOfEnemys = 0;
        elapsedTime = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        //　この場所から出現する最大数を超えてたら何もしない
        if (numberOfEnemys >= maxNumOfEnemys)
        {
            return;
        }
        //　経過時間を足す
        elapsedTime += Time.deltaTime;

        //　経過時間が経ったら
        if (elapsedTime > appearNextTime)
        {
            elapsedTime = 0f;

            //コピーして表示
            Instantiate(Star, gameObject.transform.position, Quaternion.identity);
        
           
           
        }
    }
}
