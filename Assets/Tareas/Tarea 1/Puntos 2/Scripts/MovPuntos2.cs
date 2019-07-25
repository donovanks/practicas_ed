using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
Autor: Ma. Fernanda Silva Ibarra.
Materia: Estructura de Datos.
Fecha: 13/06/19.
Título: Prácticas.
*/

public class MovPuntos2 : MonoBehaviour
{

    public float velocidad;
    public Transform sierra;

    //Le indica que va a ser un array o conjunto de datos.
    public Transform[] puntos;

    //La que va a indicar el nombre del punto al que tiene que llegar.
    public Transform target;
    public int indiceTarget;


    // Start is called before the first frame update
    void Start()
    {
        // Le indico al espacio de target que tome el valor inicial de puntos.
        target = puntos[1];
        sierra.position = target.position;
        velocidad = velocidad * Time.deltaTime;
        indiceTarget = 0;
        
    }

    // Update is called once per frame
    void Update()
    {
        //Medir la distancia del punto objetivo para cuando llegue a cierta cantidad.
        Vector3 dir = target.position - sierra.position;

        // Almacena lectura vectorial como 2 vectores de entrada A y B.
        float distance = Vector3.Distance(sierra.position, target.position);

        //Cómo se va a trasladar.
        sierra.Translate(dir.normalized * velocidad, Space.World);

        // Ir aumentando cuando cumpla una característica en específico.
        if (distance <= 0.5f)
        {
            // Con Lenght quiero que el sistema lea la extensión total del array.
            if (indiceTarget >= puntos.Length - 1)
            {
                indiceTarget = 0;
                target = puntos[indiceTarget];

            }

            indiceTarget++;
            target = puntos[indiceTarget];
        }

    }
}
