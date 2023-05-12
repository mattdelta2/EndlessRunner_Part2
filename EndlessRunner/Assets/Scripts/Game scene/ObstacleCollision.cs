using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleCollision : MonoBehaviour
{

    public GameObject Player;

    public GameObject CharModel;

    public AudioSource Thud;

    public GameObject mainCamera;

    public GameObject LevelControl;
    private void OnTriggerEnter(Collider other)
    {
        this.gameObject.GetComponent<BoxCollider>().enabled = false;
        Player.GetComponent<PlayerMove>().enabled = false;
        CharModel.GetComponent<Animator>().Play("Stumble Backwards");

        LevelControl.GetComponent<LevelDistance>().enabled = false;
        Thud.Play();
        mainCamera.GetComponent<Animator>().enabled = true;

        LevelControl.GetComponent<EndRunScreen>().enabled = true;


    }

}
