using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUps : MonoBehaviour
{

    public float turnSpeed = 90;

    private void OnTriggerEnter(Collider other)
    {

        if(other.gameObject.GetComponent<Obsticle>() != null)
        {
            Destroy(gameObject);
            return;
        }
        if(other.gameObject.name!="Player")
        {
            return;
        }

        GameManager.inst.IncrementScore();



        Destroy(gameObject);
        
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        transform.Rotate(0, 0, turnSpeed * Time.deltaTime);
        
    }
}
