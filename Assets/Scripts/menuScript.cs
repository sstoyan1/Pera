using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class menuScript : MonoBehaviour {

    public Button startButton;
    public Button exitButton;

    // Use this for initialization
    void Start()
    {
        startButton = startButton.GetComponent<Button>();
        exitButton = exitButton.GetComponent<Button>();
    }

    public void startGame()
    {
        SceneManager.UnloadSceneAsync(0);
        SceneManager.LoadScene(1);
        //Application.LoadLevel(1);
    }


    public void ExitGame()
    {
        Application.Quit();
    }
 

}