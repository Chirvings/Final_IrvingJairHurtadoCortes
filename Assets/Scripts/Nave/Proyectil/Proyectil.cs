using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Proyectil : MonoBehaviour
{
    public float velocidad = 10f; 

    void Start()
    {
        
        GetComponent<Rigidbody>().velocity = transform.forward * velocidad;
    }

    void Update()
    {
        if (!GetComponent<Renderer>().isVisible)
        {
            Destroy(gameObject);
        }
    }
}
