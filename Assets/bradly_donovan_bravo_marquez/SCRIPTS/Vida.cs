using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Vida : MonoBehaviour
 // codigo para que la vida sea visible en la pantalla en forma de texto
{
    public float vida;
    public Text vidaText;

    private void Start()
    {
        vidaText.text = vida.ToString();
    }

    private void Update()
    {
        vidaText.text = vida.ToString();
    }
}
