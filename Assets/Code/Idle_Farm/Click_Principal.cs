using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Click_Principal : MonoBehaviour
{
    public static float click = 1;

    public void Clicky()
    {
        Contador_Universal.Oro += click;
        Contador_Universal.Exp += click;
    }
}
