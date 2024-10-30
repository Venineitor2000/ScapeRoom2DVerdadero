using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
public class ManagerPerillas : MonoBehaviour
{
    public GameObject ultimaLuzPerilla1, ultimaLuzPerilla2, perilla1, perilla2;
    public RectTransform perilla1Fondo;
    float duracion = 1f; // Duración del desplazamiento en segundos
    float distancia = 2000f; // Distancia que se moverá hacia arriba
    bool a, b;
    static public bool terminado = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void MoverArribaPerilla1()
    {
        perilla1Fondo.DOMoveY(perilla1Fondo.position.y + distancia, duracion)
            .SetEase(Ease.Linear)
            .OnComplete(() => {
                // Acción a realizar al completar el desplazamiento
                perilla1.SetActive(false);
                perilla2.SetActive(true);
            });
    }

    // Update is called once per frame
    void Update()
    {
        if(!a)
        {
            if (ultimaLuzPerilla1.activeSelf == true)
            {
                a = true;
                MoverArribaPerilla1();
            }
        }
        else if(!b)
        {
            if (ultimaLuzPerilla2.activeSelf == true)
            {
                b = true;
                terminado = true;
            }
        }


    }
}
