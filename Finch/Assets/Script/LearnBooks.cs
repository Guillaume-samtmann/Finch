using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearnBooks : MonoBehaviour
{
    //reference
    
    //varaiable
    public GameObject bookHistory;
    public bool HistoryBook = false;
    public bool CantHistoryBook = false;
    // Start is called before the first frame update
    void Start()
    {
        if(PlayerPrefs.HasKey("LivreHistoire_Position") && PlayerPrefs.HasKey("LivreHistoire_Rotation"))
        {
            Vector3 savedPosition = JsonUtility.FromJson<Vector3>(PlayerPrefs.GetString("LivreHistoire_Position"));
            Quaternion savedRotation = JsonUtility.FromJson<Quaternion>(PlayerPrefs.GetString("LivreHistoire_Rotation"));

            bookHistory.transform.position = savedPosition;
            bookHistory.transform.rotation = savedRotation;
            bookHistory.SetActive(true);
            CantHistoryBook=true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
