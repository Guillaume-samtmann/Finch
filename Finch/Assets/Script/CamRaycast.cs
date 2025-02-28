using Cinemachine.Utility;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CamRaycast : MonoBehaviour
{
    // Références
    public PickUpRobot pickUpRobot;
    public Inventory inventory;
    public LearnBooks LearnBooks;
    public BuildRobot BuildRobot;

    // Variables
    private GameObject previousHittedObject;
    private GameObject hittedObject;  // Stocker l'objet touché globalement
    public GameObject iconeE;
    public GameObject iconeR;
    public GameObject tete;
    public GameObject brasG;
    public GameObject extractBook;

    private void HighlightObject(GameObject obj, bool highlight)
    {
        Outline outline = obj?.GetComponent<Outline>();
        if (outline != null)
        {
            outline.enabled = highlight;
        }
    }

    private void FixedUpdate()
    {
        RaycastHit hit;
        float raycastDistance = 1.0f;

        if (Physics.Raycast(Camera.main.transform.position, Camera.main.transform.forward, out hit, raycastDistance))
        {
            hittedObject = hit.transform.gameObject;

            if (hittedObject.CompareTag("pieceRobots"))
            {
                HighlightObject(hittedObject, true);
                iconeE.SetActive(true);

                if (hittedObject.name == "tete") pickUpRobot.tetePickUp = true;
                if (hittedObject.name == "bras.R") pickUpRobot.brasRPickUp = true;
                if (hittedObject.name == "main.R") pickUpRobot.mainRPickUp = true;
                if (hittedObject.name == "jambe.R") pickUpRobot.jambeRPickUp = true;
                if (hittedObject.name == "pieds.R") pickUpRobot.piedRPickUp = true;
                if (hittedObject.name == "bras.G") pickUpRobot.brasGPickUp = true;
                if (hittedObject.name == "main.G") pickUpRobot.mainGPickUp = true;
                if (hittedObject.name == "jambe.L") pickUpRobot.jambeLPickUp = true;
                if (hittedObject.name == "pieds.L") pickUpRobot.piedLPickUp = true;
            }
            if (hittedObject.CompareTag("books") && PlayerPrefs.HasKey("RobotIsComplet") && LearnBooks.CantHistoryBook == false)
            {
                HighlightObject(hittedObject, true);
                iconeE.SetActive(true);

                if ( hittedObject.name == "bookHistoire")
                {
                    LearnBooks.HistoryBook = true;
                    Debug.Log("tu peux prendre le livre");
                }
                else
                {
                    LearnBooks.HistoryBook = false;
                }
            }
            else
            {
                //Debug.Log("NOOON");
            }
            if (hittedObject.CompareTag("extractBook"))
            {
                HighlightObject(hittedObject, true);
                iconeR.SetActive(true);
                Debug.Log("tu peux déposer le livre");
            }
            if (hittedObject.CompareTag("depotPieceRobot"))
            {
                HighlightObject(hittedObject, true);
                iconeR.SetActive(true);
                Debug.Log("tu peux déposé la piéce");
            }
        }
        else
        {
            // Aucun objet touché
            hittedObject = null;
            iconeE.SetActive(false);
            iconeR.SetActive(false);
            pickUpRobot.tetePickUp = false;
            pickUpRobot.brasRPickUp=false;
            pickUpRobot.mainRPickUp=false;
            pickUpRobot.jambeRPickUp=false;
            pickUpRobot.piedRPickUp=false;
            pickUpRobot.brasGPickUp = false;
            pickUpRobot.mainGPickUp = false;
            pickUpRobot.jambeLPickUp = false;
            pickUpRobot.piedLPickUp = false;
        }

        // Si l'objet ciblé a changé, désactiver l'ancien outline
        if (previousHittedObject != hittedObject)
        {
            if (previousHittedObject != null)
            {
                HighlightObject(previousHittedObject, false);
            }
            previousHittedObject = hittedObject;
        }
    }

    private void Update()
    {
        // Prendre Piéce Robots
        if (Input.GetKeyDown(KeyCode.E) && hittedObject != null && hittedObject.CompareTag("pieceRobots"))
        {
            switch (hittedObject.name)
            {
                case "tete":
                    if (PlayerPrefs.GetInt("TeteIsConfig", 0) == 1 && pickUpRobot.tetePickUp)
                    {
                        pickUpRobot.tete.SetActive(false);
                        iconeE.SetActive(false);
                        pickUpRobot.tetePickUp = false;
                        pickUpRobot.teteIsPickup = true;
                        inventory.inventory = 1;
                    }
                    break;
                case "bras.R":
                    if (PlayerPrefs.GetInt("BrasRIsConfig", 0) == 1 && pickUpRobot.brasRPickUp)
                    {
                        pickUpRobot.brasR.SetActive(false);
                        iconeE.SetActive(false);
                        pickUpRobot.brasRPickUp = false;
                        pickUpRobot.brasRIsPickup = true;
                        inventory.inventory = 1;
                        pickUpRobot.brasAttach = true;
                    }
                    break;
                case "main.R":
                    if (PlayerPrefs.GetInt("MainRIsConfig", 0) == 1 && pickUpRobot.mainRPickUp)
                    {
                        pickUpRobot.mainR.SetActive(false);
                        iconeE.SetActive(false);
                        pickUpRobot.mainRPickUp = false;
                        pickUpRobot.mainRIsPickup = true;
                        inventory.inventory = 1;
                    }
                    break;
                case "jambe.R":
                    if (PlayerPrefs.GetInt("JambeRIsConfig", 0) == 1 && pickUpRobot.jambeRPickUp && pickUpRobot.jambeRAttach == false)
                    {
                        pickUpRobot.jambeR.SetActive(false);
                        iconeE.SetActive(false);
                        pickUpRobot.jambeRPickUp = false;
                        pickUpRobot.jambeRIsPickup = true;
                        inventory.inventory = 1;
                        pickUpRobot.jambeRAttach = true;
                    }
                    break;
                case "pieds.R":
                    if (PlayerPrefs.GetInt("PiedsRIsConfig", 0) == 1 && pickUpRobot.piedRPickUp)
                    {
                        pickUpRobot.piedR.SetActive(false);
                        iconeE.SetActive(false);
                        pickUpRobot.piedRPickUp = false;
                        pickUpRobot.piedRIsPickup = true;
                        inventory.inventory = 1;
                    }
                    break;
                case "bras.G":
                    if (PlayerPrefs.GetInt("BrasGIsConfig", 0) == 1 && pickUpRobot.brasGPickUp)
                    {
                        pickUpRobot.brasG.SetActive(false);
                        iconeE.SetActive(false);
                        pickUpRobot.brasGPickUp = false;
                        pickUpRobot.brasGIsPickup = true;
                        inventory.inventory = 1;
                        pickUpRobot.brasGAttach = true;
                    }
                    break;
                case "main.G":
                    if (PlayerPrefs.GetInt("MainGIsConfig", 0) == 1 && pickUpRobot.mainGPickUp)
                    {
                        pickUpRobot.mainG.SetActive(false);
                        iconeE.SetActive(false);
                        pickUpRobot.mainGPickUp = false;
                        pickUpRobot.mainGIsPickup = true;
                        inventory.inventory = 1;
                    }
                    break;
                case "jambe.L":
                    if (PlayerPrefs.GetInt("JambeGIsConfig", 0) == 1 && pickUpRobot.jambeLPickUp && pickUpRobot.jambeLAttach == false)
                    {
                        pickUpRobot.jambeL.SetActive(false);
                        iconeE.SetActive(false);
                        pickUpRobot.jambeLPickUp = false;
                        pickUpRobot.jambeLIsPickup = true;
                        inventory.inventory = 1;
                        pickUpRobot.jambeLAttach = true;
                    }
                    break;
                case "pieds.L":
                    if (PlayerPrefs.GetInt("PiedGIsConfig", 0) == 1 && pickUpRobot.piedLPickUp)
                    {
                        pickUpRobot.piedL.SetActive(false);
                        iconeE.SetActive(false);
                        pickUpRobot.piedLPickUp = false;
                        pickUpRobot.piedLIsPickup = true;
                        inventory.inventory = 1;
                    }
                    break;
            }
        }

        //prendre le livre
        if(Input.GetKeyDown(KeyCode.E) && hittedObject != null && hittedObject.CompareTag("books") && LearnBooks.CantHistoryBook == false)
        {
            switch (hittedObject.name) 
            {
                case "bookHistoire":
                    if(LearnBooks.HistoryBook == true)
                    {
                        LearnBooks.bookHistory.SetActive(false);
                        iconeE.SetActive(false);
                        PlayerPrefs.SetInt("BookHistoryPickUp", 1);
                        PlayerPrefs.Save();
                        Debug.Log("Livre d'histoire récupérer");
                    }
                    break;
            }
        }
        else
        {
            //Debug.Log("impossible de boucher le livre");
        }

        //déposer le livre
        if(Input.GetKeyDown(KeyCode.R) && hittedObject !=null && hittedObject.CompareTag("extractBook"))
        {
            if (PlayerPrefs.HasKey("BookHistoryPickUp"))
            {
                iconeR.SetActive(false);
                LearnBooks.bookHistory.transform.localPosition = new Vector3(3.34f, 0.84f, 5.14f);
                LearnBooks.bookHistory.transform.rotation = Quaternion.Euler(0, -228.97f, 0);
                LearnBooks.bookHistory.SetActive(true);

                PlayerPrefs.SetString("LivreHistoire_Position", JsonUtility.ToJson(LearnBooks.bookHistory.transform.position));
                PlayerPrefs.SetString("LivreHistoire_Rotation", JsonUtility.ToJson(LearnBooks.bookHistory.transform.rotation));
                PlayerPrefs.Save();
            }
        }

        //déposer une piéce robot
        if(Input.GetKeyDown(KeyCode.R) && hittedObject != null && hittedObject.CompareTag("depotPieceRobot"))
        {
            switch (hittedObject.name)
            {
                case "triggeurJambeL":
                    if (pickUpRobot.jambeLIsPickup == true)
                    {
                        iconeR.SetActive(false);
                        pickUpRobot.jambeL.transform.localPosition = new Vector3(-88.59f, 6.82f, 16.439f);
                        pickUpRobot.jambeL.transform.rotation = Quaternion.Euler(-90f, -180, 90);
                        pickUpRobot.jambeL.SetActive(true);
                        inventory.inventory = 0;

                        PlayerPrefs.SetString("JambeL_Position", JsonUtility.ToJson(pickUpRobot.jambeL.transform.position));
                        PlayerPrefs.SetString("JambeL_Rotation", JsonUtility.ToJson(pickUpRobot.jambeL.transform.rotation));
                        PlayerPrefs.Save();

                        BuildRobot.pieceRobots++;
                        PlayerPrefs.SetInt("JambeLAttach", 1);
                        PlayerPrefs.Save();
                    }
                    break;
                case "triggeurJambeR":
                    if(pickUpRobot.jambeRIsPickup == true)
                    {
                        iconeR.SetActive(false);
                        pickUpRobot.jambeR.transform.localPosition = new Vector3(-88.34f, 6.79f, 19.27f);
                        pickUpRobot.jambeR.transform.rotation = Quaternion.Euler(-90f, 0, 96.14f);
                        pickUpRobot.jambeR.SetActive(true);
                        inventory.inventory = 0;

                        PlayerPrefs.SetString("JambeR_Position", JsonUtility.ToJson(pickUpRobot.jambeR.transform.position));
                        PlayerPrefs.SetString("JambeR_Rotation", JsonUtility.ToJson(pickUpRobot.jambeR.transform.rotation));
                        PlayerPrefs.Save();

                        BuildRobot.pieceRobots++;
                        PlayerPrefs.SetInt("JambeRAttach", 1);
                        PlayerPrefs.Save();
                    }
                    break;
                case "triggeurTete":
                    if(pickUpRobot.teteIsPickup == true)
                    {
                        iconeR.SetActive(false);
                        pickUpRobot.tete.transform.localPosition = new Vector3(-87.78f, 16.01f, 17.88f);
                        pickUpRobot.tete.transform.rotation = Quaternion.Euler(-83.18f, 90, 0);
                        pickUpRobot.tete.SetActive(true);
                        pickUpRobot.teteTriggerEnabled = false;
                        inventory.inventory = 0;

                        PlayerPrefs.SetString("Tete_Position", JsonUtility.ToJson(pickUpRobot.tete.transform.position));
                        PlayerPrefs.SetString("Tete_Rotation", JsonUtility.ToJson(pickUpRobot.tete.transform.rotation));
                        PlayerPrefs.Save();

                        BuildRobot.pieceRobots++;
                        PlayerPrefs.SetInt("TeteAttach", 1);
                        PlayerPrefs.Save();
                    }
                    break;
                case "triggeurBrasR":
                    if(pickUpRobot.brasRIsPickup == true)
                    {
                        iconeR.SetActive(false);
                        pickUpRobot.brasR.transform.localPosition = new Vector3(-89.41f, 15.35f, 19.59f);
                        pickUpRobot.brasR.transform.rotation = Quaternion.Euler(-90f, 0, 90);
                        pickUpRobot.brasR.SetActive(true);
                        inventory.inventory = 0;

                        PlayerPrefs.SetString("BrasR_Position", JsonUtility.ToJson(pickUpRobot.brasR.transform.position));
                        PlayerPrefs.SetString("BrasR_Rotation", JsonUtility.ToJson(pickUpRobot.brasR.transform.rotation));
                        PlayerPrefs.Save();

                        BuildRobot.pieceRobots++;
                        PlayerPrefs.SetInt("BrasRAttach", 1);
                        PlayerPrefs.Save();
                    }
                    break;
            }
        }
    }
}
