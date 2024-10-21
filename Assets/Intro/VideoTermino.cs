using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Video;

public class VideoTermino : MonoBehaviour
{
    public IntroManager introManager;
    [SerializeField] VideoPlayer video;
    public UnityEvent OnVideoTerminoPrimeraVez;
    static bool terminoPrimeraVez;
    private void Awake()
    {
        if (terminoPrimeraVez)
        {
            OnVideoTerminoPrimeraVez.Invoke();
            return;
        }
        introManager.DesPausar();
        video.loopPointReached += VideoTerminoPrimeraVez;
    }

    void VideoTerminoPrimeraVez(VideoPlayer vp)
    {
        if (terminoPrimeraVez)
            return;
        terminoPrimeraVez = true;
        OnVideoTerminoPrimeraVez.Invoke();
        video.loopPointReached -= VideoTerminoPrimeraVez;
        introManager.DesPausar();
        gameObject.SetActive(false);
    }
}
