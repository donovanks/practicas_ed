﻿ using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movx : MonoBehaviour
{
    float velocidad = 0.3f;
    int tope = 4;
    bool direccion, direccion2;

    // Start is called before the first frame update
    void Start()
    {
        direccion = true;
        direccion2 = true;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (direccion == true)
        {
            if (transform.position.x < tope)
            {
                transform.Translate(Vector3.right * velocidad);
            }

            if (transform.position.x >= tope)
            {
                direccion = false;
            }
        }

        if (direccion == false)
        {
            if (transform.position.y < 6)
            {
                transform.Translate(Vector3.up * velocidad);
            }

            if (transform.position.y >= 6)
            {
                direccion2 = true;
            }
        }

        if (direccion2 == true)
        {
            if (transform.position.x > 0)
            {
                transform.Translate(Vector3.left * velocidad);

            }

            if (transform.position.x <= 0)
            {
                direccion2 = false;
            }
        }
    }
}
