using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SilenciarMusica : MonoBehaviour
{
    public bool silenciar = true;
    public bool reanudar = true;
    public void Silenciar()
    {
        if(silenciar )
        GameObject.FindGameObjectWithTag("Musica").GetComponent<AudioSource>().volume = 0;
        SonidosManager.AudiosReproduciendose = true;
    }

    public void Reanudar()
    {
        if (reanudar)        
        GameObject.FindGameObjectWithTag("Musica").GetComponent<AudioSource>().volume = 0.3f;
        SonidosManager.AudiosReproduciendose = false;
    }

    private void OnEnable()
    {
        Silenciar();
    }

    private void OnDisable()
    {
        Reanudar();
    }
}
