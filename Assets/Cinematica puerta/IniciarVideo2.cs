using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.UI;
public class IniciarVideo2 : MonoBehaviour
{
    public RawImage rawImageVideo;
    public RawImage rawImageFirstFrame;
    public VideoPlayer videoPlayer;
    public float delayBeforeShowing = 0.05f;
    public PuertaAbrirseManager puertaAbrirseManager;
    public bool lvl1;
    private void Awake()
    {
        puertaAbrirseManager.gameObject.SetActive(true);
        if (lvl1)
            Timer.pausa = true;
    }
    void Start()
    {
        // Desactivar RawImage antes de cargar el video
        rawImageFirstFrame.enabled = true;
        rawImageVideo.enabled = false;


        // Asignar evento para cuando el video esté preparado
        videoPlayer.prepareCompleted += OnVideoPrepared;
        videoPlayer.Prepare();
    }

    void OnVideoPrepared(VideoPlayer vp)
    {
        videoPlayer.Play();
        StartCoroutine(ShowRawImageAfterDelay());
    }

    IEnumerator ShowRawImageAfterDelay()
    {
        // Esperar un tiempo breve para evitar el frame incorrecto
        yield return new WaitForSeconds(delayBeforeShowing);
        videoPlayer.frame = 0; // Forzar que comience desde el frame 0
        rawImageVideo.enabled = true;
        rawImageFirstFrame.enabled = false;

    }
}
