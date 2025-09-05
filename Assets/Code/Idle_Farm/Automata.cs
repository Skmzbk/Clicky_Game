using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Automata : MonoBehaviour
{
    public static float Times=1f;
    public static float Gold;
    public static float Wood = 1f,Wheat=1f,Beer=1f,Book=1f,Trainer=1f,Partner=1f;

    public void Start()
    {
            InvokeRepeating("Automatizar", 1, Times);
    }


    void Automatizar()
    {
        Contador_Universal.Oro += Madera.Incremento*Wood;        
        Contador_Universal.Oro += Granja.Incremento*Wheat;
        Contador_Universal.Oro += Taverna.Incremento*Beer;

        Contador_Universal.Exp += ExpBooks.Incremento*Book;
        Contador_Universal.Exp += Entrenador.Incremento * Trainer;
        Contador_Universal.Exp += Companero.Incremento * Partner;
    }
}
