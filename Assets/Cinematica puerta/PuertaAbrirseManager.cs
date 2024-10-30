using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PuertaAbrirseManager : MonoBehaviour
{
    public int numeroEscena;
    public bool lvl2;
    private void Awake()
    {
        if(!lvl2)
        {
            DontDestroyOnLoad(gameObject);
            StartCoroutine(LoadYourAsyncScene());
        }
        else
        {

        }
    }


    IEnumerator LoadYourAsyncScene()
    {

        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(numeroEscena);

        // Wait until the asynchronous scene fully loads
        while (!asyncLoad.isDone)
        {
            yield return null;
        }
        
    }

}
