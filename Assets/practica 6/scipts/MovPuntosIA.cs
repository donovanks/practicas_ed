using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum enemigoIA
{
    Patrulla,
    Perseguir,
    Atacar
}


public class MovPuntosIA : MonoBehaviour
{
    public float velocidad;
    public Transform sierra;
    public Transform[] puntos;
    public Transform target;
    public int indiceTarget;
    public Transform player;
    public enemigoIA  estadoActual = new enemigoIA ();
    // Start is called before the first frame update
    void Start()
    {
        estadoActual = enemigoIA.Patrulla;
        target = puntos[1];
        sierra.position = target.position;
        velocidad = velocidad * Time.deltaTime;
        indiceTarget = 0;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 dir = target.position - sierra.position;

        float distance = Vector3.Distance(sierra.position, target.position);
        float distanceplayer = Vector3.Distance(sierra.position, player.position);
        sierra.Translate(dir.normalized * velocidad, Space.World);

        if(estadoActual == enemigoIA.Patrulla)
        {
            target = puntos[indiceTarget];
            if (distance <= 0.5f)
            {
                if (indiceTarget >= puntos.Length - 1)
                {
                    indiceTarget = 0;
                    target = puntos[indiceTarget];
                }

                indiceTarget++;
                target = puntos[indiceTarget];
            }
        }

        if (distanceplayer <= 2)
        {
            estadoActual = enemigoIA.Perseguir;
        }
        else if (distanceplayer > 5)

        {
            estadoActual = enemigoIA.Patrulla;
        }
        if (estadoActual == enemigoIA.Perseguir)
        {
            target = player;
        }
    }

}
