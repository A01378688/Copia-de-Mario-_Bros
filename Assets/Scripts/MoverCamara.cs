﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverCamara : MonoBehaviour
{
    public GameObject personaje;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float x = Mathf.Clamp(value: personaje.transform.position.x, min: 0, max: 18);
        float y = Mathf.Clamp(value: personaje.transform.position.y, min: 0, max: 4.8f);
        float z = transform.position.z;
        transform.position = new Vector3(x, y, z);
    }
}
