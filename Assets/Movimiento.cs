using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
public class Movimiento : MonoBehaviour
{
    [SerializeField] CinemachineVirtualCamera m_Camera;
    [SerializeField] float speedX;
    [SerializeField] float speedY;
    [SerializeField] float distanciaRaycastParedesX;
    [SerializeField] float distanciaRaycastParedesY;
    [SerializeField] LayerMask layerPared;
    [SerializeField] float minZoom, maxZoom;
    [SerializeField] float speedZoom;

    [SerializeField] Transform limiteY1, limiteY2;
    // Update is called once per frame
    void Update()
    {
        //Movimiento horizontal
        RaycastHit2D rayX = Physics2D.Raycast(transform.position, new Vector3(Input.GetAxis("Horizontal"), 0, 0), distanciaRaycastParedesX, layerPared);
        if(!rayX)    
            transform.Translate(new Vector3(speedX * Time.deltaTime * Input.GetAxis("Horizontal"), 0, 0));

        //Movimiento vertical
        RaycastHit2D rayY = Physics2D.Raycast(transform.position, new Vector3(0, Input.GetAxis("Vertical"), 0), distanciaRaycastParedesY, layerPared);
        if (!rayY)
        {
            transform.Translate(new Vector3(0, speedY * Time.deltaTime * Input.GetAxis("Vertical"), 0));
            m_Camera.m_Lens.OrthographicSize = Mathf.Lerp(maxZoom, minZoom, transform.position.y / ((Mathf.Abs(limiteY1.position.y) + Mathf.Abs(limiteY2.position.y))/2));
            
        }

        // Ajustar la cámara para que el borde inferior esté alineado con las manos
        float camHeight = m_Camera.m_Lens.OrthographicSize * 2f; // Altura total de la cámara (para cámara ortográfica)
        Vector3 camPos = m_Camera.transform.position;
        camPos.y = transform.position.y + camHeight / 2f; // Ajustar el borde inferior de la cámara a la posición Y de las manos
        m_Camera.transform.position = camPos;
    }
}
