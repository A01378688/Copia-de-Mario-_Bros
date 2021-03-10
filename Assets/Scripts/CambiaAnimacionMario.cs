using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambiaAnimacionMario : MonoBehaviour
{
    private Rigidbody2D rb2D;   // Para la velocidad
    private Animator anim;      // Animator del personaje
    private SpriteRenderer sprRenderer;

    // Start is called before the first frame update
    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        sprRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        float velocidad = Mathf.Abs(rb2D.velocity.x);
        anim.SetFloat(name:"velocidad", velocidad);

        if (rb2D.velocity.x > 0.1){
            sprRenderer.flipX = false;
        } else if (rb2D.velocity.x < 0.1){
            sprRenderer.flipX = true;
        }

        if (!PruebaPiso.estaEnPiso){
            anim.SetBool(name:"saltando", value: true);
        } else {
            anim.SetBool(name:"saltando", value: false);
        }
    }
}
