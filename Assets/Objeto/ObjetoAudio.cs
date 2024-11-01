using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjetoAudio : MonoBehaviour
{
    bool a;
    public AudioSource audioObjeto;
    bool b;
    private void Start()
    {
        if (!a && audioObjeto.clip  != null)
        {
            a = true;
            audioObjeto.enabled = true;
            SonidosManager.AudiosReproduciendose = true;
        }
        
    }

    private void Update()
    {
        if(a && !audioObjeto.isPlaying && !b)
        {
            SonidosManager.AudiosReproduciendose = false;
            b = true;
        }
            
    }
}
