using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VIRUS : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        ManagerPerillas.terminado = true;
        Pad2.terminado = true;
        CableCompletado.ganado = true;
        Alcantarilla.terminado = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
