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
        OnVideoTerminoPrimeraVez.Invoke();
        video.loopPointReached -= VideoTerminoPrimeraVez;
        Destroy(puertaAbrirseManager.gameObject);
        gameObject.SetActive(false);
    }
}
