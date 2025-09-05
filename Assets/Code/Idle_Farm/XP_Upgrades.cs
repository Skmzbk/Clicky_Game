using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class XP_Upgrades : MonoBehaviour
{
    public GameObject TextoM,TextoG,TextoT;
    public Button Maderax2,Granjax2,Tavernax2;
    public float Mejora_Madera=1000f, Mejora_Trigo=10000f, Mejora_Cerveza=100000f;
    public static bool x2M = false, x2G = false, x2T = false;

   public void MasMadera()
    {
        if (Contador_Universal.Exp >= Mejora_Madera && !x2M)
        {
            Contador_Universal.Exp -= Mejora_Madera;
            Automata.Wood = 2;
            x2M = true;
        }
        
    }

   public void MasTrigo()
    {
        if (Contador_Universal.Exp >= Mejora_Trigo && !x2G)
        {
            Contador_Universal.Exp -= Mejora_Trigo;
            Automata.Wheat = 2;
            x2G = true;
        }

    }

    public void MasCerveza()
    {
        if (Contador_Universal.Exp >= Mejora_Cerveza && !x2T)
        {
            Contador_Universal.Exp -= Mejora_Trigo;
            Automata.Beer = 2;
            x2T = true;
        }

    }

    private void Update()
    {
        TextoM.GetComponent<Text>().text = "Madera x2 =" + Mejora_Madera + " exp";
        TextoG.GetComponent<Text>().text = "Granjas x2 =" + Mejora_Trigo + " exp";
        TextoT.GetComponent<Text>().text = "Tavernas x2 =" + Mejora_Cerveza + " exp";

        if (Contador_Universal.Exp >= Mejora_Madera && !x2M)
        {
            Maderax2.interactable = true;
        }
        else
        {
            Maderax2.interactable = false;
        }

        if (Contador_Universal.Exp >= Mejora_Trigo && !x2G)
        {
            Granjax2.interactable = true;
        }
        else
        {
            Granjax2.interactable = false;
        }

        if (Contador_Universal.Exp >= Mejora_Cerveza && !x2T)
        {
            Tavernax2.interactable = true;
        }
        else
        {
            Tavernax2.interactable = false;
        }
    }



}
