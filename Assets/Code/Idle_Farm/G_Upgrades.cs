using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class G_Upgrades : MonoBehaviour
{
    public GameObject TextoB,TextoE,TextoC;
    public Button Librox2,Entrenadorx2,Companerox2;
    public float Mejora_Libro=1000f, Mejora_Entrenamiento=10000f, Mejora_Companero=100000f;
    public static bool x2L = false, x2E = false, x2C = false;

   public void MasLibro()
    {
        if (Contador_Universal.Exp >= Mejora_Libro && !x2L)
        {
            Contador_Universal.Exp -= Mejora_Libro;
            Automata.Book = 2;
            x2L = true;
        }
        
    }

   public void MasEntrenamiento()
    {
        if (Contador_Universal.Exp >= Mejora_Entrenamiento && !x2E)
        {
            Contador_Universal.Exp -= Mejora_Entrenamiento;
            Automata.Trainer = 2;
            x2E = true;
        }
    }


    public void MasCompanero()
    {
        if (Contador_Universal.Exp >= Mejora_Companero && !x2C)
        {
            Contador_Universal.Exp -= Mejora_Entrenamiento;
            Automata.Partner = 2;
            x2C = true;
        }

    }

    private void Update()
    {
        TextoB.GetComponent<Text>().text = "Libro x2 =" + Mejora_Libro + " peso";
        TextoE.GetComponent<Text>().text = "Ent. x2 =" + Mejora_Entrenamiento + " peso";
        TextoC.GetComponent<Text>().text = "Comp. x2 =" + Mejora_Companero + " peso";

        if (Contador_Universal.Exp >= Mejora_Libro && !x2L)
        {
            Librox2.interactable = true;
        }
        else
        {
            Librox2.interactable = false;
        }

        if (Contador_Universal.Exp >= Mejora_Entrenamiento && !x2E)
        {
            Entrenadorx2.interactable = true;
        }
        else
        {
            Entrenadorx2.interactable = false;
        }

        if (Contador_Universal.Exp >= Mejora_Companero && !x2C)
        {
            Companerox2.interactable = true;
        }
        else
        {
            Companerox2.interactable = false;
        }
    }



}
