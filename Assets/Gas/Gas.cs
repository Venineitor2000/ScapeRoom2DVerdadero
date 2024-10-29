using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Gas : MonoBehaviour
{
    public RawImage video;
    public float opacidadMin, opacidadMax;
    public Timer timer;



    // Update is called once per frame
    void Update()
    {
        float t = 1 - timer.GetTime() / timer.tiempoAlIniciar;

        Color32 color = video.color;
        float opacidad;
        if (t > opacidadMin)
            opacidad = t;
        else
            opacidad = opacidadMin;
        if (opacidad > opacidadMax)
            opacidad = opacidadMax;
        color.a = (byte)(opacidad * 255);
        Debug.Log(opacidad);
        video.color = color;
    }
}
