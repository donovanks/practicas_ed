using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class DañoPlayer : MonoBehaviour
{
    Vida vidajugador;

    void Start()
    {
        vidajugador = GameObject.Find("Player").GetComponent<Vida>();
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {


        if (collision.gameObject.tag == "Player")
        {
            vidajugador.vida -= 10;
        }

        if(vidajugador.vida == 0)
        {
            SceneManager.LoadScene( "level1");
        }

    }

}
