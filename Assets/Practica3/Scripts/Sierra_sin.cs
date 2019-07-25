using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Nombre del desarrollador:
//Materia: Estructura de datos
//Fecha: 03 de junio de 2019
//Practica numero 3
public class Sierra_sin : MonoBehaviour
{

    //Almacena el punto de partida de la sierra
    private Vector3 originalTransform;

    //Almacena la velocidad de la sierra
    public float velociddad;

    //Almacena la distancia de la sierra
    public float distancia;

    // Start is called before the first frame update
    void Start()
    {
        originalTransform = this.transform.position; 
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = originalTransform + new Vector3(0, Mathf.Sin(Time.time * velociddad) * distancia, 0);
    }
}
