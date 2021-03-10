using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void Jugar(){
        //Cambiar a la escena jugar
        SceneManager.LoadScene("EscenaMapa");
    }

    public void Salir(){
        Application.Quit();
    }
}
