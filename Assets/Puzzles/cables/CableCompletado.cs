using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CableCompletado : MonoBehaviour
{
    public MoverTarget cable1, cable2, cable3;
    public AudioSource audio2;
    public static bool ganado;
    private void Update()
    {
        if(ganado)
            return;
        if(cable1.conectado && cable2.conectado && cable3.conectado)
        {
            ganado = true;
            audio2.Play();
        }
            
    }
}
