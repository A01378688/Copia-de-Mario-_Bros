using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuPausa : MonoBehaviour
{
    public bool estaPausado;

    public GameObject pantallaPausa;

    public void Pausar()
    {
        estaPausado = !estaPausado;
        pantallaPausa.SetActive(estaPausado);

        Time.timeScale =  estaPausado ? 0 : 1;
    }
    

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)){
            Pausar();
        }
    }
}
