using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuFunctionality : MonoBehaviour
{
    public void StartButton()
    {
        SceneManager.LoadScene(0);
    }
    public void HighScoresButton()
    {

    }
    public void LevelMenuButton()
    {

    }
    public void OptionButton()
    {   

    }
    public void ExitButton()
    {
        Application.Quit();
    }
}
