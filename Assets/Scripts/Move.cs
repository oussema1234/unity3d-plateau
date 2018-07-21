using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class Move : MonoBehaviour {
public float speed;
public float resetPosition;
public float newposition;
    public GameManager gm;
   
    
    // Use this for initialization
    void Start ()
    {
        
    }
	
	// Update is called once per frame
	void Update () {
	    if (gm.GameOn)
	    {


	        transform.Translate(new Vector3(speed*Time.deltaTime, 0, 0));
	        if (transform.position.x > resetPosition)
	        {
	            transform.position = new Vector3(newposition, transform.position.y, transform.position.z);

	        }
	    }

	}	
}
