using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destruir : MonoBehaviour
{
    //Solo es para hacer referencia a un tanque enemigo.
    public GameObject[] tanqueEnemigo;
    public GameObject[] almacentanques;
    //Referencia a la particula
    public GameObject explocionTanque;
    // Start is called before the first frame update
    void Start()
    {
        tanqueEnemigo = GameObject.FindGameObjectsWithTag("TanqueEnemigo");
        almacentanques = new GameObject[tanqueEnemigo.Length];

        for (int i = 0; i < tanqueEnemigo.Length; i++)
        {
            almacentanques[i] = tanqueEnemigo[i];
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            for (int i = 0; i < almacentanques.Length; i++)
            {
                //Mandar a traer una copia de la expicion
                //Llamar al objeto.
                Instantiate(explocionTanque, almacentanques[i].transform.position, almacentanques[i].transform.rotation);


                ////Destruccion.
                Destroy(almacentanques[i]);
            }


        }
    }
}
