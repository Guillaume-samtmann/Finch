using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public PickUpRobot pickUpRobot;

    public int inventory = 0;
 

    // Update is called once per frame
    void Update()
    {
        if(inventory == 1)
        {
            pickUpRobot.brasRPickUp = false;
            pickUpRobot.mainRPickUp = false;
            pickUpRobot.iconE.SetActive(false);
        }

    }
}
