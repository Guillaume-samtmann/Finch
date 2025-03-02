using Cinemachine.Utility;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

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
    public GameObject buste;
    public GameObject extractBook;
    public GameObject nameObj;
    public Text infoNameObj;
    //
    public bool teteIsShow = true;
    public bool brasRisShow = true;
    public bool mainRisShow = true;
    public bool jambeRisShow = true;
    public bool piedRisShow = true;
    public bool brasGisShow = true;
    public bool mainGisShow = true;
    public bool jambeGisShow = true;
    public bool piedGisShow = true;

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
                if (hittedObject.name == "tete")
                {
                    if (PlayerPrefs.HasKey("isAttachToRobotsTete"))
                    {
                        HighlightObject(hittedObject, false);
                        iconeE.SetActive(false);
                        nameObj.SetActive(false);
                    }
                    else
                    {
                        HighlightObject(hittedObject, true);
                        iconeE.SetActive(true);
                        nameObj.SetActive(true);
                        infoNameObj.text = "Pièce : Tête";
                    }
                }
                if (hittedObject.name == "bras.R") pickUpRobot.brasRPickUp = true;
                if(hittedObject.name == "bras.R")
                {
                    if(PlayerPrefs.HasKey("isAttachToRobotsBrasR"))
                    {
                        HighlightObject(hittedObject, false);
                        iconeE.SetActive(false);
                        nameObj.SetActive(false);
                    } else
                    {
                        HighlightObject(hittedObject, true);
                        iconeE.SetActive(true);
                        nameObj.SetActive(true);
                        infoNameObj.text = "Pièce : Bras Droit";
                    }
                }
                if (hittedObject.name == "main.R") pickUpRobot.mainRPickUp = true;
                if (hittedObject.name == "main.R")
                {
                    if (PlayerPrefs.HasKey("isAttachToRobotsMainR"))
                    {
                        HighlightObject(hittedObject, false);
                        iconeE.SetActive(false);
                        nameObj.SetActive(false);
                    }
                    else
                    {
                        HighlightObject(hittedObject, true);
                        iconeE.SetActive(true);
                        nameObj.SetActive(true);
                        infoNameObj.text = "Pièce : Main Droit";
                    }
                }
                if (hittedObject.name == "jambe.R") pickUpRobot.jambeRPickUp = true;
                if (hittedObject.name == "jambe.R")
                {
                    if (PlayerPrefs.HasKey("isAttachToRobotsJambeR"))
                    {
                        HighlightObject(hittedObject, false);
                        iconeE.SetActive(false);
                        nameObj.SetActive(false);
                    }
                    else
                    {
                        HighlightObject(hittedObject, true);
                        iconeE.SetActive(true);
                        nameObj.SetActive(true);
                        infoNameObj.text = "Pièce : Jambe Droit";
                    }
                }
                if (hittedObject.name == "pieds.R") pickUpRobot.piedRPickUp = true;
                if (hittedObject.name == "pieds.R")
                {
                    if (PlayerPrefs.HasKey("isAttachToRobotsPiedR"))
                    {
                        HighlightObject(hittedObject, false);
                        iconeE.SetActive(false);
                        nameObj.SetActive(false);
                    }
                    else
                    {
                        HighlightObject(hittedObject, true);
                        iconeE.SetActive(true);
                        nameObj.SetActive(true);
                        infoNameObj.text = "Pièce : Pied Droit";
                    }
                }
                if (hittedObject.name == "bras.G") pickUpRobot.brasGPickUp = true;
                if (hittedObject.name == "bras.G")
                {
                    if (PlayerPrefs.HasKey("isAttachToRobotsBrasG"))
                    {
                        HighlightObject(hittedObject, false);
                        iconeE.SetActive(false);
                        nameObj.SetActive(false);
                    }
                    else
                    {
                        HighlightObject(hittedObject, true);
                        iconeE.SetActive(true);
                        nameObj.SetActive(true);
                        infoNameObj.text = "Pièce : Bras Gauche";
                    }
                }
                if (hittedObject.name == "main.G") pickUpRobot.mainGPickUp = true;
                if (hittedObject.name == "main.G")
                {
                    if (PlayerPrefs.HasKey("isAttachToRobotsMainG"))
                    {
                        HighlightObject(hittedObject, false);
                        iconeE.SetActive(false);
                        nameObj.SetActive(false);
                    }
                    else
                    {
                        HighlightObject(hittedObject, true);
                        iconeE.SetActive(true);
                        nameObj.SetActive(true);
                        infoNameObj.text = "Pièce : Main Gauche";
                    }
                }
                if (hittedObject.name == "jambe.L") pickUpRobot.jambeLPickUp = true;
                if (hittedObject.name == "jambe.L")
                {
                    if (PlayerPrefs.HasKey("isAttachToRobotsJambeL"))
                    {
                        HighlightObject(hittedObject, false);
                        iconeE.SetActive(false);
                        nameObj.SetActive(false);
                    }
                    else
                    {
                        HighlightObject(hittedObject, true);
                        iconeE.SetActive(true);
                        nameObj.SetActive(true);
                        infoNameObj.text = "Pièce : Jambe Gauche";
                    }
                }
                if (hittedObject.name == "pieds.L") pickUpRobot.piedLPickUp = true;
                if (hittedObject.name == "pieds.L")
                {
                    if (PlayerPrefs.HasKey("isAttachToRobotsPiedL"))
                    {
                        HighlightObject(hittedObject, false);
                        iconeE.SetActive(false);
                        nameObj.SetActive(false);
                    }
                    else
                    {
                        HighlightObject(hittedObject, true);
                        iconeE.SetActive(true);
                        nameObj.SetActive(true);
                        infoNameObj.text = "Pièce : Pied Gauche";
                    }
                }
            }
            if (hittedObject.CompareTag("books") && PlayerPrefs.HasKey("RobotIsComplet") && (LearnBooks.CantHistoryBook == false || LearnBooks.CantSciencesBook == false || LearnBooks.CantChienBook == false))
            {
                HighlightObject(hittedObject, true);
                iconeE.SetActive(true);

                if ( hittedObject.name == "bookHistoire")
                {
                    LearnBooks.HistoryBook = true;
                    nameObj.SetActive(true);
                    infoNameObj.text = "livre histoire";
                }
                else
                {
                    nameObj.SetActive(false);
                    LearnBooks.HistoryBook = false;
                }

                //science
                if (hittedObject.name == "bookSciences")
                {
                    LearnBooks.SciencesBook = true;
                    nameObj.SetActive(true);
                    infoNameObj.text = "livre sciences";
                }
                else
                {
                    LearnBooks.SciencesBook = false;
                    nameObj.SetActive(false);
                }
        
                //chien
                if (hittedObject.name == "bookChien")
                {
                    LearnBooks.ChienBook = true;
                    nameObj.SetActive(true);
                    infoNameObj.text = "livre chien";
                }
                else
                {
                    LearnBooks.ChienBook = false;
                    nameObj.SetActive(false);
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
                //Debug.Log("tu peux déposer le livre");
            }
            else
            {

            }
            
            //Condition pour afficher le R
            if (teteIsShow == false || brasRisShow ==false || mainRisShow ==false || jambeRisShow == false || piedRisShow == false || brasGisShow == false || mainGisShow == false || jambeGisShow == false || piedGisShow == false)
            {
                if (hittedObject.CompareTag("depotPieceRobot"))
                {
                    HighlightObject(hittedObject, true);
                    iconeR.SetActive(true);
                }
            }
        }
        else
        {
            // Aucun objet touché
            nameObj.SetActive(false);
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
                        if (PlayerPrefs.HasKey("isAttachToRobotsTete"))
                        {
                            pickUpRobot.tete.SetActive(true);
                        }
                        else
                        {
                            teteIsShow = false;
                            pickUpRobot.tete.SetActive(false);
                            iconeE.SetActive(false);
                            pickUpRobot.tetePickUp = false;
                            pickUpRobot.teteIsPickup = true;
                            inventory.inventory = 1;
                        }
                    }
                    break;
                case "bras.R":
                    if (PlayerPrefs.GetInt("BrasRIsConfig", 0) == 1 && pickUpRobot.brasRPickUp)
                    {
                        if (PlayerPrefs.HasKey("isAttachToRobotsBrasR")){
                            pickUpRobot.brasR.SetActive(true);
                        }
                        else
                        {
                            brasRisShow = false;
                            pickUpRobot.brasR.SetActive(false);
                            iconeE.SetActive(false);
                            pickUpRobot.brasRPickUp = false;
                            pickUpRobot.brasRIsPickup = true;
                            inventory.inventory = 1;
                            pickUpRobot.brasAttach = true;
                        }
                    }
                    break;
                case "main.R":
                    if (PlayerPrefs.GetInt("MainRIsConfig", 0) == 1 && pickUpRobot.mainRPickUp)
                    {
                        if (PlayerPrefs.HasKey("isAttachToRobotsMainR"))
                        {
                            pickUpRobot.mainR.SetActive(true);
                        }
                        else
                        {
                            mainRisShow = false;
                            pickUpRobot.mainR.SetActive(false);
                            iconeE.SetActive(false);
                            pickUpRobot.mainRPickUp = false;
                            pickUpRobot.mainRIsPickup = true;
                            inventory.inventory = 1;
                        }
                    }
                    break;
                case "jambe.R":
                    if (PlayerPrefs.GetInt("JambeRIsConfig", 0) == 1 && pickUpRobot.jambeRPickUp && pickUpRobot.jambeRAttach == false)
                    {
                        if (PlayerPrefs.HasKey("isAttachToRobotsJambeR"))
                        {
                            pickUpRobot.jambeR.SetActive(true);
                        }
                        else
                        {
                            jambeRisShow = false;
                            pickUpRobot.jambeR.SetActive(false);
                            iconeE.SetActive(false);
                            pickUpRobot.jambeRPickUp = false;
                            pickUpRobot.jambeRIsPickup = true;
                            inventory.inventory = 1;
                            pickUpRobot.jambeRAttach = true;
                        }  
                    }
                    break;
                case "pieds.R":
                    if (PlayerPrefs.GetInt("PiedsRIsConfig", 0) == 1 && pickUpRobot.piedRPickUp)
                    {
                        if (PlayerPrefs.HasKey("isAttachToRobotsPiedR"))
                        {
                            pickUpRobot.piedR.SetActive(true);
                        }
                        else
                        {
                            piedRisShow = false;
                            pickUpRobot.piedR.SetActive(false);
                            iconeE.SetActive(false);
                            pickUpRobot.piedRPickUp = false;
                            pickUpRobot.piedRIsPickup = true;
                            inventory.inventory = 1;
                        }
                    }
                    break;
                case "bras.G":
                    if (PlayerPrefs.GetInt("BrasGIsConfig", 0) == 1 && pickUpRobot.brasGPickUp)
                    {
                        if (PlayerPrefs.HasKey("isAttachToRobotsBrasG"))
                        {
                            pickUpRobot.brasG.SetActive(true);
                        }
                        else
                        {
                            brasGisShow = false;
                            pickUpRobot.brasG.SetActive(false);
                            iconeE.SetActive(false);
                            pickUpRobot.brasGPickUp = false;
                            pickUpRobot.brasGIsPickup = true;
                            inventory.inventory = 1;
                            pickUpRobot.brasGAttach = true;
                        }
                    }
                    break;
                case "main.G":
                    if (PlayerPrefs.GetInt("MainGIsConfig", 0) == 1 && pickUpRobot.mainGPickUp)
                    {
                        if (PlayerPrefs.HasKey("isAttachToRobotsMainG"))
                        {
                            pickUpRobot.mainG.SetActive(true);
                        }
                        else
                        {
                            mainGisShow = false;
                            pickUpRobot.mainG.SetActive(false);
                            iconeE.SetActive(false);
                            pickUpRobot.mainGPickUp = false;
                            pickUpRobot.mainGIsPickup = true;
                            inventory.inventory = 1;
                        }
                    }
                    break;
                case "jambe.L":
                    if (PlayerPrefs.GetInt("JambeGIsConfig", 0) == 1 && pickUpRobot.jambeLPickUp && pickUpRobot.jambeLAttach == false)
                    {
                        if (PlayerPrefs.HasKey("isAttachToRobotsJambeL"))
                        {
                            pickUpRobot.jambeL.SetActive(true);
                        }
                        else
                        {
                            jambeGisShow = false;
                            pickUpRobot.jambeL.SetActive(false);
                            iconeE.SetActive(false);
                            pickUpRobot.jambeLPickUp = false;
                            pickUpRobot.jambeLIsPickup = true;
                            inventory.inventory = 1;
                            pickUpRobot.jambeLAttach = true;
                        }
                    }
                    break;
                case "pieds.L":
                    if (PlayerPrefs.GetInt("PiedGIsConfig", 0) == 1 && pickUpRobot.piedLPickUp)
                    {
                        if (PlayerPrefs.HasKey("isAttachToRobotsPiedG"))
                        {
                            pickUpRobot.piedL.SetActive(true);
                        }
                        else
                        {
                            piedGisShow = false;
                            pickUpRobot.piedL.SetActive(false);
                            iconeE.SetActive(false);
                            pickUpRobot.piedLPickUp = false;
                            pickUpRobot.piedLIsPickup = true;
                            inventory.inventory = 1;
                        }
                    }
                    break;
            }
        }

        //prendre le livre
        if(Input.GetKeyDown(KeyCode.E) && hittedObject != null && hittedObject.CompareTag("books") && (LearnBooks.CantHistoryBook == false || LearnBooks.CantSciencesBook == false || LearnBooks.CantChienBook == false))
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
                    }
                    break;
                case "bookSciences":
                    if (LearnBooks.SciencesBook == true)
                    {
                        LearnBooks.bookSciences.SetActive(false);
                        iconeE.SetActive(false);
                        PlayerPrefs.SetInt("BookSciencesPickUp", 1);
                        PlayerPrefs.Save();
                    }
                    break;
                case "bookChien":
                    if (LearnBooks.ChienBook == true)
                    {
                        LearnBooks.bookChien.SetActive(false);
                        iconeE.SetActive(false);
                        PlayerPrefs.SetInt("BookChienPickUp", 1);
                        PlayerPrefs.Save();
                    }
                    break;
            }
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
                PlayerPrefs.DeleteKey("BookHistoryPickUp");
            }

            if (PlayerPrefs.HasKey("BookSciencesPickUp"))
            {
                iconeR.SetActive(false);
                LearnBooks.bookSciences.transform.localPosition = new Vector3(3.34f, 0.84f, 5.14f);
                LearnBooks.bookSciences.transform.rotation = Quaternion.Euler(0, -228.97f, 0);
                LearnBooks.bookSciences.SetActive(true);

                PlayerPrefs.SetString("LivreSciences_Position", JsonUtility.ToJson(LearnBooks.bookSciences.transform.position));
                PlayerPrefs.SetString("LivreSciences_Rotation", JsonUtility.ToJson(LearnBooks.bookSciences.transform.rotation));
                PlayerPrefs.Save();
                PlayerPrefs.DeleteKey("BookSciencesPickUp");
            }

            if (PlayerPrefs.HasKey("BookChienPickUp"))
            {
                iconeR.SetActive(false);
                LearnBooks.bookChien.transform.localPosition = new Vector3(3.34f, 0.84f, 5.14f);
                LearnBooks.bookChien.transform.rotation = Quaternion.Euler(0, -228.97f, 0);
                LearnBooks.bookChien.SetActive(true);

                PlayerPrefs.SetString("LivreChien_Position", JsonUtility.ToJson(LearnBooks.bookChien.transform.position));
                PlayerPrefs.SetString("LivreChien_Rotation", JsonUtility.ToJson(LearnBooks.bookChien.transform.rotation));
                PlayerPrefs.Save();
                PlayerPrefs.DeleteKey("BookChienPickUp");
            }
        }

        //déposer une piéce robot
        if (Input.GetKeyDown(KeyCode.R) && hittedObject != null && hittedObject.CompareTag("depotPieceRobot"))
        {
            switch (hittedObject.name)
            {
                case "buste":
                    //Jambe Gauche
                    if (pickUpRobot.jambeLIsPickup == true)
                    {
                        iconeR.SetActive(false);
                        pickUpRobot.jambeL.transform.localPosition = new Vector3(-88.59f, 6.82f, 16.439f);
                        pickUpRobot.jambeL.transform.rotation = Quaternion.Euler(-90f, -180, 90);
                        pickUpRobot.jambeL.SetActive(true);
                        inventory.inventory = 0;

                        PlayerPrefs.SetInt("isAttachToRobotsJambeL", 1);
                        PlayerPrefs.Save();

                        PlayerPrefs.SetString("JambeL_Position", JsonUtility.ToJson(pickUpRobot.jambeL.transform.position));
                        PlayerPrefs.SetString("JambeL_Rotation", JsonUtility.ToJson(pickUpRobot.jambeL.transform.rotation));
                        PlayerPrefs.Save();

                        BuildRobot.pieceRobots++;
                        PlayerPrefs.SetInt("JambeLAttach", 1);
                        PlayerPrefs.Save();
                    }
                    //Jambe Droite
                    if (pickUpRobot.jambeRIsPickup == true)
                    {
                        iconeR.SetActive(false);
                        pickUpRobot.jambeR.transform.localPosition = new Vector3(-88.34f, 6.79f, 19.27f);
                        pickUpRobot.jambeR.transform.rotation = Quaternion.Euler(-90f, 0, 96.14f);
                        pickUpRobot.jambeR.SetActive(true);
                        inventory.inventory = 0;
                        jambeRisShow = true;

                        PlayerPrefs.SetInt("isAttachToRobotsJambeR", 1);
                        PlayerPrefs.Save();

                        PlayerPrefs.SetString("JambeR_Position", JsonUtility.ToJson(pickUpRobot.jambeR.transform.position));
                        PlayerPrefs.SetString("JambeR_Rotation", JsonUtility.ToJson(pickUpRobot.jambeR.transform.rotation));
                        PlayerPrefs.Save();

                        BuildRobot.pieceRobots++;
                        PlayerPrefs.SetInt("JambeRAttach", 1);
                        PlayerPrefs.Save();
                    }
                    //tete
                    if (pickUpRobot.teteIsPickup == true)
                    {
                        iconeR.SetActive(false);
                        pickUpRobot.tete.transform.localPosition = new Vector3(-87.78f, 16.01f, 17.88f);
                        pickUpRobot.tete.transform.rotation = Quaternion.Euler(-83.18f, 90, 0);
                        pickUpRobot.tete.SetActive(true);
                        pickUpRobot.teteTriggerEnabled = false;
                        inventory.inventory = 0;
                        teteIsShow = true;

                        PlayerPrefs.SetInt("isAttachToRobotsTete", 1);
                        PlayerPrefs.Save();

                        PlayerPrefs.SetString("Tete_Position", JsonUtility.ToJson(pickUpRobot.tete.transform.position));
                        PlayerPrefs.SetString("Tete_Rotation", JsonUtility.ToJson(pickUpRobot.tete.transform.rotation));
                        PlayerPrefs.Save();

                        BuildRobot.pieceRobots++;
                        PlayerPrefs.SetInt("TeteAttach", 1);
                        PlayerPrefs.Save();
                    }
                    //brasR
                    if (pickUpRobot.brasRIsPickup == true)
                    {
                        iconeR.SetActive(false);
                        pickUpRobot.brasR.transform.localPosition = new Vector3(-89.41f, 15.35f, 19.59f);
                        pickUpRobot.brasR.transform.rotation = Quaternion.Euler(-90f, 0, 90);
                        pickUpRobot.brasR.SetActive(true);
                        inventory.inventory = 0;
                        brasRisShow = true;

                        PlayerPrefs.SetInt("isAttachToRobotsBrasR", 1);
                        PlayerPrefs.Save();

                        PlayerPrefs.SetString("BrasR_Position", JsonUtility.ToJson(pickUpRobot.brasR.transform.position));
                        PlayerPrefs.SetString("BrasR_Rotation", JsonUtility.ToJson(pickUpRobot.brasR.transform.rotation));
                        PlayerPrefs.Save();

                        BuildRobot.pieceRobots++;
                        PlayerPrefs.SetInt("BrasRAttach", 1);
                        PlayerPrefs.Save();
                    }
                    //brasG
                    if (pickUpRobot.brasGIsPickup == true)
                    {
                        iconeR.SetActive(false);
                        pickUpRobot.brasG.transform.localPosition = new Vector3(-89.55f, 15.32f, 16.05f);
                        pickUpRobot.brasG.transform.rotation = Quaternion.Euler(-90f, 0, 270f);
                        pickUpRobot.brasG.SetActive(true);
                        pickUpRobot.brasGtriggerEnabled = false;
                        inventory.inventory = 0;
                        brasGisShow = true;

                        PlayerPrefs.SetInt("isAttachToRobotsBrasG", 1);
                        PlayerPrefs.Save();

                        PlayerPrefs.SetString("BrasG_Position", JsonUtility.ToJson(pickUpRobot.brasG.transform.position));
                        PlayerPrefs.SetString("BrasG_Rotation", JsonUtility.ToJson(pickUpRobot.brasG.transform.rotation));
                        PlayerPrefs.Save();

                        BuildRobot.pieceRobots++;
                        PlayerPrefs.SetInt("BrasGAttach", 1);
                        PlayerPrefs.Save();
                    }
                    //mainG
                    if (pickUpRobot.mainGIsPickup == true)
                    {
                        iconeR.SetActive(false);
                        pickUpRobot.mainG.transform.localPosition = new Vector3(-88.96f, 7.56f, 14.25f);
                        pickUpRobot.mainG.transform.rotation = Quaternion.Euler(-60.60f, 260.96f, 12.71f);
                        pickUpRobot.mainG.SetActive(true);
                        inventory.inventory = 0;
                        mainGisShow = true;

                        PlayerPrefs.SetInt("isAttachToRobotsMainG", 1);
                        PlayerPrefs.Save();

                        PlayerPrefs.SetString("MainG_Position", JsonUtility.ToJson(pickUpRobot.mainG.transform.position));
                        PlayerPrefs.SetString("MainG_Rotation", JsonUtility.ToJson(pickUpRobot.mainG.transform.rotation));
                        PlayerPrefs.Save();

                        BuildRobot.pieceRobots++;
                        PlayerPrefs.SetInt("MainGAttach", 1);
                        PlayerPrefs.Save();
                    }
                    //piedG
                    if (pickUpRobot.piedLIsPickup == true)
                    {
                        iconeR.SetActive(false);
                        pickUpRobot.piedL.transform.localPosition = new Vector3(-88.09f, 2.61f, 16.373f);
                        pickUpRobot.piedL.transform.rotation = Quaternion.Euler(-79.85f, 89.88f, 0.11f);
                        pickUpRobot.piedL.SetActive(true);
                        inventory.inventory = 0;
                        piedGisShow = true;

                        PlayerPrefs.SetInt("isAttachToRobotsPiedG", 1);
                        PlayerPrefs.Save();

                        PlayerPrefs.SetString("PiedL_Position", JsonUtility.ToJson(pickUpRobot.piedL.transform.localPosition));
                        PlayerPrefs.SetString("PiedL_Rotation", JsonUtility.ToJson(pickUpRobot.piedL.transform.rotation));
                        PlayerPrefs.Save();

                        BuildRobot.pieceRobots++;
                        PlayerPrefs.SetInt("PiedLAttach", 1);
                        PlayerPrefs.Save();
                    }
                    //mainR
                    if (pickUpRobot.mainRIsPickup == true)
                    {
                        iconeR.SetActive(false);
                        pickUpRobot.mainR.transform.localPosition = new Vector3(-88.01f, 7.81f, 21.74f);
                        pickUpRobot.mainR.transform.rotation = Quaternion.Euler(-90.42f, 90, 0);
                        pickUpRobot.mainR.SetActive(true);
                        inventory.inventory = 0;
                        mainRisShow = true;

                        PlayerPrefs.SetInt("isAttachToRobotsMainR", 1);
                        PlayerPrefs.Save();

                        PlayerPrefs.SetString("MainR_Position", JsonUtility.ToJson(pickUpRobot.mainR.transform.position));
                        PlayerPrefs.SetString("MainR_Rotation", JsonUtility.ToJson(pickUpRobot.mainR.transform.rotation));
                        PlayerPrefs.Save();

                        BuildRobot.pieceRobots++;
                        PlayerPrefs.SetInt("MainRAttach", 1);
                        PlayerPrefs.Save();
                    }
                    //piedR
                    if(pickUpRobot.piedRIsPickup==true)
                    {
                        iconeR.SetActive(false);
                        pickUpRobot.piedR.transform.localPosition = new Vector3(-88.06f, 2.42f, 19.22f);
                        pickUpRobot.piedR.transform.rotation = Quaternion.Euler(-85.53f, 90.01f, 4.30f);
                        pickUpRobot.piedR.SetActive(true);
                        inventory.inventory = 0;
                        piedRisShow = true;

                        PlayerPrefs.SetInt("isAttachToRobotsPiedR", 1);
                        PlayerPrefs.Save();

                        PlayerPrefs.SetString("PiedR_Position", JsonUtility.ToJson(pickUpRobot.piedR.transform.position));
                        PlayerPrefs.SetString("PiedR_Rotation", JsonUtility.ToJson(pickUpRobot.piedR.transform.rotation));
                        PlayerPrefs.Save();

                        BuildRobot.pieceRobots++;
                        PlayerPrefs.SetInt("PiedRAttach", 1);
                        PlayerPrefs.Save();
                    }
                    break;
            }
        }
    }
}
