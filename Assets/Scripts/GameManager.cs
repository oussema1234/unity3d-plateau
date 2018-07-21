using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public bool GameOn = false;
    public int Score = 0;
    public Camera cam;
    public List<GameObject> mainMenu;
    public GameObject jumpButton;
    public GameObject Player;
    public Text ScoreText;
    // Use this for initialization
    private void Start()
    {

    }

    // Update is called once per frame

    IEnumerator UpdateScore()
    {
        while (GameOn)
        {
            Score++;
            ScoreText.text = "Score : " + Score;
            yield return  new WaitForSeconds(1);

        }
        
    }

    public void play()
    {
        cam.depth = 2;
        for (int i = 0; i < mainMenu.Count; i++)
        {mainMenu[i].SetActive(false);
            jumpButton.SetActive(true);
            
        }

    }

    public void StartTheGame()
    {ScoreText.gameObject.SetActive(true);
        GameOn = true;
        jumpButton.SetActive(false);
        Player.GetComponent<Rigidbody>().useGravity = true;
        Player.GetComponent<Player>().Jump();
        StartCoroutine(UpdateScore());

    }
}
	        
	    
		
	

