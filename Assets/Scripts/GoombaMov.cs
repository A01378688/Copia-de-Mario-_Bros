using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoombaMov : MonoBehaviour
{
    public float velocidadX = -1;

    private Rigidbody2D rigidbody;
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rigidbody.velocity = new Vector2(velocidadX, 0);
    }
}
