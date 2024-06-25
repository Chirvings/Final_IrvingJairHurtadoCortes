using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroideMovimiento : MonoBehaviour
{
    public float velocidad = 5f;

    void Update()
    {
        transform.Translate(Vector3.back * velocidad * Time.deltaTime);
    }



}
