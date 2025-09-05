using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadData : MonoBehaviour
{

    void Start()
    {
        if (Main_Menu.EstaCargando)
        {
            Contador_Universal.Nivel = PlayerPrefs.GetInt("Nivel");
            Contador_Universal.Oro = PlayerPrefs.GetFloat("Oro");
            Contador_Universal.Exp = PlayerPrefs.GetFloat("Exp");
            LevelUp.Subirdenivel = PlayerPrefs.GetFloat("ExpSubirnivel");

            Madera.Incremento = PlayerPrefs.GetFloat("Madera_I");
            Madera.Automejora = PlayerPrefs.GetFloat("Madera_AM");
            Madera.tiempo = PlayerPrefs.GetFloat("Madera_T");

            Granja.Incremento = PlayerPrefs.GetFloat("Granja_I");
            Granja.Automejora = PlayerPrefs.GetFloat("Granja_AM");
            Granja.tiempo = PlayerPrefs.GetFloat("Granja_T");

            Taverna.Incremento = PlayerPrefs.GetFloat("Taverna_I");
            Taverna.Automejora = PlayerPrefs.GetFloat("Taverna_AM");
            Taverna.tiempo = PlayerPrefs.GetFloat("Taverna_T");

            ExpBooks.Incremento = PlayerPrefs.GetFloat("Libros_I");
            ExpBooks.Automejora = PlayerPrefs.GetFloat("Libros_AM");
            ExpBooks.tiempo = PlayerPrefs.GetFloat("Libros_T");

            Entrenador.Incremento = PlayerPrefs.GetFloat("Entrenador_I");
            Entrenador.Automejora = PlayerPrefs.GetFloat("Entrenador_AM");
            Entrenador.tiempo = PlayerPrefs.GetFloat("Entrenador_T");

            Companero.Incremento = PlayerPrefs.GetFloat("Companero_I");
            Companero.Automejora = PlayerPrefs.GetFloat("Companero_AM");
            Companero.tiempo = PlayerPrefs.GetFloat("Companero_T");
        }
    }

}
