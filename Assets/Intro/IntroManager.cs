using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntroManager : MonoBehaviour
{
    [SerializeField] List<GameObject> objetosPausados;

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            DesPausar();
            Destroy(gameObject);
        }
            
    }
    public void Pausar()
    {
        foreach (var item in objetosPausados)
        {
            item.SetActive(false);
        }
    }

    public void DesPausar()
    {
        foreach (var item in objetosPausados)
        {
            item.SetActive(true);
        }
    }
}
