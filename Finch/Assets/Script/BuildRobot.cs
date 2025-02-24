using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class BuildRobot : MonoBehaviour
{
    //Ref script
    public PickUpRobot pickUpRobot;
    public Inventory inventory;
    //brasR
    bool dropBrasR = false;
    //mainR
    bool dropMainR = false;
    //tete
    bool dropTete = false;
    //brasG
    bool dropBrasG = false;
    //HUD
    public GameObject iconR;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "triggeurBrasR")
        {
            if(pickUpRobot.brasRIsPickup == false)
            {
                iconR.SetActive(false);
            }
            else
            {
                if(pickUpRobot.triggerEnabled == false)
                {
                    dropBrasR = false;
                    iconR.SetActive(false);
                } else
                {
                    dropBrasR = true;
                    iconR.SetActive(true);
                }
            }
        }
        //mainR
        if (other.gameObject.tag == "triggeurMainR")
        {
            if (pickUpRobot.mainRIsPickup == false)
            {
                iconR.SetActive(false);
            }
            else
            {
                if (pickUpRobot.mainRtriggerEnabled == false)
                {
                    dropMainR = false;
                    iconR.SetActive(false);
                }
                else
                {
                    dropMainR = true;
                    iconR.SetActive(true);
                }
            }
        }
        //tete
        if (other.gameObject.tag == "triggeurTete")
        {
            if (pickUpRobot.teteIsPickup == false)
            {
                iconR.SetActive(false);
            }
            else
            {
                if (pickUpRobot.teteTriggerEnabled == false)
                {
                    dropTete = false;
                    iconR.SetActive(false);
                }
                else
                {
                    dropTete = true;
                    iconR.SetActive(true);
                }
            }
        }
        //brasG
        if (other.gameObject.tag == "triggeurBrasG")
        {
            if (pickUpRobot.brasGIsPickup == false)
            {
                iconR.SetActive(false);
            }
            else
            {
                if (pickUpRobot.brasGtriggerEnabled == false)
                {
                    dropBrasG = false;
                    iconR.SetActive(false);
                }
                else
                {
                    dropBrasG = true;
                    iconR.SetActive(true);
                }
            }
        }

    }

    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject.tag == "triggeurBrasR")
        {
            dropBrasR = false;
            iconR.SetActive(false);
        }
        //MainR
        if (other.gameObject.tag == "triggeurBrasR")
        {
            dropMainR = false;
            iconR.SetActive(false);
        }
        //tete
        if (other.gameObject.tag == "triggeurTete")
        {
            dropTete = false;
            iconR.SetActive(false);
        }
        //brasG
        if (other.gameObject.tag == "triggeurBrasG")
        {
            dropBrasG = false;
            iconR.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.R) && dropBrasR)
        {
            iconR.SetActive(false);
            pickUpRobot.brasR.transform.position = new Vector3(1.869f, 1.269f, -1.842f);
            pickUpRobot.brasR.transform.rotation = Quaternion.Euler(-89.98f, 0, 0);
            pickUpRobot.brasR.SetActive(true);
            pickUpRobot.triggerEnabled = false;
            inventory.inventory = 0;
        }
        //MainR
        if (Input.GetKeyUp(KeyCode.R) && dropMainR)
        {
            iconR.SetActive(false);
            pickUpRobot.mainR.transform.localPosition = new Vector3(-3.88f, 5.371f, 0.035f);
            pickUpRobot.mainR.transform.rotation = Quaternion.Euler(-98.909f, 0, 0);
            pickUpRobot.mainR.SetActive(true);
            pickUpRobot.mainRtriggerEnabled = false;
            inventory.inventory = 0;
        }
        //tete
        if (Input.GetKeyUp(KeyCode.R) && dropTete)
        {
            iconR.SetActive(false);
            pickUpRobot.tete.transform.localPosition = new Vector3(0.07f, 13.94f, 0.08f);
            pickUpRobot.tete.transform.rotation = Quaternion.Euler(-90f, 0, 0);
            pickUpRobot.tete.SetActive(true);
            pickUpRobot.teteTriggerEnabled = false;
            inventory.inventory = 0;
        }
        //brasG
        if (Input.GetKeyUp(KeyCode.R) && dropBrasG)
        {
            iconR.SetActive(false);
            pickUpRobot.brasG.transform.localPosition = new Vector3(1.768f, 12.99f, -1.43f);
            pickUpRobot.brasG.transform.rotation = Quaternion.Euler(-90f, 0, 180f);
            pickUpRobot.brasG.SetActive(true);
            pickUpRobot.brasGtriggerEnabled = false;
            inventory.inventory = 0;
        }
    }
}
