using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Contador_Universal : MonoBehaviour
{
    public static float Oro;
    public static float Exp;
    public static int Nivel = 1;
    public GameObject Mostrador_Oro;
    public GameObject Mostrador_Exp;
    public GameObject Mostrador_Nivel;
    public GameObject Ops;
    public GameObject Expps;
    private float M, G, T,L,E,C;


    private void Update()
    {
        M = (Madera.Incremento * Automata.Wood);
        G = (Granja.Incremento * Automata.Wheat);
        T = (Taverna.Incremento * Automata.Beer);

        L = (ExpBooks.Incremento * Automata.Book);
        E = (Entrenador.Incremento * Automata.Trainer);
        C = (Companero.Incremento * Automata.Partner);

        Mostrador_Oro.GetComponent<Text>().text = "Oro: " + Mathf.Round(Oro);
        Mostrador_Exp.GetComponent<Text>().text = "Exp: " + Mathf.Round(Exp);
        Mostrador_Nivel.GetComponent<Text>().text = "Nivel: " + Nivel;

        Ops.GetComponent<Text>().text = "Creando "+(M+G+T)+" Ops";
        Expps.GetComponent<Text>().text = "Creando "+(L+E+C)+" Eps";
    }
}
