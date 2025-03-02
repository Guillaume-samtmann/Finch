using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GestionMateraiux : MonoBehaviour
{
    public CamRaycast camRaycast;
    public PickUpRobot pickUpRobot;
    public Text nbrMateriaux;
    public int nbrMateriauxID;
    bool canGoOutside = false;
    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.HasKey("jambeRreparer"))
        {
            if (PlayerPrefs.HasKey("newValueInventaire"))
            {
                nbrMateriauxID = PlayerPrefs.GetInt("inventaireRessource");
                PlayerPrefs.SetInt("inventaireRessource", nbrMateriauxID);
                PlayerPrefs.Save();
                Debug.Log(nbrMateriauxID);
                nbrMateriaux.text = nbrMateriauxID.ToString();
            }
            else
            {
                nbrMateriauxID = PlayerPrefs.GetInt("inventaireRessource");
                nbrMateriauxID = nbrMateriauxID - 10;
                PlayerPrefs.SetInt("inventaireRessource", nbrMateriauxID);
                PlayerPrefs.Save();
                Debug.Log(nbrMateriauxID);
                nbrMateriaux.text = nbrMateriauxID.ToString();
            }
        }
        else
        {
            nbrMateriauxID = PlayerPrefs.GetInt("inventaireRessource");
            Debug.Log(nbrMateriauxID);
            nbrMateriaux.text = nbrMateriauxID.ToString();
        }

        if (PlayerPrefs.HasKey("jambeRreparer"))
        {
            camRaycast.jambeCasser.SetActive(false);
            pickUpRobot.jambeR.SetActive(true);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "GoToOpenWorld")
        {
            if (PlayerPrefs.HasKey("canTakeCostume"))
            {
                canGoOutside = true;
                pickUpRobot.iconE.SetActive(true);
            }
            else
            {
                canGoOutside = false;
                camRaycast.nameObj.SetActive(true);
                camRaycast.infoNameObj.text = "Impossible de sortir sans la combinaison";
            }
            
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "GoToOpenWorld")
        {
            canGoOutside = false;
            camRaycast.nameObj.SetActive(false);
            pickUpRobot.iconE.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && canGoOutside)
        {
            SceneManager.LoadScene(2);
        }

    }
}
