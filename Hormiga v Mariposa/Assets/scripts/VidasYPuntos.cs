using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VidasYPuntos : MonoBehaviour
{
    public TextMeshProUGUI Textpuntos;
    public TextMeshProUGUI Textvidas;
    public static int vidas = 3;
    public static int puntos = 0;

    void Start()
    {
        DontDestroyOnLoad(this);   
    }


    void Update()
    {
        Textpuntos.text = puntos.ToString();
        Textvidas.text = vidas.ToString();
    }
}
