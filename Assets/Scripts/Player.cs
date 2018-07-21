using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
public float jumpForce;
public AudioClip jumpsound;
    public AudioClip dethsound;
private Rigidbody rb ;
    public GameManager gm;

    public float MaxjumpPosition;
    

	// Use this for initialization
	public void Start ()
    {

        gm = GameObject.Find("GameMenager").GetComponent<GameManager>();

	rb = GetComponent<Rigidbody>();	//prend rigidbody du joueur 
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButtonDown(0)&& gm.GameOn &&transform.position.y< MaxjumpPosition){
            Jump();
		
		}
		
	}

    public void Jump()
    {
        GetComponent<AudioSource>().PlayOneShot(jumpsound);
        GetComponent<Animator>().Play("jump");
        rb.velocity = Vector3.zero;
        rb.AddForce(new Vector3(0, 5, 0), ForceMode.Impulse);

    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Obs"&& gm.GameOn)
        {
            
            GetComponent<AudioSource>().PlayOneShot(dethsound);
            GetComponent<Animator>().Play("die");
            gm.GameOn = false;


        }
    }
}
