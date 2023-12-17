using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class hormiga2 : MonoBehaviour
{
    public GameObject mariposa1;
    public GameObject mariposa2;
    public GameObject mariposa3;
    public GameObject mariposa4;
    public GameObject mariposa5;

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
            transform.Rotate(0f, 0f, velocidadgiro * Time.deltaTime);
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
            transform.position = new Vector3(0f, -3.51f, 0f);
            mariposa1.transform.position = new Vector3(-4.13f, 3.55f, 0f);
            mariposa2.transform.position = new Vector3(3.84f, 2.78f, 0f);
            mariposa3.transform.position = new Vector3(-6.42f, 1.26f, 0f);
            mariposa4.transform.position = new Vector3(-3.19f, -3.99f, 0f);
            mariposa5.transform.position = new Vector3(7.15f, -1.94f, 0f);
            VidasYPuntos.vidas -= 1;
        }

        if (collision.gameObject.tag == "azucar")
        {
            VidasYPuntos.puntos += 10;
            Destroy(collision.gameObject);
        }



        if (VidasYPuntos.vidas == 0)
        {
            VidasYPuntos.vidas = 3;
            VidasYPuntos.puntos = 0;
            gameOver();

        }

        if (VidasYPuntos.puntos == 80)
        {
            Victoria();
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        velocidad = 4.0f;
    }

    public void Victoria()
    {
        SceneManager.LoadScene("2.5");
    }

    public void gameOver()
    {
        SceneManager.LoadScene("0");
    }
}
