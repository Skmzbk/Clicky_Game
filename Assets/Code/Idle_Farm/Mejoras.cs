using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Mejoras : MonoBehaviour
{
    //private float Precio_Mejora=10f;
    //private float mejora = 2f;
    //public GameObject texto,texto_Mejora;
    //public Button Mejor;

    public void Clicky()
    {
        Contador_Universal.Oro += 10000;

        Contador_Universal.Exp += 10000;

        //if (Contador_Universal.Oro>= Precio_Mejora)
        //{
        //    Click_Principal.click *= mejora;
        //    Contador_Universal.Oro -= Precio_Mejora;
        //    Precio_Mejora *= mejora;
        //    texto_Mejora.GetComponent<Text>().text = Precio_Mejora+" Pesos para mejorar";
        //}
        //else
        //{
        //    texto.GetComponent<Text>().text = "No tienes suficiente Oro";
        //    texto.GetComponent<Animation>().Play("Status_Text_Anim");
        //}

    }

    public void Reset()
    {
        Contador_Universal.Oro = 0;

        Contador_Universal.Exp = 0;
    }

    private void Update()
    {
        //if (Contador_Universal.Oro >= Precio_Mejora)
        //{
        //    Mejor.interactable = true;
        //}
        //else
        //{
        //    Mejor.interactable = false;
        //}
        
    }
}
