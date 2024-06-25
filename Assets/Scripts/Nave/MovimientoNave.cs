using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoNave : MonoBehaviour
{
    public float velocidad = 10f;
    private float limiteIzquierdo = -10f;
    private float limiteDerecho = 10f;

    void Update()
    {
        
        float movimientoHorizontal = Input.GetAxis("Horizontal") * velocidad * Time.deltaTime;

        
        float nuevaPosicionX = transform.position.x + movimientoHorizontal;

        
        nuevaPosicionX = Mathf.Clamp(nuevaPosicionX, limiteIzquierdo, limiteDerecho);

        
        transform.position = new Vector3(nuevaPosicionX, transform.position.y, transform.position.z);
    }
}
