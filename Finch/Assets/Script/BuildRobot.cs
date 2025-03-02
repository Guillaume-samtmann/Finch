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

    //bool RobotIsComplet = false;

    public int pieceRobots = 0;

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

        if (PlayerPrefs.HasKey("TeteAttach"))
        {
            pieceRobots++;
        }
        if (PlayerPrefs.HasKey("BrasRAttach"))
        {
            pieceRobots++;
        }
        if (PlayerPrefs.HasKey("MainRAttach"))
        {
            pieceRobots++;
        }
        if (PlayerPrefs.HasKey("JambeRAttach"))
        {
            pieceRobots++;
        }
        if (PlayerPrefs.HasKey("PiedRAttach"))
        {
            pieceRobots++;
        }
        if (PlayerPrefs.HasKey("BrasGAttach"))
        {
            pieceRobots++;
        }
        if (PlayerPrefs.HasKey("MainGAttach"))
        {
            pieceRobots++;
        }
        if (PlayerPrefs.HasKey("JambeLAttach"))
        {
            pieceRobots++;
        }
        if (PlayerPrefs.HasKey("PiedLAttach"))
        {
            pieceRobots++;
        }
    }

    // Update is called once per frame
    void Update()
    {
        lesPieceRobots();
        //Debug.Log(pieceRobots);
    }

    void lesPieceRobots()
    {
        if (pieceRobots == 9)
        {
            //RobotIsComplet = true;
            PlayerPrefs.SetInt("RobotIsComplet", 1);
            PlayerPrefs.Save();
            //Debug.Log("Robot completer");
        }
        else
        {
            //Debug.Log("Robot non completer");
        }
    }
}
