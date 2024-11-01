using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SonidosManager : MonoBehaviour
{
    float timer;
    public static bool AudiosReproduciendose = true;
    public AudioSource audio2;
    public List<AudioClip> audioClipList;
    private Queue<AudioClip> audiosUsados = new Queue<AudioClip>();
    int cantidadAntesRepetirseUnAudio = 5;//OSea cuantos audios tienen que pasar antes de que se pueda repetir un audio que ya se uso, ejemplo usas un audio y minimo tienen que pasar 5 mas hasta q suene de nuevo
    public float tiempoEjecucionMin, tiempoEjecucionMax;
    float tiempoEjecucionActual;
    public List<AudioClip> IA;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(AudiosReproduciendose && audio2.isPlaying)
        {
            audio2.Stop();
        }

        else  if(!AudiosReproduciendose && !audio2.isPlaying) 
        {
            timer += Time.deltaTime;
            if(timer == tiempoEjecucionActual)
            {
                float PosX = Random.Range(-18f, 18f);
                float PosY = Random.Range(-5.5f, 10f);
                transform.position = new Vector2(PosX, PosY);
                tiempoEjecucionActual = Random.Range(tiempoEjecucionMin,tiempoEjecucionMax);
                timer = 0;
                audio2.clip = ElegirAudio();
                audio2.Play();
            }
        }
    }

    AudioClip ElegirAudio()
    {
        AudioClip audioSeleccionado;

        // Intentamos obtener un audio que no esté en la lista de audios usados
        do
        {
            audioSeleccionado = audioClipList[Random.Range(0, audioClipList.Count)];
        } while (audiosUsados.Contains(audioSeleccionado));

        // Si la cola de audios usados tiene 5 elementos, eliminamos el más antiguo
        if (audiosUsados.Count >= cantidadAntesRepetirseUnAudio)
        {
            audiosUsados.Dequeue();
        }

        // Agregamos el audio seleccionado a la cola de audios usados
        audiosUsados.Enqueue(audioSeleccionado);
        if(IA.Contains(audioSeleccionado))
            audioClipList.Remove(audioSeleccionado);
        return audioSeleccionado;
    }
}
