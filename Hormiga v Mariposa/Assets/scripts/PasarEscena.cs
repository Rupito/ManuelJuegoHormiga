using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PasarEscena : MonoBehaviour
{
    void Start()
    {
        
    }


    void Update()
    {
        
    }

    public void SiguienteEscena()
    {
        SceneManager.LoadScene("02");
    }

    public void GameOver()
    {
        SceneManager.LoadScene("01");
        VidasYPuntos.vidas = 3;
        VidasYPuntos.puntos = 0;
    }
}
