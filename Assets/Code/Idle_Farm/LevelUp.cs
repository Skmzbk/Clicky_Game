using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelUp : MonoBehaviour
{
    public GameObject status, Textoboton;
    public Button lu;
    public static float Subirdenivel=1000f;

    public void Clicky()
    {
        if (Contador_Universal.Exp >= Subirdenivel)
        {
            Contador_Universal.Nivel += 1;
            Contador_Universal.Exp -= Subirdenivel;
            Subirdenivel += (Mathf.Round(Subirdenivel /2f));
        }
        else
        {
            status.GetComponent<Text>().text = "No tienes suficiente Experiencia";
            status.GetComponent<Animation>().Play("Status_Text_Anim");
        }
    }

    private void Update()
    {
        Textoboton.GetComponent<Text>().text = Subirdenivel + " Exp. para mejorar";

        if (Contador_Universal.Exp >= Subirdenivel)
        {
            lu.interactable = true;
        }
        else
        {
            lu.interactable = false;
        }
    }
}
