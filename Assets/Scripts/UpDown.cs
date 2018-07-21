using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class UpDown : MonoBehaviour
{
    public float TopPosition;
    public float DownPosition;
   [SerializeField] private float speed;
    [SerializeField] private float y;
    // Use this for initialization
    void Start ()
	{
	    StartCoroutine(Up());
       


	}

    private IEnumerator Up()
    {
        while (transform.position.y < TopPosition)
        {
            transform.Translate((new Vector3(0, y, 0)));
            yield return new WaitForSeconds(speed); //attend ce temps pour passer 

        }
        yield return new WaitForSeconds(Random.Range(0.5f,1));
        StartCoroutine(Down());
    }

    IEnumerator Down ()
        
        {
            while (transform.position.y > DownPosition)
            {
                transform.Translate((new Vector3(0, -y, 0)));
                yield return new WaitForSeconds(speed); //attend ce temps pour passer 

            }
        yield return new WaitForSeconds(Random.Range(0.5f,1));
        StartCoroutine(Up());
        }


    }

