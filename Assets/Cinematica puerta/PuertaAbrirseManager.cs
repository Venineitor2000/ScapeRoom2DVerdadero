using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PuertaAbrirseManager : MonoBehaviour
{
    public int numeroEscena;
    private void Awake()
    {
            DontDestroyOnLoad(gameObject);
            StartCoroutine(LoadYourAsyncScene());
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
