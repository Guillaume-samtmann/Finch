using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject PausePanel;
    public GameObject firstParsonController;
    public GameObject Page1;
    public GameObject Page2;
    void Update()
    {
      if (Input.GetKeyDown(KeyCode.Tab)) 
        {
            Pause();
        }  
    }

    public void Pause()
    {
        Cursor.visible = true;
        PausePanel.SetActive(true);
        Cursor.lockState = CursorLockMode.Confined;
        Time.timeScale = 0;
        if( firstParsonController != null)
        {
            firstParsonController.SetActive(false);
        }
    }

    public void Continuer()
    {
        Cursor.visible = false;
        PausePanel.SetActive(false);
        Cursor.lockState= CursorLockMode.Locked;
        Time.timeScale = 1;
        firstParsonController.SetActive(true);
    }

    public void quit()
    {
        Application.Quit();
    }

    public void returnAccueil()
    {
        SceneManager.LoadScene(0);
    }

    public void optionPanel()
    {
        Page1.SetActive(false);
        Page2.SetActive(true);
    }

    public void returnInPage1() 
    {
        Page1.SetActive(true);
        Page2.SetActive(false);
    }


}
