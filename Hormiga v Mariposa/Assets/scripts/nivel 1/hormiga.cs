using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class hormiga : MonoBehaviour
{
    public GameObject mariposa1;
    public GameObject mariposa2;
    public GameObject mariposa3;

    float velocidad;
    float velocidadgiro;
    void Start()
    {
        velocidad = 4.0f;
        velocidadgiro = 150.0f;
    }


    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(Vector3.up * Time.deltaTime * velocidad);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(Vector3.up * Time.deltaTime * -velocidad);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(0f,0f,velocidadgiro * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(0f, 0f, -velocidadgiro * Time.deltaTime);
        }
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "pasto")
        {
            velocidad = 2.0f;
        }
        if ((collision.gameObject.tag == "mariposa"))
        {
            transform.position = new Vector3 (0f, -3.51f, 0f);
            mariposa1.transform.position = new Vector3(-4.13f, 3.55f, 0f);
            mariposa2.transform.position = new Vector3(3.84f, 2.78f, 0f);
            mariposa3.transform.position = new Vector3(-0.56f, 4.22f, 0f);
            VidasYPuntos.vidas -= 1;
        }

        if (collision.gameObject.tag == "azucar")
        {
            VidasYPuntos.puntos += 10;        
            Destroy(collision.gameObject);
        }

    

        if (VidasYPuntos.vidas == 0)
        {
            gameOver();
        }

        if (VidasYPuntos.puntos == 30)
        {
            SiguienteEscena();
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        velocidad = 4.0f;
    }

    public void SiguienteEscena()
    {
        SceneManager.LoadScene("1.5");
    }

    public void gameOver()
    {
        SceneManager.LoadScene("0");
    }
}
