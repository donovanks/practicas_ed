﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
    #region Variables
    //Cada que inicialize un valor flotante el numero debe terminar con letra f
    float velocidad = 3f;
    public float tiempo = 0;

    #endregion
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        tiempo += 0.5f*Time.deltaTime;

        if (tiempo>=1.5f)
        {
            transform.Translate(Vector3.forward * velocidad);
        }

         
    }
}//Fin de la clase Movimiento.
