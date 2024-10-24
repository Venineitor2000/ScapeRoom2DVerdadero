using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverTarget : MonoBehaviour
{
    Vector3 posicionInicial;
    [SerializeField]MoverTarget compañero;
    bool conectadoACompañero;
    bool conectado;
    private void Start()
    {
        posicionInicial = transform.position;
    }
    private void OnMouseDrag()
    {
        if(!conectado)
        ActualizarPosicion();
    }

    private void OnMouseUp()
    {
        if (conectado)
            return;

        if (conectadoACompañero)
        {
            transform.position = compañero.posicionInicial;
            conectado = true;
            compañero.conectado = true;
        }
        else
            transform.position = posicionInicial;
    }

    void ActualizarPosicion()
    {
        Vector2 mousePosicion = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = new Vector2(mousePosicion.x, mousePosicion.y);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        MoverTarget componente = collision.GetComponent<MoverTarget>();
        if (componente != null)
        {
            if (componente == compañero)
            {
                conectadoACompañero = true;
            }
            else
            {
                conectadoACompañero = false;
            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        MoverTarget componente = collision.GetComponent<MoverTarget>();
        if (componente != null)
        {
            if (componente == compañero)
            {
                conectadoACompañero = false;
            }
        }
    }

  
}
