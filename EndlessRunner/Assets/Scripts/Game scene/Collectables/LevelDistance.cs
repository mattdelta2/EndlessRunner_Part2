using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelDistance : MonoBehaviour
{

    public GameObject DistanceRun;
    public GameObject EndDistanceRun;

    public int Distance;

    public bool addingDistance = false;

    public float DistanceDelay = 0.35f;



 


    void Update()
    {

        if( addingDistance == false )
        {
            addingDistance = true;
            StartCoroutine(AddingDistance());
        }
        
    }


    IEnumerator AddingDistance()
    {
        Distance += 1;
        DistanceRun.GetComponent<Text>().text = "" + Distance;
        EndDistanceRun.GetComponent<Text>().text = "" + Distance;

        yield return new WaitForSeconds(DistanceDelay);
        addingDistance=false;

    }
}
