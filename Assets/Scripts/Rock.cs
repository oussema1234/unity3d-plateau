using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rock : MonoBehaviour
{
    private float y = 0;
	// Use this for initialization
	void Start ()
	{
	   
	}
	
	// Update is called once per frame
	void Update ()
	{
	  y += 2*Time.deltaTime;
	    transform.rotation = Quaternion.EulerAngles(0, y, 0);
        


	}
}
