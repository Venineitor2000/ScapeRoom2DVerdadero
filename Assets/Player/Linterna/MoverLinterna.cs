using UnityEngine;

public class MoverLinterna : MonoBehaviour
{
    void Update()
    {
        // Obtener la posici�n del mouse en la pantalla
        Vector3 mousePosition = Input.mousePosition;

        // Convertir la posici�n del mouse a coordenadas del mundo
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);

        // Establecer la posici�n del objeto a la posici�n del mouse
        // Asumimos que el objeto est� en el plano Z = 0
        mousePosition.z = 0;

        // Actualizar la posici�n del objeto
        transform.position = mousePosition;
    }
}
