using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Transitioner : MonoBehaviour
{
   void OnTriggerEnter(Collider col)
    {
        Debug.Log(col.tag);

        if(col.tag == "ball")
        {
            SceneManager.LoadScene("Exit");
        }
    }
}
