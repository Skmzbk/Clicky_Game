using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu_Admin : MonoBehaviour
{
    public GameObject Compras;
    public GameObject Compras_Ventana;
    public GameObject Perks;
    public GameObject Perks_Ventana;
    public GameObject Main_Ventana;

    public void Acompras()
    {
        Compras_Ventana.SetActive(true);
        Main_Ventana.SetActive(false);
    }

    public void Aperks()
    {
        Perks_Ventana.SetActive(true);
        Main_Ventana.SetActive(false);
    }

    public void Cerrar()
    {
        Main_Ventana.SetActive(true);
        Compras_Ventana.SetActive(false);
        Perks_Ventana.SetActive(false);
    }

}
