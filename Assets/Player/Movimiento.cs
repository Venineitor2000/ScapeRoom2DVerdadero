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
    [SerializeField] float distanciaRaycastTecho, distanciaRaycastPiso;
    [SerializeField] LayerMask layerPared;
    [SerializeField] float minZoom, maxZoom;
    [SerializeField] float speedZoom;
    bool detenido;
    [SerializeField] Transform limiteY1, limiteY2;
    public bool soloMovimientoAdelante;
    private void Awake()
    {
        m_Camera.m_Lens.OrthographicSize = Mathf.Lerp(maxZoom, minZoom, transform.position.y / ((Mathf.Abs(limiteY1.position.y) + Mathf.Abs(limiteY2.position.y)) / 2));

    }
    // Update is called once per frame
    void Update()
    {
        if (detenido)
        {
            return;
        }
        //Movimiento horizontal
        if(!soloMovimientoAdelante)
        {
            RaycastHit2D rayX = Physics2D.Raycast(transform.position, new Vector3(Input.GetAxis("Horizontal"), 0, 0), distanciaRaycastParedesX, layerPared);
            if (!rayX)
                transform.Translate(new Vector3(speedX * Time.deltaTime * Input.GetAxis("Horizontal"), 0, 0));
        }
        

        //Movimiento vertical

        if(Input.GetAxis("Vertical") > 0)
        {
            RaycastHit2D rayY = Physics2D.Raycast(transform.position, new Vector3(0, Input.GetAxis("Vertical"), 0), distanciaRaycastTecho, layerPared);
            if (!rayY)
            {
                transform.Translate(new Vector3(0, speedY * Time.deltaTime * Input.GetAxis("Vertical"), 0));
                m_Camera.m_Lens.OrthographicSize = Mathf.Lerp(maxZoom, minZoom, transform.position.y / ((Mathf.Abs(limiteY1.position.y) + Mathf.Abs(limiteY2.position.y)) / 2));

            }
        }
        if(!soloMovimientoAdelante)
        if (Input.GetAxis("Vertical") < 0)
        {
            RaycastHit2D rayY = Physics2D.Raycast(transform.position, new Vector3(0, Input.GetAxis("Vertical"), 0), distanciaRaycastPiso, layerPared);
            if (!rayY)
            {
                transform.Translate(new Vector3(0, speedY * Time.deltaTime * Input.GetAxis("Vertical"), 0));
                m_Camera.m_Lens.OrthographicSize = Mathf.Lerp(maxZoom, minZoom, transform.position.y / ((Mathf.Abs(limiteY1.position.y) + Mathf.Abs(limiteY2.position.y)) / 2));

            }
        }

        
    }

    public void Detener()
    {
        detenido = true;
    }

    public void ReanudarMovimiento()
    {
        detenido = false;
    }
}
