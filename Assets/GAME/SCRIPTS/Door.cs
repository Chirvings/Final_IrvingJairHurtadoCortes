using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public Item itemRequerido;
    private Animator animator;
    private void Start()
    {
        animator = GetComponent<Animator>();
    }
    public void Abrir(Inventario inventario)
    {
        if (inventario.HasItem(itemRequerido))
        {
            Desbloquear();
        }
        else
        {
            Debug.Log("No tienes el objeto necesario para abrir esta puerta.");
        }
    }

    void Desbloquear()
    {
        animator.Play("Open");
    }
}
