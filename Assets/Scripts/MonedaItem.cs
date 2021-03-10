using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonedaItem : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other){
        if (other.gameObject.CompareTag("Player")){

            //Prende la explosion
            gameObject.transform.GetChild(0).gameObject.SetActive(true);

            //Esconde moneda
            GetComponent<SpriteRenderer>().enabled = false;

            print(message: "Recolectó moneda");
            Destroy(gameObject, t:1f);

            //Destroy(other.gameObject);


        }
    }
}
