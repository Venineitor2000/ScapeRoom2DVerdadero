using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    public SpriteRenderer finalCable;
    public Transform target;
    public SpriteRenderer puntaCable;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        float distancia = Vector2.Distance(transform.position, target.position);
        finalCable.size = new Vector2(distancia, finalCable.size.y);
        ActualizarRotacion();
        // Actualiza la posición de la punta del cable
        ActualizarPosicionPuntaCable();
    }

    void ActualizarRotacion()
    {
        Vector2 posicionActual = transform.position;
        Vector2 posicionOrigen = target.position;
        Vector2 direccion = posicionActual - posicionOrigen;
        float angulo = Vector2.SignedAngle(Vector2.left * transform.lossyScale, direccion);
        transform.rotation = Quaternion.Euler(0, 0, angulo);

    }

    void ActualizarPosicionPuntaCable()
    {
        // Obtiene el tamaño actual del cable
        float anchoCable = finalCable.size.x;

        // Calcula la nueva posición para la punta del cable en función de la rotación del cable
        Vector3 nuevaPosicionPunta = transform.position + transform.right * anchoCable ;

        // Asigna la posición calculada a la punta del cable
        puntaCable.transform.position = nuevaPosicionPunta;
        puntaCable.transform.rotation = transform.rotation;
    }
}
