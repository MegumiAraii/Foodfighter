using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutinTimer : MonoBehaviour
{
    public float lifeTime=10.0f;
    // Use this for initialization
    void Start()
    {
        StartCoroutine("WaitForFinish");
    }

    // Update is called once per frame
    void Update()
    {

    }
    private IEnumerator WaitForFinish()
    {
        // 1秒待つ  
        yield return new WaitForSeconds(lifeTime);

        gameObject.SetActive(false);
    }
}
