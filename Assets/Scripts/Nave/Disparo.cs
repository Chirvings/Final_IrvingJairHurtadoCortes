using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparo : MonoBehaviour
{
    public GameObject proyectilPrefab; 
    public Transform puntoDisparo; 
    public float intervaloDisparo = 0.5f; 
    private float tiempoUltimoDisparo;
    public AudioSource audioSource;
    public AudioClip sonidoDisparo;

    void Start()
    {
        tiempoUltimoDisparo = -intervaloDisparo;
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Space) && Time.time > tiempoUltimoDisparo + intervaloDisparo)
        {
            DispararProyectil();
            tiempoUltimoDisparo = Time.time;
        }
    }

    void DispararProyectil()
    {
        GameObject proyectil = Instantiate(proyectilPrefab, puntoDisparo.position, transform.rotation);
        audioSource.PlayOneShot(sonidoDisparo);
    }
}
