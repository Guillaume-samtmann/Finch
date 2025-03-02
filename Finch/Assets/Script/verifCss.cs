using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VerifCss : MonoBehaviour
{
    public TMP_InputField userDisplay;
    public TMP_InputField userHeight;
    public TMP_InputField userFont;
    public TextMeshProUGUI feedbackText;

    private string correctCode = "block;";
    private string correctCode1 = "500px;";
    private string correctCode2 = "'Arial', sans-serif;";

    void Start()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    public void CheckCode()
    {
        if (userDisplay.text.Trim().ToLower() == correctCode.ToLower() &&
            userHeight.text.Trim().ToLower() == correctCode1.ToLower() &&
            userFont.text.Trim().ToLower() == correctCode2.ToLower())
        {
            feedbackText.text = "Bravo ! Code correct ✅";
            feedbackText.color = Color.green;
            Debug.Log("Réussite !");
            PlayerPrefs.SetInt("costumeRepart", 1);
            StartCoroutine(loadScene());
        }
        else
        {
            feedbackText.text = "Erreur ! Réessaye ❌";
            feedbackText.color = Color.red;
            Debug.Log("Erreur ! Réessaye");
        }
    }

    IEnumerator loadScene()
    {
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(0);
    }
}

