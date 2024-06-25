using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText; 
    public TextMeshProUGUI tiempoText;
    private int score = 0; 
    private float tiempoTranscurrido = 0f; 
    private bool juegoActivo = true; 

    void Start()
    {
        
        ActualizarUI();
    }

    void Update()
    {
        if (juegoActivo)
        {
            
            tiempoTranscurrido += Time.deltaTime;
            ActualizarUI();
        }
    }

    
    public void SumarPuntos(int puntos)
    {
        score += puntos; 
        ActualizarUI(); 
    }

    
    void ActualizarUI()
    {
        scoreText.text = "Score: " + score.ToString();
        tiempoText.text = "Tiempo: " + Mathf.RoundToInt(tiempoTranscurrido).ToString() + "s";
    }
}
