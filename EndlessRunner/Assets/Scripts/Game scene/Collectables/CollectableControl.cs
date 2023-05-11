using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectableControl : MonoBehaviour
{
    public static int coinCount;

    public GameObject Coins;
    

    void Update()
    {
        Coins.GetComponent<Text>().text = "" + coinCount;

        
    }
}
