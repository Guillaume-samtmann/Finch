using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayeurControllerOpenWorld : MonoBehaviour
{
    bool canGoUnderground = false;
    bool canInspectCar = false;
    bool canInspectCar1 = false;
    bool canInspectCar2 = false;
    bool canInspectBus1 = false;
    public GameObject iconeE;
    public Text nbrMateriauxTxt;
    public Text infoTxt;
    public GameObject panelInfo;

    public int inventaireRessource = 0;
    public int newValue;

    private void Start()
    {
        //PlayerPrefs.DeleteAll();
        //PlayerPrefs.Save();

        if (PlayerPrefs.HasKey("jambeRreparer"))
        {
            if (PlayerPrefs.HasKey("newValueInventaire"))
            {
                inventaireRessource = PlayerPrefs.GetInt("inventaireRessource");
                Debug.Log(inventaireRessource);
                nbrMateriauxTxt.text = inventaireRessource.ToString();
            }
            else
            {
                inventaireRessource = PlayerPrefs.GetInt("inventaireRessource");
                inventaireRessource = inventaireRessource - 10;
                Debug.Log(inventaireRessource);
                nbrMateriauxTxt.text = inventaireRessource.ToString();
                PlayerPrefs.SetInt("newValueInventaire", 1);
                PlayerPrefs.Save();
            }
        }
        else
        {
            inventaireRessource = PlayerPrefs.GetInt("inventaireRessource");
            Debug.Log(inventaireRessource);
            nbrMateriauxTxt.text = inventaireRessource.ToString();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "GoToCave")
        {
            canGoUnderground = true;
            iconeE.SetActive(true);

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
        if (other.gameObject.tag == "InspecterCar2")
        {
            canInspectCar2 = true;
            iconeE.SetActive(true);
        }
        if (other.gameObject.tag == "InspecterBus1")
        {
            canInspectBus1 = true;
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
        if (other.gameObject.tag == "InspecterCar2")
        {
            canInspectCar2 = false;
            iconeE.SetActive(false);
            panelInfo.SetActive(false);
        }
        if (other.gameObject.tag == "InspecterBus1")
        {
            canInspectBus1 = false;
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

        if(Input.GetKeyDown(KeyCode.E) && canInspectCar)
        {
            if (PlayerPrefs.HasKey("police_carInspecter"))
            {
                panelInfo.SetActive(true);
                infoTxt.text = "Véhicule déja fouillier !";
            }
            else
            {
                int nbrMateriaux = Random.Range(1, 7);
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
                int nbrMateriaux1 = Random.Range(1, 5);
                inventaireRessource += nbrMateriaux1;
                nbrMateriauxTxt.text = inventaireRessource.ToString();
                PlayerPrefs.SetInt("police_carInspecter1", 1);
                PlayerPrefs.Save();
                Debug.Log(nbrMateriaux1);
            }
        }

        if (Input.GetKeyDown(KeyCode.E) && canInspectCar2)
        {
            if (PlayerPrefs.HasKey("minibus_carInspecter2"))
            {
                panelInfo.SetActive(true);
                infoTxt.text = "Véhicule déja fouillier !";
            }
            else
            {
                int nbrMateriaux2 = Random.Range(1, 5);
                inventaireRessource += nbrMateriaux2;
                nbrMateriauxTxt.text = inventaireRessource.ToString();
                PlayerPrefs.SetInt("minibus_carInspecter2", 1);
                PlayerPrefs.Save();
                Debug.Log(nbrMateriaux2);
            }
        }
        if (Input.GetKeyDown(KeyCode.E) && canInspectBus1)
        {
            if (PlayerPrefs.HasKey("busInspecter1"))
            {
                panelInfo.SetActive(true);
                infoTxt.text = "Véhicule déja fouillier !";
            }
            else
            {
                int nbrMateriaux3 = Random.Range(2, 8);
                inventaireRessource += nbrMateriaux3;
                nbrMateriauxTxt.text = inventaireRessource.ToString();
                PlayerPrefs.SetInt("busInspecter1", 1);
                PlayerPrefs.Save();
            }
        }
        PlayerPrefs.SetInt("inventaireRessource", inventaireRessource);
        PlayerPrefs.Save();
    }
}
