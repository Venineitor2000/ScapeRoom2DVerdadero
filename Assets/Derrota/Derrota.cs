using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Derrota : MonoBehaviour
{
    public List<AudioClip> audios;
    public AudioSource audiosource;
    bool a = true;
    private void Start()
    {
        int r = Random.Range(0, audios.Count);
        audiosource.clip = audios[r];
        audiosource.Play();


         
    }

    private void Update()
    {
        if (a && !audiosource.isPlaying)
        {
            a = false;
            Invoke("Reiniciar", 0.5f);
        }
    }

    void Reiniciar()
    {
        GameObject.FindGameObjectWithTag("Destruir").GetComponent<DestruirDontDestroy>().Destruir();
        SceneManager.LoadScene(0);
    }
}
