using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Vida : MonoBehaviour
{
    public float vida;
    public Text vidatext;


    private void Start()
    {
        vidatext.text = vida.ToString();
    }
    private void Update()
    {
        vidatext.text = vida.ToString();
    }
}


