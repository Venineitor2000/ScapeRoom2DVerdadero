using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Victoria : MonoBehaviour
{
    private void Start()
    {
        GameObject.FindGameObjectWithTag("Destruir").GetComponent<DestruirDontDestroy>().Destruir();
        SceneManager.LoadScene(0);
    }

    
}
