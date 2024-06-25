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

    void OnDestroy()
    {

        Instantiate(efectoDestruccion, transform.position, Quaternion.identity);

        gameManager.SumarPuntos(puntosPorDestruir);
    }
}
