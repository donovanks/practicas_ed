using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour
// codigo para que en el menu al precionar el boton inicio, inicie el juego y el boton salir quite el juego
{
    public void PlayGame()
{
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
}

    public void Quitgame()
    {
        Debug.Log("QUIT!");
        Application.Quit();
    }
}
