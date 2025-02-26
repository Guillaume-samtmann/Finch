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
    public bool brasAttach = false;
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
    //MainG
    public bool mainGtriggerEnabled = true;
    public bool mainGIsPickup = false;
    public bool mainGPickUp = false;
    public GameObject mainG;
    public bool brasGAttach = false;
    //jambeR
    public bool jambeRtriggerEnabled = true;
    public bool jambeRIsPickup = false;
    public bool jambeRPickUp = false;
    public GameObject jambeR;
    public bool jambeRAttach = false;
    //piedR
    public bool piedRtriggerEnabled = true;
    public bool piedRIsPickup = false;
    public bool piedRPickUp = false;
    public GameObject piedR;
    //jambeL
    public bool jambeLtriggerEnabled = true;
    public bool jambeLIsPickup = false;
    public bool jambeLPickUp = false;
    public GameObject jambeL;
    public bool jambeLAttach = false;
    //piedL
    public bool piedLtriggerEnabled = true;
    public bool piedLIsPickup = false;
    public bool piedLPickUp = false;
    public GameObject piedL;
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
            if (PlayerPrefs.HasKey("BrasR_Position") && PlayerPrefs.HasKey("BrasR_Rotation"))
            {
                mainRPickUp = true;
                mainR = other.gameObject;
                iconE.SetActive(true);
            }
            else
            {
                if (mainRtriggerEnabled == false || brasAttach == false)
                {
                    mainRPickUp = false;
                    iconE.SetActive(false);
                    Debug.Log("Main droite impossible a récupérer car le bras n'est pas posé");
                }
                else
                {
                    mainRPickUp = true;
                    mainR = other.gameObject;
                    iconE.SetActive(true);
                }
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
        //mainG
        if (other.gameObject.tag == "mainG")
        {
            if (PlayerPrefs.HasKey("BrasG_Position") && PlayerPrefs.HasKey("BrasG_Rotation"))
            {
                mainGPickUp = true;
                mainG = other.gameObject;
                iconE.SetActive(true);
            }
            else
            {
                if (mainGtriggerEnabled == false || brasGAttach == false)
                {
                    mainGPickUp = false;
                    iconE.SetActive(false);
                    Debug.Log("Main gauche impossible a récupérer car le bras n'est pas posé");
                }
                else
                {
                    mainGPickUp = true;
                    mainG = other.gameObject;
                    iconE.SetActive(true);
                }
            }      
        }
        //jambeR
        if (other.gameObject.tag == "jambeR")
        {
            if (jambeRtriggerEnabled == false)
            {
                jambeRPickUp = false;
                iconE.SetActive(false);
            }
            else
            {
                jambeRPickUp = true;
                jambeR = other.gameObject;
                iconE.SetActive(true);
            }
        }
        //piedR
        if (other.gameObject.tag == "piedR")
        {
            if (PlayerPrefs.HasKey("JambeR_Position") && PlayerPrefs.HasKey("JambeR_Rotation"))
            {
                piedRPickUp = true;
                piedR = other.gameObject;
                iconE.SetActive(true);
            }
            else
            {
                if (piedRtriggerEnabled == false || jambeRAttach == false)
                {
                    piedRPickUp = false;
                    iconE.SetActive(false);
                    Debug.Log("Pied droit impossible a récupérer car la jambe n'est pas posé");
                }
                else
                {
                    piedRPickUp = true;
                    piedR = other.gameObject;
                    iconE.SetActive(true);
                }
            }
        }
        //jambeL
        if (other.gameObject.tag == "jambeL")
        {
            if (jambeLtriggerEnabled == false)
            {
                jambeLPickUp = false;
                iconE.SetActive(false);
            }
            else
            {
                jambeLPickUp = true;
                jambeL = other.gameObject;
                iconE.SetActive(true);
            }
        }
        //piedL
        if (PlayerPrefs.HasKey("JambeL_Position") && PlayerPrefs.HasKey("JambeL_Rotation"))
        {
            piedLPickUp = true;
            piedL = other.gameObject;
            iconE.SetActive(true);
        }
        else
        {
            if (other.gameObject.tag == "piedL")
            {
                if (piedLtriggerEnabled == false || jambeLAttach == false)
                {
                    piedLPickUp = false;
                    iconE.SetActive(false);
                    Debug.Log("Pied gauche impossible a récupérer car la jambe n'est pas posé");
                }
                else
                {
                    piedLPickUp = true;
                    piedL = other.gameObject;
                    iconE.SetActive(true);
                }
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
        //mainG
        if (other.gameObject.tag == "mainG")
        {
            mainGPickUp = false;
            iconE.SetActive(false);
        }
        //jambeR
        if (other.gameObject.tag == "jambeR")
        {
            jambeRPickUp = false;
            iconE.SetActive(false);
        }
        //piedR
        if (other.gameObject.tag == "piedR")
        {
            piedRPickUp = false;
            iconE.SetActive(false);
        }
        //jambeL
        if (other.gameObject.tag == "jambeL")
        {
            jambeLPickUp = false;
            iconE.SetActive(false);
        }
        //piedL
        if (other.gameObject.tag == "piedL")
        {
            piedLPickUp = false;
            iconE.SetActive(false);
        }
    }

        // Update is called once per frame
    void Update()
    {
        if (PlayerPrefs.GetInt("BrasRIsConfig", 0) == 1)
        {
            if (Input.GetKeyDown(KeyCode.E) && brasRPickUp)
            {
                brasR.SetActive(false);
                iconE.SetActive(false);
                brasRPickUp = false;
                brasRIsPickup = true;
                inventory.inventory = 1;
                brasAttach = true;
            }
            //Debug.Log("BrasR config");
        } 
        else
        {
            //Debug.Log("BrasR non config");
        }

        //mainR
        if (PlayerPrefs.GetInt("MainRIsConfig", 0) == 1)
        {
            if (Input.GetKeyDown(KeyCode.E) && mainRPickUp)
            {
                mainR.SetActive(false);
                iconE.SetActive(false);
                mainRPickUp = false;
                mainRIsPickup = true;
                inventory.inventory = 1;
            }
            //Debug.Log("MainR config");
        }
        else
        {
            //Debug.Log("MainR non config");
        }
            
        //tete
        if(PlayerPrefs.GetInt("TeteIsConfig", 0) == 1)
        {
            if (Input.GetKeyDown(KeyCode.E) && tetePickUp)
            {
                tete.SetActive(false);
                iconE.SetActive(false);
                tetePickUp = false;
                teteIsPickup = true;
                inventory.inventory = 1;
            }
            //Debug.Log("Tete config");
        }
        else
        {
            //Debug.Log("Tete non config");
        }

        //jambeR
        if (PlayerPrefs.GetInt("JambeRIsConfig", 0) == 1)
        {
            if (Input.GetKeyDown(KeyCode.E) && jambeRPickUp)
            {
                jambeR.SetActive(false);
                iconE.SetActive(false);
                jambeRPickUp = false;
                jambeRIsPickup = true;
                inventory.inventory = 1;
                jambeRAttach = true;
            }
            //Debug.Log("JambeR config");
        }
        else
        {
            //Debug.Log("JambeR non config");
        }

        //piedR
        if (PlayerPrefs.GetInt("PiedsRIsConfig", 0) == 1)
        {
            if (Input.GetKeyDown(KeyCode.E) && piedRPickUp)
            {
                piedR.SetActive(false);
                iconE.SetActive(false);
                piedRPickUp = false;
                piedRIsPickup = true;
                inventory.inventory = 1;
            }
            //Debug.Log("PiedR config");
        }
        else
        {
            //Debug.Log("PiedR non config");
        }
        //brasG
        if (PlayerPrefs.GetInt("BrasGIsConfig", 0) == 1)
        {
            if (Input.GetKeyDown(KeyCode.E) && brasGPickUp)
            {
                brasG.SetActive(false);
                iconE.SetActive(false);
                brasGPickUp = false;
                brasGIsPickup = true;
                inventory.inventory = 1;
                brasGAttach = true;
            }
            //Debug.Log("BrasG config");
        }
        else
        {
            //Debug.Log("BrasG non config");
        }
        //mainG
        if (PlayerPrefs.GetInt("MainGIsConfig", 0) == 1)
        {
            if (Input.GetKeyDown(KeyCode.E) && mainGPickUp)
            {
                mainG.SetActive(false);
                iconE.SetActive(false);
                mainGPickUp = false;
                mainGIsPickup = true;
                inventory.inventory = 1;
            }
            //Debug.Log("MainG config");
        }
        else
        {
            //Debug.Log("MainG non config");
        }
        //jambeL
        if (PlayerPrefs.GetInt("JambeGIsConfig", 0) == 1)
        {
            if (Input.GetKeyDown(KeyCode.E) && jambeLPickUp)
            {
                jambeL.SetActive(false);
                iconE.SetActive(false);
                jambeLPickUp = false;
                jambeLIsPickup = true;
                inventory.inventory = 1;
                jambeLAttach = true;
            }
            //Debug.Log("JambeG config");
        }
        else
        {
            //Debug.Log("JambeG non config");
        }

        //piedL
        if (PlayerPrefs.GetInt("PiedGIsConfig", 0) == 1)
        {
            if (Input.GetKeyDown(KeyCode.E) && piedLPickUp)
            {
                piedL.SetActive(false);
                iconE.SetActive(false);
                piedLPickUp = false;
                piedLIsPickup = true;
                inventory.inventory = 1;
            }
            //Debug.Log("PiedG config");
        }
        else
        {
            //Debug.Log("PiedG non config");
        }
    }
}
