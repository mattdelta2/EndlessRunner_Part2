using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{


    public Transform player;

    Vector3 offset;

    void Start()
    {

        offset = transform.position - player.position;
        
    }


    void Update()
    {

        Vector3 targetPos = player.position + offset;
        targetPos.x = 0;
        transform.position = targetPos;
        
    }
}
