using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemigos : MonoBehaviour
{
    public GameObject enemyPrefab;
    public Transform[] spawnPoints;
    public float spawnIntervalo = 5f;
    public int enemigosMaximos = 10;

    private int enemigosActuales;

    void Start()
    {
        InvokeRepeating(nameof(SpawnEnem), spawnIntervalo, spawnIntervalo);
    }

    void SpawnEnem()
    {
        if (enemigosActuales >= enemigosMaximos) return;

        int randomIndex = Random.Range(0, spawnPoints.Length);
        Instantiate(enemyPrefab, spawnPoints[randomIndex].position, Quaternion.identity);
        enemigosActuales++;
    }

    public void EnemigoMuerto()
    {
        enemigosActuales--;
    }
}
