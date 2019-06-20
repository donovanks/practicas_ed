using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dañoplayer : MonoBehaviour
{
    Vida vidajugador;
    void Start()
    {
        vidajugador = gameObject.find("player").GetComponent<Vida>();
        }
    private void OnCollisionEnter(Collision collision)
    {
        
     

        if (collision.gameObject.tag=="player")
        {
            vidajugador.vida -= 3;
        }  
    }

    
}
