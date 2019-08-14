using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class ChangeScene2 : MonoBehaviour
{

    void OnTriggerEnter2D(Collider2D other)
    {
        //Codigo utilizado para cambiar de una escena a otra. 
        if (other.gameObject.tag == "Player")
        {
            SceneManager.LoadScene("level3");
        }
    }
}

