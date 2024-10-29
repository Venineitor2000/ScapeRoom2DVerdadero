using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverTarget : MonoBehaviour
{
    Vector3 posicionInicial;
    [SerializeField]MoverTarget compa�ero;
    bool conectadoACompa�ero;
    public bool conectado;
    [SerializeField] GameObject luz;
    private void Awake()
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

        if (conectadoACompa�ero)
        {
            transform.position = compa�ero.posicionInicial;
            Conectado();
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
            if (componente == compa�ero)
            {
                conectadoACompa�ero = true;
            }
            else
            {
                conectadoACompa�ero = false;
            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        MoverTarget componente = collision.GetComponent<MoverTarget>();
        if (componente != null)
        {
            if (componente == compa�ero)
            {
                conectadoACompa�ero = false;
            }
        }
    }

    void Conectado()
    {
        conectado = true;
        compa�ero.conectado = true;
        luz.SetActive(true);
        compa�ero.luz.SetActive(true);
    }
  
}
