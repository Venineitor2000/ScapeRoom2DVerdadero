using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Video;

public class VideoTermino2 : MonoBehaviour
{
    public PuertaAbrirseManager puertaAbrirseManager;
    [SerializeField] VideoPlayer video;
    public UnityEvent OnVideoTerminoPrimeraVez;
    public static bool terminoPrimeraVez; //Usala para activar todo en la nueva escena
    public bool lvl1;
    private void Awake()
    {
        if (terminoPrimeraVez)
        {
            OnVideoTerminoPrimeraVez.Invoke();
            return;
        }
        //puertaAbrirseManager.DesPausar();
        video.loopPointReached += VideoTerminoPrimeraVez;
    }

    void VideoTerminoPrimeraVez(VideoPlayer vp)
    {
        if (terminoPrimeraVez)
            return;
        terminoPrimeraVez = true;
        if(lvl1)
            Timer.pausa = false;
        OnVideoTerminoPrimeraVez.Invoke();
        video.loopPointReached -= VideoTerminoPrimeraVez;
        if (lvl1)
        {
            Destroy(puertaAbrirseManager.gameObject);
            if (gameObject != null)
                gameObject.SetActive(false);
        }
        
            
    }
}
