using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerChaseCamera : MonoBehaviour {
    public GameObject player;
    public float xMax = 3.0f;
    public float xMin = -3.0f;
    public float yMax = 3.0f;
    public float yMin = -3.0f;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        Vector3 distanceFromPlayer = player.transform.position - gameObject.transform.position;
        if ( distanceFromPlayer.x > xMax ){
            gameObject.transform.position = new Vector3(transform.position.x + distanceFromPlayer.x - xMax,
                                                        transform.position.y, transform.position.z);
        }
        if (distanceFromPlayer.x < xMin)
        {
            gameObject.transform.position = new Vector3(transform.position.x + distanceFromPlayer.x - xMin,
                                                        transform.position.y, transform.position.z);
        }
        if (distanceFromPlayer.y > yMax)
        {
            gameObject.transform.position = new Vector3(transform.position.x ,
                                                        transform.position.y + distanceFromPlayer.y - yMax,
                                                        transform.position.z);
        }
        if (distanceFromPlayer.y < yMin)
        {
            gameObject.transform.position = new Vector3(transform.position.x,
                                                        transform.position.y + distanceFromPlayer.y - yMin,
                                                        transform.position.z);
        }
    }
}
