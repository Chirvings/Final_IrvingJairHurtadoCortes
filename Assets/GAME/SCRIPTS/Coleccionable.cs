using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coleccionable : MonoBehaviour
{
    public Item item;

    public void Collect(Inventario inventario)
    {
        inventario.AddItem(item);
        Destroy(gameObject);
    }
}
