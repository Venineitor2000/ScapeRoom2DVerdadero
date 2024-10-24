using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tROZOcABLEpUZLE : MonoBehaviour
{
    public SpriteRenderer finalCable;
    public Transform origen;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDrag()
    {
        ActualizarPosicion();
        ActualizarRotacion();
        ActualizarTamaño();
    }

    void ActualizarPosicion()
    {
        Vector2 mousePosicion = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = new Vector2(mousePosicion.x, mousePosicion.y);
    }

    void ActualizarRotacion()
    {
        Vector2 posicionActual = transform.position;
        Vector2 posicionOrigen = origen.position;
        Vector2 direccion = posicionActual - posicionOrigen;
        float angulo = Vector2.SignedAngle(Vector2.right * transform.lossyScale, direccion);
        transform.rotation = Quaternion.Euler(0, 0, angulo);
    }

    void ActualizarTamaño()
    {
        Vector2 posicionActual = transform.position;
        Vector2 posicionOrigen = origen.position;
        float distancia = Vector2.Distance(posicionOrigen, posicionActual);
        finalCable.size = new Vector2(distancia, finalCable.size.y);
    }
}
