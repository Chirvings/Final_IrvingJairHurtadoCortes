using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerIntereccion : MonoBehaviour
{
    public float interactRange = 2f;
    public Camera fpsCam;
    public Inventario inventario;

    void Update()
    {
        RaycastHit hit;
        if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, interactRange))
        {

            Coleccionable coleccionable = hit.transform.GetComponent<Coleccionable>();
            Door door = hit.transform.GetComponent<Door>();

            if (Input.GetKeyDown(KeyCode.E))
            {
                
                if (coleccionable != null)
                {
                    coleccionable.Collect(inventario);
                }

                if (door != null)
                {
                    door.Abrir(inventario);
                }
            }

        }
    }
}
