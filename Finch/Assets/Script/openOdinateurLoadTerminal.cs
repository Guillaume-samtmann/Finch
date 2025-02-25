using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class openOdinateurLoadTerminal : MonoBehaviour
{
    public PickUpRobot pickUpRobot;
    bool canOpenDesktop = false;
    public GameObject burreau;
    public GameObject Playeurs;
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "openOrdinateur")
        {
            canOpenDesktop = true;
            burreau = other.gameObject;
            pickUpRobot.iconE.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject.tag == "openOrdinateur")
        {
            canOpenDesktop = false;
            pickUpRobot.iconE.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyUp(KeyCode.E) && canOpenDesktop) {
            SceneManager.LoadScene(1);
        }
        
    }
}
