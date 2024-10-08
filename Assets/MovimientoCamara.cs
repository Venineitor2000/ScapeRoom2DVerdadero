using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
public class MovimientoCamara : MonoBehaviour
{
    [SerializeField] CinemachineVirtualCamera m_Camera;
    public Transform manos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float camHeight = m_Camera.m_Lens.OrthographicSize * 2f; // Altura total visible de la cámara
        float camBottom = m_Camera.transform.position.y - camHeight / 2f; // Posición del borde inferior
        manos.position = new Vector2(transform.position.x, camBottom);

    }
}
