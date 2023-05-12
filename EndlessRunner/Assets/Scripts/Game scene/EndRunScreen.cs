using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EndRunScreen : MonoBehaviour
{

    public GameObject EndSreen;
    public GameObject CoinsLive;
    public GameObject DistanceLive;

    public GameObject Fadeout;


     void Start()
    {
        StartCoroutine(EndSequence());
        
    }


    IEnumerator EndSequence()
    {
        yield return new WaitForSeconds(5);

        CoinsLive.SetActive(false);
        DistanceLive.SetActive(false);

        EndSreen.SetActive(true);

        yield return new WaitForSeconds(5);
        Fadeout.SetActive(true);
    }

}
