using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnAsteroides : MonoBehaviour
{
    public GameObject[] asteroides;
    public Transform[] puntosDeSpawn;
    public float intervaloDeSpawn = 2f;

    private void Start()
    {
        InvokeRepeating("GenerarAsteroide", 0f, intervaloDeSpawn);
    }

    void GenerarAsteroide()
    {
        Transform puntoDeSpawn = puntosDeSpawn[UnityEngine.Random.Range(0, puntosDeSpawn.Length)];
        GameObject asteroide = asteroides[UnityEngine.Random.Range(0, asteroides.Length)];
        GameObject asteroideInstanciado = Instantiate(asteroide, puntoDeSpawn.position, puntoDeSpawn.rotation);
    }
}
