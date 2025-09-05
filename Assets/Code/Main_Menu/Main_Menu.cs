using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Main_Menu : MonoBehaviour
{
    public static bool EstaCargando = false;
   
    public void NuevoJuego()
    {
        //insertar numero de la escena
        SceneManager.LoadScene(2);
    }

    public void CargarPartida()
    {
        EstaCargando = true;
        SceneManager.LoadScene(2);
    }

}
