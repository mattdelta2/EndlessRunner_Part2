using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpManager : MonoBehaviour
{




    private bool doublePoints =false;

    private bool JumpBoost;

    private bool powerUpActive;


    private float powerUpLengthCounter;

    private PlayerMovement playerMovement;
    private GameManager gameManager;

    private int normalScorePerCoins;

    private float normalJumpForce;
    
    void Start()
    {
        playerMovement = FindObjectOfType<PlayerMovement>();
        gameManager = FindObjectOfType<GameManager>();
        
    }

    
    void Update()
    {

        if(powerUpActive)
        {
            powerUpLengthCounter -= Time.deltaTime;


            if(doublePoints)
            {
                gameManager.score = normalScorePerCoins * 2;
            }

            if(JumpBoost)
            {
                playerMovement.JumpForce = normalJumpForce + 30;
            }

            if(powerUpLengthCounter <= 0 )
            {
                playerMovement.JumpForce = normalJumpForce;
                gameManager.score = normalScorePerCoins;
                powerUpActive = false;
            }
        }
        
    }


    public void ActivatePowerUp(bool points, bool jump, float time)
    {
        doublePoints = points;
        JumpBoost = jump;
        powerUpLengthCounter = time;

        normalScorePerCoins = 1;
        normalJumpForce = playerMovement.JumpForce;

        powerUpActive = true;

    }
}
