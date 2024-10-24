using UnityEngine;

public class SpritePositionAdjuster : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    private Vector3 originalPosition;

    void Start()
    {
        // Obt�n el SpriteRenderer
        spriteRenderer = GetComponent<SpriteRenderer>();
        // Guarda la posici�n original
        originalPosition = transform.position;
    }

    void Update()
    {
        AdjustPosition();
    }

    void AdjustPosition()
    {
        // Obt�n el tama�o del sprite en el mundo
        Vector2 spriteSize = spriteRenderer.bounds.size;

        // Ajusta la posici�n del objeto para que su borde izquierdo siempre est� en la posici�n original
        transform.position = new Vector3(originalPosition.x + spriteSize.x, originalPosition.y, originalPosition.z);
    }
}