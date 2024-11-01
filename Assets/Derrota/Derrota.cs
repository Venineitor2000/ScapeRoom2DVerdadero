using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Derrota : MonoBehaviour
{
    public List<AudioClip> audios;
    public AudioClip audioMuerte;
    public AudioSource audiosource;
    bool a;
    bool b;
    private void Start()
    {
        audiosource.clip = audioMuerte;
        audiosource.Play();
        a = true;
        


        


         
    }

    private void Update()
    {
        if (!audiosource.isPlaying && a)
        {
            int r = Random.Range(0, audios.Count);
            audiosource.clip = audios[r];
            audiosource.Play();
            b = true;
        }
        if (b && !audiosource.isPlaying)
        {
            b = false;
            Invoke("Reiniciar", 0.5f);
        }
    }

    void Reiniciar()
    {
        GameObject.FindGameObjectWithTag("Destruir").GetComponent<DestruirDontDestroy>().Destruir();
        SceneManager.LoadScene(0);
    }
}
