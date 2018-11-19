using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetScaleToHP : MonoBehaviour {
    public float[] scaleStep;
    public float[] xStep;
    Vector3 originalScale;
    Vector3 originalPos;
    public int currentHP = 0;

	// Use this for initialization
	void Start () {
        originalScale = transform.localScale;
        originalPos = transform.position;
        setHP(0);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void setHP(int index){
        transform.localScale = new Vector3(scaleStep[index], originalScale.y, originalScale.z);
        transform.position = new Vector3(xStep[index], originalPos.y, originalPos.z);
    }

    public void addHP()
    {
        currentHP++;
        if (currentHP < scaleStep.Length)
        {
            setHP(currentHP);
        }
    }
}
