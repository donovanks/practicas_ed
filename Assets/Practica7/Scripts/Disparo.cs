﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparo : MonoBehaviour
{
    public Rigidbody bullet;
    public Transform Cañon;
    public float fuerzaDisparo;
    

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Rigidbody bulletPos = Instantiate(bullet, Cañon.position, Cañon.rotation) as Rigidbody;

            bulletPos.AddForce(Cañon.forward * fuerzaDisparo);
        }
        
    }
}
