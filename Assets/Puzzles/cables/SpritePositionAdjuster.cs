using UnityEngine;

public class SpritePositionAdjuster : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    private Vector3 originalPosition;

    void Start()
    {
        // Obtén el SpriteRenderer
        spriteRenderer = GetComponent<SpriteRenderer>();
        // Guarda la posición original
        originalPosition = transform.position;
    }

    void Update()
    {
        AdjustPosition();
    }

    void AdjustPosition()
    {
        // Obtén el tamaño del sprite en el mundo
        Vector2 spriteSize = spriteRenderer.bounds.size;

        // Ajusta la posición del objeto para que su borde izquierdo siempre esté en la posición original
        transform.position = new Vector3(originalPosition.x + spriteSize.x, originalPosition.y, originalPosition.z);
    }
}