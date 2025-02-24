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
    //mainG
    bool dropMainG = false;
    //jambeR
    bool dropjambeR = false;
    //piedR
    bool dropPiedR = false;
    //jambeL
    bool dropjambeL = false;
    //piedL
    bool dropPiedL = false;
    //HUD
    public GameObject iconR;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "triggeurBrasR")
        {
            if (pickUpRobot.brasRIsPickup == false)
            {
                iconR.SetActive(false);
            }
            else
            {
                if (pickUpRobot.triggerEnabled == false)
                {
                    dropBrasR = false;
                    iconR.SetActive(false);
                }
                else
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
        //mainG
        if (other.gameObject.tag == "triggeurMainG")
        {
            if (pickUpRobot.mainGIsPickup == false)
            {
                iconR.SetActive(false);
            }
            else
            {
                if (pickUpRobot.mainGtriggerEnabled == false)
                {
                    dropMainG = false;
                    iconR.SetActive(false);
                }
                else
                {
                    dropMainG = true;
                    iconR.SetActive(true);
                }
            }
        }
        //jambeR
        if (other.gameObject.tag == "triggeurJambeR")
        {
            if (pickUpRobot.jambeRIsPickup == false)
            {
                iconR.SetActive(false);
            }
            else
            {
                if (pickUpRobot.jambeRtriggerEnabled == false)
                {
                    dropjambeR = false;
                    iconR.SetActive(false);
                }
                else
                {
                    dropjambeR = true;
                    iconR.SetActive(true);
                }
            }
        }
        //piedR
        if (other.gameObject.tag == "triggeurPiedR")
        {
            if (pickUpRobot.piedRIsPickup == false)
            {
                iconR.SetActive(false);
            }
            else
            {
                if (pickUpRobot.piedRtriggerEnabled == false)
                {
                    dropPiedR = false;
                    iconR.SetActive(false);
                }
                else
                {
                    dropPiedR = true;
                    iconR.SetActive(true);
                }
            }
        }
        //jambeL
        if (other.gameObject.tag == "triggeurJambeL")
        {
            if (pickUpRobot.jambeLIsPickup == false)
            {
                iconR.SetActive(false);
            }
            else
            {
                if (pickUpRobot.jambeLtriggerEnabled == false)
                {
                    dropjambeL = false;
                    iconR.SetActive(false);
                }
                else
                {
                    dropjambeL = true;
                    iconR.SetActive(true);
                }
            }
        }
        //piedL
        if (other.gameObject.tag == "triggeurPiedL")
        {
            if (pickUpRobot.piedLIsPickup == false)
            {
                iconR.SetActive(false);
            }
            else
            {
                if (pickUpRobot.piedLtriggerEnabled == false)
                {
                    dropPiedL = false;
                    iconR.SetActive(false);
                }
                else
                {
                    dropPiedL = true;
                    iconR.SetActive(true);
                }
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "triggeurBrasR")
        {
            dropBrasR = false;
            iconR.SetActive(false);
        }
        //MainR
        if (other.gameObject.tag == "triggeurMainR")
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
        //MainG
        if (other.gameObject.tag == "triggeurMainG")
        {
            dropMainG = false;
            iconR.SetActive(false);
        }
        //JambeR
        if (other.gameObject.tag == "triggeurJambeR")
        {
            dropjambeR = false;
            iconR.SetActive(false);
        }
        //PiedR
        if (other.gameObject.tag == "triggeurPiedR")
        {
            dropPiedR = false;
            iconR.SetActive(false);
        }
        //JambeL
        if (other.gameObject.tag == "triggeurJambeL")
        {
            dropjambeL = false;
            iconR.SetActive(false);
        }
        //PiedL
        if (other.gameObject.tag == "triggeurPiedL")
        {
            dropPiedL = false;
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
        //mainG
        if (Input.GetKeyUp(KeyCode.R) && dropMainG)
        {
            iconR.SetActive(false);
            pickUpRobot.mainG.transform.localPosition = new Vector3(3.62f, 5.21f, -0.88f);
            pickUpRobot.mainG.transform.rotation = Quaternion.Euler(-68.79f, 163.54f, 14.87f);
            pickUpRobot.mainG.SetActive(true);
            pickUpRobot.mainGtriggerEnabled = false;
            inventory.inventory = 0;
        }
        //jambeR
        if (Input.GetKeyUp(KeyCode.R) && dropjambeR)
        {
            iconR.SetActive(false);
            pickUpRobot.jambeR.transform.localPosition = new Vector3(-1.48f, 4.35f, -0.31f);
            pickUpRobot.jambeR.transform.rotation = Quaternion.Euler(-89.98f, 0, 0);
            pickUpRobot.jambeR.SetActive(true);
            pickUpRobot.jambeRtriggerEnabled = false;
            inventory.inventory = 0;
        }
        //piedR
        if (Input.GetKeyUp(KeyCode.R) && dropPiedR)
        {
            iconR.SetActive(false);
            pickUpRobot.piedR.transform.localPosition = new Vector3(-1.46f, 0f, 0f);
            pickUpRobot.piedR.transform.rotation = Quaternion.Euler(-89.98f, 0, 0);
            pickUpRobot.piedR.SetActive(true);
            pickUpRobot.piedRtriggerEnabled = false;
            inventory.inventory = 0;
        }
        //jambeL
        if (Input.GetKeyUp(KeyCode.R) && dropjambeL)
        {
            iconR.SetActive(false);
            pickUpRobot.jambeL.transform.localPosition = new Vector3(1.52f, 4.35f, -0.31f);
            pickUpRobot.jambeL.transform.rotation = Quaternion.Euler(-89.98f, 0, 0);
            pickUpRobot.jambeL.SetActive(true);
            pickUpRobot.jambeLtriggerEnabled = false;
            inventory.inventory = 0;
        }
        //piedL
        if (Input.GetKeyUp(KeyCode.R) && dropPiedL)
        {
            iconR.SetActive(false);
            pickUpRobot.piedL.transform.localPosition = new Vector3(1.54f, 0f, 0f);
            pickUpRobot.piedL.transform.rotation = Quaternion.Euler(-89.98f, 0, 0);
            pickUpRobot.piedL.SetActive(true);
            pickUpRobot.piedLtriggerEnabled = false;
            inventory.inventory = 0;
        }
    }
}
