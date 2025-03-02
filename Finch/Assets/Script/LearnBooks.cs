using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearnBooks : MonoBehaviour
{
    //reference
    
    //varaiable
    //livre Histoire
    public GameObject bookHistory;
    public bool HistoryBook = false;
    public bool CantHistoryBook = false;

    //livre Sciences
    public GameObject bookSciences;
    public bool SciencesBook = false;
    public bool CantSciencesBook = false;

    //livre Chien
    public GameObject bookChien;
    public bool ChienBook = false;
    public bool CantChienBook = false;

    // Start is called before the first frame update
    void Start()
    {
        //histoire
        if(PlayerPrefs.HasKey("LivreHistoire_Position") && PlayerPrefs.HasKey("LivreHistoire_Rotation"))
        {
            Vector3 savedPosition = JsonUtility.FromJson<Vector3>(PlayerPrefs.GetString("LivreHistoire_Position"));
            Quaternion savedRotation = JsonUtility.FromJson<Quaternion>(PlayerPrefs.GetString("LivreHistoire_Rotation"));

            bookHistory.transform.position = savedPosition;
            bookHistory.transform.rotation = savedRotation;
            bookHistory.SetActive(true);
            CantHistoryBook=true;
        }

        if (PlayerPrefs.HasKey("LivreHistoire"))
        {
            bookHistory.transform.localPosition = new Vector3(3.22f, 0.85f, 5.48f);
            bookHistory.transform.rotation = Quaternion.Euler(0, -175.94f, 89.27f);
            bookHistory.SetActive(true);
            PlayerPrefs.DeleteKey("LivreHistoire_Position");
            PlayerPrefs.DeleteKey("LivreHistoire_Rotation");
        }

        //sciences
        if (PlayerPrefs.HasKey("LivreSciences_Position") && PlayerPrefs.HasKey("LivreSciences_Rotation"))
        {
            Vector3 savedPositionSciences = JsonUtility.FromJson<Vector3>(PlayerPrefs.GetString("LivreSciences_Position"));
            Quaternion savedRotationSciences = JsonUtility.FromJson<Quaternion>(PlayerPrefs.GetString("LivreSciences_Rotation"));

            bookSciences.transform.position = savedPositionSciences;
            bookSciences.transform.rotation = savedRotationSciences;
            bookSciences.SetActive(true);
            CantSciencesBook = true;
        }

        if (PlayerPrefs.HasKey("LivreSciences"))
        {
            bookSciences.transform.localPosition = new Vector3(3.22f, 0.90f, 5.46f);
            bookSciences.transform.rotation = Quaternion.Euler(-0.17f, -189.65f, 89.29f);
            bookSciences.SetActive(true);
            PlayerPrefs.DeleteKey("LivreSciences_Position");
            PlayerPrefs.DeleteKey("LivreSciences_Rotation");
        }

        //chien
        if (PlayerPrefs.HasKey("LivreChien_Position") && PlayerPrefs.HasKey("LivreChien_Rotation"))
        {
            Vector3 savedPositionChien = JsonUtility.FromJson<Vector3>(PlayerPrefs.GetString("LivreChien_Position"));
            Quaternion savedRotationChien = JsonUtility.FromJson<Quaternion>(PlayerPrefs.GetString("LivreChien_Rotation"));

            bookChien.transform.position = savedPositionChien;
            bookChien.transform.rotation = savedRotationChien;
            bookChien.SetActive(true);
            CantChienBook = true;
        }

        if (PlayerPrefs.HasKey("LivreChien"))
        {
            bookChien.transform.localPosition = new Vector3(3.24f, 0.94f, 5.53f);
            bookChien.transform.rotation = Quaternion.Euler(-0.27f, -154.12f, 89.32f);
            bookChien.SetActive(true);
            PlayerPrefs.DeleteKey("LivreChien_Position");
            PlayerPrefs.DeleteKey("LivreChien_Rotation");
        }
    }
}
