using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mariposa2 : MonoBehaviour
{
    public GameObject hormiga;
    public float velocidadMariposa;
    float posicionX;
    float posicionY;

    void Start()
    {
        posicionX = transform.position.x;
    }


    void Update()
    {
        if (hormiga.transform.position.x < transform.position.x)
        {
            posicionX = velocidadMariposa * Time.deltaTime;
            transform.position -= new Vector3(posicionX, 0f, 0f);
        }

        if (hormiga.transform.position.x > transform.position.x)
        {
            posicionX = velocidadMariposa * Time.deltaTime;
            transform.position += new Vector3(posicionX, 0f, 0f);
        }

        if (hormiga.transform.position.y < transform.position.y)
        {
            posicionY = velocidadMariposa * Time.deltaTime;
            transform.position -= new Vector3(0f, posicionY, 0f);
        }

        if (hormiga.transform.position.y > transform.position.y)
        {
            posicionY = velocidadMariposa * Time.deltaTime;
            transform.position += new Vector3(0f, posicionY, 0f);
        }
    }
}
