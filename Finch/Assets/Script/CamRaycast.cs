using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CamRaycast : MonoBehaviour
{
    //référence
    public PickUpRobot pickUpRobot;
    public Inventory inventory;

    //variable
    Outline ol;
    private GameObject previousHittedObject;
    public GameObject iconeE;
    public GameObject tete;
    public GameObject brasG;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void HighlightObject(GameObject obj, bool highlight)
    {
        Outline outline = obj.GetComponent<Outline>();
        if(outline != null)
        {
            outline.enabled = highlight;
        }
    }

    private void FixedUpdate()
    {
        RaycastHit hit;
        GameObject hittedObject = null;
        float raycastDistance = 1.0f;

        if (Physics.Raycast(Camera.main.transform.position, Camera.main.transform.forward, out hit, raycastDistance))
        {
            hittedObject = hit.transform.gameObject;
            string tag = hittedObject.tag;

            if (tag == "pieceRobots")
            {
                HighlightObject(hittedObject, true);
                iconeE.SetActive(true);
                switch (hittedObject.name)
                {
                    case "tete":
                        pickUpRobot.tetePickUp = true;
                        break;
                    case "bras.G":
                        pickUpRobot.brasGPickUp = true;
                        break;
                }

                if (previousHittedObject != hittedObject)
                {
                    if (previousHittedObject != null)
                    {
                        HighlightObject(previousHittedObject, false);
                    }
                    previousHittedObject = hittedObject;
                }
            }
            else
            {
                if (previousHittedObject != null)
                {
                    HighlightObject(previousHittedObject, false);
                    previousHittedObject = null;
                }
                iconeE.SetActive(false);
                switch (hittedObject.name)
                {
                    case "tete":
                        pickUpRobot.tetePickUp = false;
                        break;
                    case "bras.G":
                        pickUpRobot.brasGPickUp = false;
                        break;
                }
            }

            // Interaction avec obj
            if (Input.GetKeyUp(KeyCode.E) && hittedObject != null)
            {
                if (hittedObject.tag == "pieceRobots")
                {
                    switch (hittedObject.name)
                    {
                        case "tete":
                            if (PlayerPrefs.GetInt("TeteIsConfig", 0) == 1)
                            {
                                if (pickUpRobot.tetePickUp)
                                {
                                    pickUpRobot.tete.SetActive(false);
                                    iconeE.SetActive(false);
                                    pickUpRobot.tetePickUp = false;
                                    pickUpRobot.teteIsPickup = true;
                                    inventory.inventory = 1;
                                }
                                //Debug.Log("Tete config");
                            }
                            else
                            {

                            }
                            break;
                        case "bras.G":
                            if (PlayerPrefs.GetInt("BrasGIsConfig", 0) == 1)
                            {
                                if (pickUpRobot.brasGPickUp)
                                {
                                    pickUpRobot.brasG.SetActive(false);
                                    iconeE.SetActive(false);
                                    pickUpRobot.brasGPickUp = false;
                                    pickUpRobot.brasGIsPickup = true;
                                    inventory.inventory = 1;
                                    pickUpRobot.brasGAttach = true;
                                }
                                //Debug.Log("BrasG config");
                            }
                            else
                            {
                                //Debug.Log("BrasG non config");
                            }
                            break;
                    }
                }
            }
        }
    }

}
