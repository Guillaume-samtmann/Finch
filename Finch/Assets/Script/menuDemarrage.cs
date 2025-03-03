using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menuDemarrage : MonoBehaviour
{
    public GameObject page1;
    public GameObject page2;

    void Start()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
    public void play()
    {
        SceneManager.LoadScene(1);
    }

    public  void newGame()
    {
        PlayerPrefs.DeleteAll();
        PlayerPrefs.Save();
        StartCoroutine(newGameLoad());
    }

    IEnumerator newGameLoad()
    {
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(1);
    }

    public void option()
    {
        page1.SetActive(false);
        page2.SetActive(true);
    }

    public void returnAccueil()
    {
        page1.SetActive(true);
        page2.SetActive(false);
    }

    public void quit()
    {
        Application.Quit();
    }
    public void credit()
    {
        SceneManager.LoadScene(5);
    }
}
