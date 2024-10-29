using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerPuerta : MonoBehaviour
{
    [SerializeField] AudioSource audioPuerta, audioPostPuerta;
    bool a;
    bool b;
    float delay = 0.5f;
    float delayPostPuerta = 0f;
    public Movimiento movimiento;
    bool timerAbierto;
    public GameObject timerText;
    public Timer timer;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(!a)
        if(collision.tag == "Player")
        {
                Invoke("AudioPuerta", delay);
        }
    }

    private void Start()
    {
        movimiento.soloMovimientoAdelante = true;
    }

    void AudioPuerta()
    {
        a = true;
        audioPuerta.enabled = true;
    }

    private void Update()
    {
        if ((a && !audioPuerta.isPlaying))
        {
            if(!b)
            {
                if (!timerAbierto)
                {
                    timer.enabled = true;
                    timerText.SetActive(true);
                    
                    timerAbierto = true;
                }
                movimiento.soloMovimientoAdelante = false;
                Invoke("audioPostPuerta2", delayPostPuerta);
                b = true;
            }
            
        }
    }

    void audioPostPuerta2()
    {
        audioPostPuerta.enabled = true;
        
    }
}
