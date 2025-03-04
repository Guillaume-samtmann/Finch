using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menuDemarrage : MonoBehaviour
{
    public GameObject page1;
    public GameObject page2;

    public AudioSource clickAudioSource;
    public AudioClip clickClip;

    public GameObject cinematique;
    public GameObject musiquedeFond;

    void Start()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
    public void play()
    {
        clickAudioSource.PlayOneShot(clickClip);
        SceneManager.LoadScene(1);
    }

    public void newGame()
    {
        clickAudioSource.PlayOneShot(clickClip);
        cinematique.SetActive(true);
        page1.SetActive(false);
        musiquedeFond.SetActive(false);
        PlayerPrefs.DeleteAll();
        PlayerPrefs.Save();
        StartCoroutine(newGameLoad());
    }

    IEnumerator newGameLoad()
    {
        yield return new WaitForSeconds(24);
        SceneManager.LoadScene(1);
    }

    public void option()
    {
        clickAudioSource.PlayOneShot(clickClip);
        page1.SetActive(false);
        page2.SetActive(true);
    }

    public void returnAccueil()
    {
        clickAudioSource.PlayOneShot(clickClip);
        page1.SetActive(true);
        page2.SetActive(false);
    }

    public void quit()
    {
        clickAudioSource.PlayOneShot(clickClip);
        Application.Quit();
    }
    public void credit()
    {
        clickAudioSource.PlayOneShot(clickClip);
        SceneManager.LoadScene(5);
    }
}
