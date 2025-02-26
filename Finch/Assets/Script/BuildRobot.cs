using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
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

    private void Start()
    {
        //PlayerPrefs.DeleteAll();
        //PlayerPrefs.Save();

        //brasR
        if (PlayerPrefs.HasKey("BrasR_Position") && PlayerPrefs.HasKey("BrasR_Rotation"))
        {
            Vector3 savedPosition = JsonUtility.FromJson<Vector3>(PlayerPrefs.GetString("BrasR_Position"));
            Quaternion savedRotation = JsonUtility.FromJson<Quaternion>(PlayerPrefs.GetString("BrasR_Rotation"));

            pickUpRobot.brasR.transform.position = savedPosition;
            pickUpRobot.brasR.transform.rotation = savedRotation;
            pickUpRobot.brasR.SetActive(true);
        }

        //MainR
        if (PlayerPrefs.HasKey("MainR_Position") && PlayerPrefs.HasKey("MainR_Rotation"))
        {
            Vector3 savedPosition = JsonUtility.FromJson<Vector3>(PlayerPrefs.GetString("MainR_Position"));
            Quaternion savedRotation = JsonUtility.FromJson<Quaternion>(PlayerPrefs.GetString("MainR_Rotation"));

            pickUpRobot.mainR.transform.position = savedPosition;
            pickUpRobot.mainR.transform.rotation= savedRotation;
            pickUpRobot.mainR.SetActive(true);
        }

        //tete
        if (PlayerPrefs.HasKey("Tete_Position") && PlayerPrefs.HasKey("Tete_Rotation"))
        {
            Vector3 savedPosition = JsonUtility.FromJson<Vector3>(PlayerPrefs.GetString("Tete_Position"));
            Quaternion savedRotation = JsonUtility.FromJson<Quaternion>(PlayerPrefs.GetString("Tete_Rotation"));

            pickUpRobot.tete.transform.position = savedPosition;
            pickUpRobot.tete.transform.rotation= savedRotation;
            pickUpRobot.tete.SetActive(true);
        }

        //brasG
        if (PlayerPrefs.HasKey("BrasG_Position") && PlayerPrefs.HasKey("BrasG_Rotation"))
        {
            Vector3 savedPosition = JsonUtility.FromJson<Vector3>(PlayerPrefs.GetString("BrasG_Position"));
            Quaternion savedRotation = JsonUtility.FromJson<Quaternion>(PlayerPrefs.GetString("BrasG_Rotation"));

            pickUpRobot.brasG.transform.position = savedPosition;
            pickUpRobot.brasG.transform.rotation = savedRotation;
            pickUpRobot.brasG.SetActive(true);
        }

        //mainG
        if(PlayerPrefs.HasKey("MainG_Position") && PlayerPrefs.HasKey("MainG_Rotation"))
        {
            Vector3 savedPosition = JsonUtility.FromJson<Vector3>(PlayerPrefs.GetString("MainG_Position"));
            Quaternion savedRotation = JsonUtility.FromJson<Quaternion>(PlayerPrefs.GetString("MainG_Rotation"));

            pickUpRobot.mainG.transform.position = savedPosition;
            pickUpRobot.mainG.transform.rotation = savedRotation;
            pickUpRobot.mainG.SetActive(true);
        }

        //jambeR
        if(PlayerPrefs.HasKey("JambeR_Position") && PlayerPrefs.HasKey("JambeR_Rotation"))
        {
            Vector3 savedPosition = JsonUtility.FromJson<Vector3>(PlayerPrefs.GetString("JambeR_Position"));
            Quaternion savedRotation = JsonUtility.FromJson<Quaternion>(PlayerPrefs.GetString("JambeR_Rotation"));

            pickUpRobot.jambeR.transform.position = savedPosition;
            pickUpRobot.jambeR.transform.rotation = savedRotation;
            pickUpRobot.jambeR.SetActive(true);
        }

        //piedR
        if (PlayerPrefs.HasKey("PiedR_Position") && PlayerPrefs.HasKey("PiedR_Rotation"))
        {
            Vector3 savedPosition = JsonUtility.FromJson<Vector3>(PlayerPrefs.GetString("PiedR_Position"));
            Quaternion savedRotation = JsonUtility.FromJson<Quaternion>(PlayerPrefs.GetString("PiedR_Rotation"));

            pickUpRobot.piedR.transform.position = savedPosition;
            pickUpRobot.piedR.transform.rotation = savedRotation;
            pickUpRobot.piedR.SetActive(true);
        }

        //jambeL
        if(PlayerPrefs.HasKey("JambeL_Position") && PlayerPrefs.HasKey("JambeL_Rotation"))
        {
            Vector3 savedPosition = JsonUtility.FromJson<Vector3>(PlayerPrefs.GetString("JambeL_Position"));
            Quaternion savedRotation = JsonUtility.FromJson<Quaternion>(PlayerPrefs.GetString("JambeL_Rotation"));

            pickUpRobot.jambeL.transform.position = savedPosition;
            pickUpRobot.jambeL.transform.rotation = savedRotation;
            pickUpRobot.jambeL.SetActive(true);
        }

        //piedL
        if(PlayerPrefs.HasKey("PiedL_Position") && PlayerPrefs.HasKey("PiedL_Rotation"))
        {
            Vector3 savedPosition = JsonUtility.FromJson<Vector3>(PlayerPrefs.GetString("PiedL_Position"));
            Quaternion savedRotation = JsonUtility.FromJson<Quaternion>(PlayerPrefs.GetString("PiedL_Rotation"));

            pickUpRobot.piedL.transform.localPosition = savedPosition;
            pickUpRobot.piedL.transform.rotation = savedRotation;
            pickUpRobot.piedL.SetActive(true);
        }
    }

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

            PlayerPrefs.SetString("BrasR_Position", JsonUtility.ToJson(pickUpRobot.brasR.transform.position));
            PlayerPrefs.SetString("BrasR_Rotation", JsonUtility.ToJson(pickUpRobot.brasR.transform.rotation));
            PlayerPrefs.Save();
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

            PlayerPrefs.SetString("MainR_Position", JsonUtility.ToJson(pickUpRobot.mainR.transform.position));
            PlayerPrefs.SetString("MainR_Rotation", JsonUtility.ToJson(pickUpRobot.mainR.transform.rotation));
            PlayerPrefs.Save();
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

            PlayerPrefs.SetString("Tete_Position", JsonUtility.ToJson(pickUpRobot.tete.transform.position));
            PlayerPrefs.SetString("Tete_Rotation", JsonUtility.ToJson(pickUpRobot.tete.transform.rotation));
            PlayerPrefs.Save();
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

            PlayerPrefs.SetString("BrasG_Position", JsonUtility.ToJson(pickUpRobot.brasG.transform.position));
            PlayerPrefs.SetString("BrasG_Rotation", JsonUtility.ToJson(pickUpRobot.brasG.transform.rotation));
            PlayerPrefs.Save();
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

            PlayerPrefs.SetString("MainG_Position", JsonUtility.ToJson(pickUpRobot.mainG.transform.position));
            PlayerPrefs.SetString("MainG_Rotation", JsonUtility.ToJson(pickUpRobot.mainG.transform.rotation));
            PlayerPrefs.Save();
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

            PlayerPrefs.SetString("JambeR_Position", JsonUtility.ToJson(pickUpRobot.jambeR.transform.position));
            PlayerPrefs.SetString("JambeR_Rotation", JsonUtility.ToJson(pickUpRobot.jambeR.transform.rotation));
            PlayerPrefs.Save();
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

            PlayerPrefs.SetString("PiedR_Position", JsonUtility.ToJson(pickUpRobot.piedR.transform.position));
            PlayerPrefs.SetString("PiedR_Rotation", JsonUtility.ToJson(pickUpRobot.piedR.transform.rotation));
            PlayerPrefs.Save();
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

            PlayerPrefs.SetString("JambeL_Position", JsonUtility.ToJson(pickUpRobot.jambeL.transform.position));
            PlayerPrefs.SetString("JambeL_Rotation", JsonUtility.ToJson(pickUpRobot.jambeL.transform.rotation));
            PlayerPrefs.Save();
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

            PlayerPrefs.SetString("PiedL_Position", JsonUtility.ToJson(pickUpRobot.piedL.transform.localPosition));
            PlayerPrefs.SetString("PiedL_Rotation", JsonUtility.ToJson(pickUpRobot.piedL.transform.rotation));
            PlayerPrefs.Save();
        }
    }
}
