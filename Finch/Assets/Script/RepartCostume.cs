using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RepartCostume : MonoBehaviour
{
    public PickUpRobot pickUpRobot;
    public CamRaycast camRaycast;

    bool canRepart = false;
    bool isRepart = false;
    bool retirerCostume = false;

    public GameObject costume;
    public GameObject CanvaCostume;

    private void Start()
    {
        Cursor.visible = false;
        if (PlayerPrefs.HasKey("CostumeIsTaking"))
        {
            Cursor.lockState = CursorLockMode.Locked;
            costume.gameObject.SetActive(false);
            CanvaCostume.gameObject.SetActive(true);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "repartCostume")
        {
            if (PlayerPrefs.HasKey("costumeRepart"))
            {
                isRepart = true;
                canRepart = false;
                pickUpRobot.iconE.SetActive(true);
                camRaycast.nameObj.SetActive(true);
                camRaycast.infoNameObj.text = "La combinaison est réparer press E pour la porter";
                PlayerPrefs.SetInt("canTakeCostume", 1);
            }
            else
            {
                canRepart = true;
                pickUpRobot.iconE.SetActive(true);
                camRaycast.nameObj.SetActive(true);
                camRaycast.infoNameObj.text = "La combinaison est cassé press E pour la réparer";
            }
        }

        if(other.gameObject.tag == "retireCostume")
        {
            retirerCostume = true;
            pickUpRobot.iconE.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject.tag == "repartCostume")
        {
            canRepart = false;
            pickUpRobot.iconE.SetActive(false);
        }

        if (other.gameObject.tag == "retireCostume")
        {
            retirerCostume = false;
            pickUpRobot.iconE.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyUp(KeyCode.E) && canRepart) 
        {
            SceneManager.LoadScene(3);
        }

        if(Input.GetKeyUp(KeyCode.E) && PlayerPrefs.HasKey("canTakeCostume") && isRepart)
        {
            camRaycast.nameObj.SetActive(true);
            camRaycast.infoNameObj.text = "Tu est prêt pour sortir";
            costume.gameObject.SetActive(false);
            CanvaCostume.gameObject.SetActive(true);
            PlayerPrefs.SetInt("CostumeIsTaking", 1);
        }
        if( Input.GetKeyUp(KeyCode.E) && retirerCostume)
        {
            costume.gameObject.SetActive(true);
            CanvaCostume.gameObject.SetActive(false);
            retirerCostume = false;
            PlayerPrefs.DeleteKey("CostumeIsTaking");
            PlayerPrefs.Save();
        }
    }
}
