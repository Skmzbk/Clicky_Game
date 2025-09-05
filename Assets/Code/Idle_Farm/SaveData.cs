using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveData : MonoBehaviour
{
    public void Start()
    {
        InvokeRepeating("GuardarPartida", 60,60);
    }

    void GuardarPartida()
    {
        PlayerPrefs.SetInt("Nivel",Contador_Universal.Nivel);
        PlayerPrefs.SetFloat("Oro", Contador_Universal.Oro);
        PlayerPrefs.SetFloat("Exp", Contador_Universal.Exp);
        PlayerPrefs.SetFloat("ExpSubirnivel", LevelUp.Subirdenivel);

        PlayerPrefs.SetFloat("Madera_I",Madera.Incremento);
        PlayerPrefs.SetFloat("Madera_AM", Madera.Automejora);
        PlayerPrefs.SetFloat("Madera_T", Madera.tiempo);

        PlayerPrefs.SetFloat("Granja_I", Granja.Incremento);
        PlayerPrefs.SetFloat("Granja_AM", Granja.Automejora);
        PlayerPrefs.SetFloat("Granja_T", Granja.tiempo);

        PlayerPrefs.SetFloat("Taverna_I", Taverna.Incremento);
        PlayerPrefs.SetFloat("Taverna_AM", Taverna.Automejora);
        PlayerPrefs.SetFloat("Taverna_T", Taverna.tiempo);

        PlayerPrefs.SetFloat("Libros_I", ExpBooks.Incremento);
        PlayerPrefs.SetFloat("Libros_AM", ExpBooks.Automejora);
        PlayerPrefs.SetFloat("Libros_T", ExpBooks.tiempo);

        PlayerPrefs.SetFloat("Entrenador_I", Entrenador.Incremento);
        PlayerPrefs.SetFloat("Entrenador_AM", Entrenador.Automejora);
        PlayerPrefs.SetFloat("Entrenador_T", Entrenador.tiempo);

        PlayerPrefs.SetFloat("Companero_I", Companero.Incremento);
        PlayerPrefs.SetFloat("Companero_AM", Companero.Automejora);
        PlayerPrefs.SetFloat("Companero_T", Companero.tiempo);
    }

}
