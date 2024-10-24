using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeguirTarget : MonoBehaviour
{
    public SpriteRenderer finalCable;
    public Transform target;
    public SpriteRenderer puntaCable;
    public bool left;
    int valorLado;
    // Start is called before the first frame update
    void Start()
    {
        if(left)
            valorLado = 1;
        else valorLado = -1;
    }

    // Update is called once per frame
    void Update()
    {
        
        float distancia = Vector2.Distance(transform.position, target.position);
        finalCable.size = new Vector2(distancia, finalCable.size.y);
        ActualizarRotacion();
        // Actualiza la posici�n de la punta del cable
        ActualizarPosicionPuntaCable();
    }

    void ActualizarRotacion()
    {
        Vector2 posicionActual = transform.position;
        Vector2 posicionOrigen = target.position;
        Vector2 direccion = posicionActual - posicionOrigen;
        float angulo = Vector2.SignedAngle(Vector2.left * valorLado, direccion);
        transform.rotation = Quaternion.Euler(0, 0, angulo);

    }

    void ActualizarPosicionPuntaCable()
    {
        // Obtiene el tama�o actual del cable
        float anchoCable = finalCable.size.x * valorLado;

        // Calcula la nueva posici�n para la punta del cable en funci�n de la rotaci�n del cable
        Vector3 nuevaPosicionPunta = transform.position + transform.right * anchoCable ;

        // Asigna la posici�n calculada a la punta del cable
        puntaCable.transform.position = nuevaPosicionPunta;
        puntaCable.transform.rotation = transform.rotation;
    }
}
