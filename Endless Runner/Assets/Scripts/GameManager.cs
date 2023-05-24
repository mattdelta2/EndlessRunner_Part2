using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    public Text scoreText;

     int score;
    public static GameManager inst;

    [SerializeField] PlayerMovement playerMovement;

    private void Awake()
    {

        inst = this;
          
    }

    public void IncrementScore()
    {
        score++;
        scoreText.text = "Score: " + score;

        playerMovement.speed += playerMovement.speedIncreasePerPoint;


    }

}
