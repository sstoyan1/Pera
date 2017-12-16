
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class gameUI : MonoBehaviour
{

    public Button exitGameButton;

    // Use this for initialization


    public void ExitGame_InGame()
    {
        Application.Quit();
    }


}