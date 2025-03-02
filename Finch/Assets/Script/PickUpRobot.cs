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
    //public bool jambeLtriggerEnabled = true;
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

}
