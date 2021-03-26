using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUD : MonoBehaviour
{

    public Image Image1;
    public Image Image2;
    public Image Image3;

    public static HUD instance;

    private void Awake()
    {
        instance = this;
    }

    public void ActualizarVidas()
    {
        int vidas = SaludPersonaje.instance.vidas;
        if (vidas == 2){
            Image3.enabled = false;
        } else if (vidas == 1){
            Image2.enabled = false;
        } else if (vidas  == 0){
            Image1.enabled = false;
        }

    }
}
