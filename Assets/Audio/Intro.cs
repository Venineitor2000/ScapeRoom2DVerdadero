using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Intro : MonoBehaviour
{
    [SerializeField] Movimiento movimiento;
    [SerializeField] List<AudioSource> audios;
    public GameObject timer;
    bool a;
    bool timerAbierto;
    private void Start()
    {
        movimiento.enabled = false;
        audios[0].enabled = true;

    }

    private void Update()
    {
        if (!a)
            if (!audios[0].isPlaying && audios[0].enabled)
            {
                audios[1].enabled = true;
                if (!audios[1].isPlaying && audios[1].enabled)
                {
                    audios[2].enabled = true;
                    if (!audios[2].isPlaying && audios[2].enabled)
                    {
                        audios[3].enabled = true;
                        if (!audios[3].isPlaying && audios[3].enabled)
                        {
                            if (!audios[3].isPlaying && audios[3].enabled)
                            {
                                audios[4].enabled = true;
                                
                                if (!audios[4].isPlaying && audios[4].enabled)
                                {
                                    if (!timerAbierto)
                                    {
                                        timer.SetActive(true);
                                        timerAbierto = true;
                                    }
                                    audios[5].enabled = true;
                                    
                                   
                                    if (!audios[5].isPlaying && audios[5].enabled)
                                    {
                                        movimiento.enabled = true;
                                        a = true;
                                    }
                                }
                            }

                            
                        }
                    }
                }
            }

    }
}
