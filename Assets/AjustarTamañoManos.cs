using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AjustarTamañoManos : MonoBehaviour
{
     public Camera mainCamera;  // La cámara que usas para hacer zoom
    public Transform sprite;   // El sprite cuyo tamaño quieres ajustar

    private float initialSize;
    private Vector3 initialScale;

    void Start()
    {
        // Guarda el tamaño inicial de la cámara y el sprite
        initialSize = mainCamera.orthographicSize;
        initialScale = sprite.localScale;
    }

    void Update()
    {
        // Calcula el factor de escala en base al cambio del tamaño de la cámara
        float scaleFactor = mainCamera.orthographicSize / initialSize;
        Debug.Log(scaleFactor);
        // Ajusta la escala del sprite de forma inversa al tamaño de la cámara
        sprite.localScale = initialScale * scaleFactor;
    }
}
