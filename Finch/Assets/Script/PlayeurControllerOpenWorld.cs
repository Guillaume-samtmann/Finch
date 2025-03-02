using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayeurControllerOpenWorld : MonoBehaviour
{
    bool canGoUnderground = false;
    bool canGoOutside = false;
    bool canInspectCar = false;
    bool canInspectCar1 = false;
    public GameObject iconeE;
    public Text nbrMateriauxTxt;
    public Text infoTxt;
    public GameObject panelInfo;

    public int inventaireRessource = 0;

    private void Start()
    {
        PlayerPrefs.DeleteAll();
        PlayerPrefs.Save();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "GoToCave")
        {
            canGoUnderground = true;
            iconeE.SetActive(true);

        }
        if(other.gameObject.tag == "GoToOpenWorld")
        {
            canGoOutside = true;
        }
        if(other.gameObject.tag == "InspecterCar")
        {
            canInspectCar = true;
            iconeE.SetActive(true);
        }
        if (other.gameObject.tag == "InspecterCar1")
        {
            canInspectCar1 = true;
            iconeE.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "GoToCave")
        {
            canGoUnderground = false;
            iconeE.SetActive(false);
        }
        if (other.gameObject.tag == "InspecterCar")
        {
            canInspectCar = false;
            iconeE.SetActive(false);
            panelInfo.SetActive(false);
        }
        if (other.gameObject.tag == "InspecterCar1")
        {
            canInspectCar1 = false;
            iconeE.SetActive(false);
            panelInfo.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E) && canGoUnderground)
        {
            SceneManager.LoadScene(0);
        }
        if (Input.GetKeyDown(KeyCode.E) && canGoOutside)
        {
            SceneManager.LoadScene(2);
        }

        if(Input.GetKeyDown(KeyCode.E) && canInspectCar)
        {
            if (PlayerPrefs.HasKey("police_carInspecter"))
            {
                panelInfo.SetActive(true);
                infoTxt.text = "Véhicule déja fouillier !";
            }
            else
            {
                int nbrMateriaux = Random.Range(0, 5);
                inventaireRessource += nbrMateriaux;
                nbrMateriauxTxt.text = inventaireRessource.ToString();
                PlayerPrefs.SetInt("police_carInspecter", 1);
                PlayerPrefs.Save();
                Debug.Log(nbrMateriaux);
            }
        }

        if (Input.GetKeyDown(KeyCode.E) && canInspectCar1)
        {
            if (PlayerPrefs.HasKey("police_carInspecter1"))
            {
                panelInfo.SetActive(true);
                infoTxt.text = "Véhicule déja fouillier !";
            }
            else
            {
                int nbrMateriaux1 = Random.Range(0, 5);
                inventaireRessource += nbrMateriaux1;
                nbrMateriauxTxt.text = inventaireRessource.ToString();
                PlayerPrefs.SetInt("police_carInspecter1", 1);
                PlayerPrefs.Save();
                Debug.Log(nbrMateriaux1);
            }
        }
    }
}
