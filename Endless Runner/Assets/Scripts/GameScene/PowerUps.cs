using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUps : MonoBehaviour
{

    public bool doublePoints = false;

    public bool JumpBoost = false;

    public float powerupLength = 10f;

    private PowerUpManager powerUpManager;


    
    void Start()
    {
        powerUpManager = FindObjectOfType<PowerUpManager>();
        
    }

    
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {

        if(other.name == "Player")
        {
            powerUpManager.ActivatePowerUp(doublePoints, JumpBoost, powerupLength);


            
        }
        gameObject.SetActive(false);
        
    }
}
