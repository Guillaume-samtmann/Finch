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

    public GameObject costume;

    private void Start()
    {
        Cursor.visible = false;
        if (PlayerPrefs.HasKey("CostumeIsTaking"))
        {
            Cursor.lockState = CursorLockMode.Locked;
            costume.gameObject.SetActive(false);
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
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject.tag == "repartCostume")
        {
            canRepart = false;
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
            PlayerPrefs.SetInt("CostumeIsTaking", 1);
        }
    }
}
