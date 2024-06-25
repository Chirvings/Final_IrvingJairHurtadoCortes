using UnityEngine;

public class AsteroideDestruccion : MonoBehaviour
{
    public int puntosPorDestruir = 10;
    private GameManager gameManager;
    public GameObject efectoDestruccion;

    void Start()
    {

        gameManager = GameObject.FindObjectOfType<GameManager>();
    }


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Proyectil"))
        {
            
            Instantiate(efectoDestruccion, transform.position, Quaternion.identity);
            gameManager.SumarPuntos(puntosPorDestruir);
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }
}
