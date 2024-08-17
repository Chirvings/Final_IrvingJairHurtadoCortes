using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjetoDestruible : MonoBehaviour
{
    public float health = 20f;

    public void HacerDanio(float amount)
    {
        health = health - amount;
        if (health <= 0f)
        {
            Destroy(gameObject);
        }
    }
}
