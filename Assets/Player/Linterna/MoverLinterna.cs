using UnityEngine;

public class MoverLinterna : MonoBehaviour
{
    void Update()
    {
        // Obtener la posición del mouse en la pantalla
        Vector3 mousePosition = Input.mousePosition;

        // Convertir la posición del mouse a coordenadas del mundo
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);

        // Establecer la posición del objeto a la posición del mouse
        // Asumimos que el objeto está en el plano Z = 0
        mousePosition.z = 0;

        // Actualizar la posición del objeto
        transform.position = mousePosition;
    }
}
