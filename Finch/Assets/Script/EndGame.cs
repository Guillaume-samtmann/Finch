using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGame : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(returnBegin());
    }

    IEnumerator returnBegin()
    {
        yield return new WaitForSeconds(27);
        SceneManager.LoadScene(0);
    }
}
