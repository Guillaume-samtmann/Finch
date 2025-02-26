using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenBook : MonoBehaviour
{
    public GameObject livre;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.I))
        {
            if (livre.gameObject.activeSelf)
            {
                livre.SetActive(false);
            }
            else
            {
                livre.gameObject.SetActive(true);
            }
        }
    }
}
