using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum EnemigoIA
{
    Patrulla,
    Perseguir,
    Atacar
}


public class MovPuntos : MonoBehaviour
{
    public float velocidad;
    public Transform sierra;
    public Transform[] puntos;
    public Transform target;
    public int indiceTaregt;
    public Transform player;
    public EnemigoIA estadoActual = new EnemigoIA();


    // Start is called before the first frame update
    void Start()
    {
        estadoActual = EnemigoIA.Patrulla;
        target = puntos[1];
        sierra.position = target.position;
        velocidad = velocidad * Time.deltaTime;
        indiceTaregt = 0;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 dir = target.position - sierra.position;

        float distance = Vector2.Distance(sierra.position, target.position);
        float distancePlayer = Vector2.Distance(sierra.position, player.position);

        sierra.Translate(dir.normalized * velocidad, Space.World);

        if (estadoActual == EnemigoIA.Patrulla)
        {
            target = puntos[indiceTaregt];

            if (distance <= 0.5f)
            {

                if (indiceTaregt >= puntos.Length - 1)
                {
                    indiceTaregt = 0;
                    target = puntos[indiceTaregt];
                }

                indiceTaregt++;
                target = puntos[indiceTaregt];
            }
        }

        if (distancePlayer <= 2)
        {
            estadoActual = EnemigoIA.Perseguir;
        }
        else if (distance > 5)
        {
            estadoActual = EnemigoIA.Patrulla;
        }

        if (estadoActual == EnemigoIA.Perseguir)
        {
            target = player;
        }
    }
}
