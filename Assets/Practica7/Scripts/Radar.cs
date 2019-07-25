using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Radar : MonoBehaviour
{
    TurretD torretaRadar;
    
    // Start is called before the first frame update
    void Start()
    {
        torretaRadar = GetComponentInParent<TurretD>();
    }


    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag=="Player")
        {
            torretaRadar.estadoActual = TurretIA.Ataque;

            StartCoroutine(torretaRadar.MisilesAtaque());

            Debug.Log("Te voy a volar prro");
        }
    }
}
