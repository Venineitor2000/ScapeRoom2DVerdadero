using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjetoAudio : MonoBehaviour
{
    bool a;
    public AudioSource audioObjeto;
    private void Start()
    {
        if (!a && audioObjeto.clip  != null)
        {
            a = true;
            audioObjeto.enabled = true;
        }
        
    }
}
