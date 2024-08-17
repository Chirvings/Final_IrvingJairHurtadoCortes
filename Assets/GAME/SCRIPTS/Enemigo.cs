using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemigo : MonoBehaviour
{
    public float health = 50f;
    public NavMeshAgent agent;
    private Transform player;
    public float detectionRange = 10f;

    private void Start()
    {
        player = GameObject.Find("Player").transform;
    }
    void Update()
    {
        if (Vector3.Distance(transform.position, player.position) < detectionRange)
        {
            agent.SetDestination(player.position);
        }
    }

    public void HacerDanio(float amount)
    {
        health = health - amount;
        if (health <= 0f)
        {
            Muerte();
        }
    }

    void Muerte()
    {
        FindObjectOfType<SpawnEnemigos>().EnemigoMuerto();
        Destroy(gameObject);
    }
}
