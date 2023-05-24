using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuControls : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void PlayButton()
    {
        SceneManager.LoadScene("GameScene");
    }

    public void ControlsButton()
    {
        SceneManager.LoadScene("Controls");
    }


    public void ExitButton()
    {

        Application.Quit();

    }

}
