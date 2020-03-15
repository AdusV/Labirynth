using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitMainMenu : MonoBehaviour
{
    public GameObject mainObj;
    private float tempTimeScale;

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if (Time.timeScale!=0)
            {
                tempTimeScale = Time.timeScale;
            }

            
            MenuGame();
        }

    }
    void MenuGame()
    {
        mainObj.SetActive(!mainObj.activeInHierarchy); 
        if(Time.timeScale!=0)
        {
            Time.timeScale = 0;
        }else
        {
            Time.timeScale = tempTimeScale;
        }
    }
    public void ResumeGameButton()
    {
        MenuGame();
    }
    public void OptionButton()
    {

    }
    public void MenuButton()
    {
        SceneManager.LoadScene(2);
    }
    public void ExitButton()
    {
        Application.Quit();
    }
}
