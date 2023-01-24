using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControl : MonoBehaviour
{
    public static GameControl instance;
    public GameObject gameOvertext;

    private int score = 0;
    public bool gameOver = false;
    public float scrollSpeed = -1.5f;
    // Start is called before the first frame update
    void Awake()
    {
      
    }

    // Update is called once per frame
    void Update() 
    {
         if (gameOver && Input.GetMouseButtonDown(0)) 
         {
            gameOvertext.SetActive (true);
         }
    }

    public void BirdScored()
    {
        
    }

    public void BirdDied()
    {
       gameOvertext.SetActive (true); 
       gameOver = true;
    }
}
