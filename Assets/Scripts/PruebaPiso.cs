using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PruebaPiso : MonoBehaviour
{
    public static bool estaEnPiso;
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        estaEnPiso = true;
        print(message: "Está en piso");
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        estaEnPiso = false;
        print(message: "Está fuera del piso");
    }
}
