using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuButtons : MonoBehaviour
{


    public void PlayButton()
    {
        SceneManager.LoadScene("GameScene");
    }

    public void ControlButton()
    {
        SceneManager.LoadScene("Controls");
    }



    public void ExitButton()
    {
        Application.Quit();
    }
}
