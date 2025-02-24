using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickUpRobot : MonoBehaviour
{
    public GameObject Playeurs;
    //référence script
    public Inventory inventory;
    //BrasR
    public bool brasRPickUp = false;
    public GameObject brasR;
    public bool brasRIsPickup = false;
    public bool triggerEnabled = true;
    //MainR
    public bool mainRtriggerEnabled = true;
    public bool mainRIsPickup = false;
    public bool mainRPickUp = false;
    public GameObject mainR;
    //Tete
    public bool teteTriggerEnabled = true;
    public bool teteIsPickup = false;
    public bool tetePickUp = false;
    public GameObject tete;
    //BrasG
    public bool brasGPickUp = false;
    public GameObject brasG;
    public bool brasGIsPickup = false;
    public bool brasGtriggerEnabled = true;
    //HUD
    public GameObject iconE;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "brasR")
        {
            if (triggerEnabled == false)
            {
                brasRPickUp = false;
                iconE.SetActive(false);
            }
            else
            {
                brasRPickUp = true;
                brasR = other.gameObject;
                iconE.SetActive(true);
            }
        }
        //mainR
        if (other.gameObject.tag == "mainR")
        {
            if (mainRtriggerEnabled == false)
            {
                mainRPickUp = false;
                iconE.SetActive(false);
            }
            else
            {
                mainRPickUp = true;
                mainR = other.gameObject;
                iconE.SetActive(true);
            }
        }
        //tete
        if (other.gameObject.tag == "tete")
        {
            if (teteTriggerEnabled == false)
            {
                tetePickUp = false;
                iconE.SetActive(false);
            }
            else
            {
                tetePickUp = true;
                tete = other.gameObject;
                iconE.SetActive(true);
            }
        }
        //brasG
        if (other.gameObject.tag == "BrasG")
        {
            if (brasGtriggerEnabled == false)
            {
                brasGPickUp = false;
                iconE.SetActive(false);
            }
            else
            {
                brasGPickUp = true;
                brasG = other.gameObject;
                iconE.SetActive(true);
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "brasR")
        {
            brasRPickUp = false;
            iconE.SetActive(false);
        }
        //mainR
        if (other.gameObject.tag == "mainR")
        {
            mainRPickUp = false;
            iconE.SetActive(false);
        }
        //tete
        if (other.gameObject.tag == "tete")
        {
            tetePickUp = false;
            iconE.SetActive(false);
        }
        //brasG
        if (other.gameObject.tag == "BrasG")
        {
            brasGPickUp = false;
            iconE.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && brasRPickUp)
        {
            brasR.SetActive(false);
            iconE.SetActive(false);
            brasRPickUp=false;
            brasRIsPickup = true;
            inventory.inventory = 1;
        }
        //mainR
        if (Input.GetKeyDown(KeyCode.E) && mainRPickUp)
        {
            mainR.SetActive(false);
            iconE.SetActive(false);
            mainRPickUp = false;
            mainRIsPickup = true;
            inventory.inventory = 1;
        }
        //tete
        if (Input.GetKeyDown(KeyCode.E) && tetePickUp)
        {
            tete.SetActive(false);
            iconE.SetActive(false);
            tetePickUp = false;
            teteIsPickup = true;
            inventory.inventory = 1;
        }
        //brasG
        if (Input.GetKeyDown(KeyCode.E) && brasGPickUp)
        {
            brasG.SetActive(false);
            iconE.SetActive(false);
            brasGPickUp = false;
            brasGIsPickup = true;
            inventory.inventory = 1;
        }
    }
}
