using UnityEngine;

public class Obsticle : MonoBehaviour 
{

    PlayerMovement playerMovement;

    
    // Start is called before the first frame update
    void Start()
    {
        playerMovement = GameObject.FindObjectOfType<PlayerMovement>();
        
    }

    private void OnCollisionEnter(Collision collision)
    {

        if(collision.gameObject.name == "Player")
        {
            playerMovement.Die();
        }

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
