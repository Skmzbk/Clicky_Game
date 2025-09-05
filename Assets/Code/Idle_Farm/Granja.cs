using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Granja : MonoBehaviour
{
    public static float Incremento = 0f, Automejora = 100f, tiempo = 0f;
    private float Inicio =1f;
    public GameObject Automatizacion;
    public GameObject Texto,Stats;
    public Button Auto;

    public void Clicky()
    {
        if (tiempo < 1)
        {
            Incremento = Inicio;
        }
        else
        {
            Incremento += Inicio;
        }
        tiempo += 1;
        Contador_Universal.Oro -= Automejora;
        Automejora += (Mathf.Round(Automejora * .14f));
    }

    private void Update()
    {
        Texto.GetComponent<Text>().text = "Auto " + Automejora + " peso";

        if (tiempo >= 1 && !XP_Upgrades.x2G)
        {
            Stats.GetComponent<Text>().text = "Tienes " + tiempo + " granjeros haciendo " + Incremento + " O.p.s.";
        }
        if (tiempo >= 1 && XP_Upgrades.x2G)
        {
            Stats.GetComponent<Text>().text = "Tienes " + tiempo + " granjeros haciendo " + (Incremento * 2) + " O.p.s.";
        }

        if (Contador_Universal.Oro >= Automejora)
        {
            Auto.interactable = true;
        }
        else
        {
            Auto.interactable = false;
        }
    }
}
