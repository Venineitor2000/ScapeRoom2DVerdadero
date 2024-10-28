using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Perilla : MonoBehaviour
{
    [SerializeField] bool perrillaBasura;
    int estadoActual = 0; //0 a 3
    [SerializeField] int estadoCorrecto;
    [SerializeField] int estadoCorrecto2 = 1000;
    float rangoRotacion = 90;
    [SerializeField] GameObject luz;
    [SerializeField] Perilla perillaAnterior;
    bool completada;
    bool rotando;
    [SerializeField] float duracion;

    private void Awake()
    {
        Inicilizar();
    }

    public void Presionada()
    {
        
        if (completada)
            return;
        if(rotando)
            return;

        estadoActual++;
        if (estadoActual == 4)
            estadoActual = 0;
        rotando = true;
        transform.DORotate(new Vector3(transform.rotation.eulerAngles.x, transform.rotation.eulerAngles.y, estadoActual * rangoRotacion), duracion).OnComplete(() =>
        {
            rotando = false;
            Valdiar();
        });

        
    }

    void Valdiar()
    {
        if (perrillaBasura)
            return;
        if (perillaAnterior == null || perillaAnterior.completada)
        {
            if (estadoActual == estadoCorrecto || estadoActual == estadoCorrecto2)
            {
                luz.SetActive(true);
                completada = true;
            }
        }
    }

    void Inicilizar()
    {
        InicializarEstado();
        transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles.x, transform.rotation.eulerAngles.y, estadoActual * rangoRotacion);
    }

    void InicializarEstado()
    {
        do
        {
            estadoActual = Random.Range(0, 4); // Genera un valor entre 0 y 3
        }
        while (estadoActual == estadoCorrecto || estadoActual == estadoCorrecto2); // Repite si es igual a estadoCorrecto 1 o 2
    }


}
