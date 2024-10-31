using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReiniciarStatics : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        VideoTermino.terminoPrimeraVez = false;
        VideoTermino2.terminoPrimeraVez = false;
        Timer.derrota = false;
        Timer.victoria = false;
        Timer.pausa = false;
        ManagerPerillas.terminado = false;
        Pad2.terminado = false;
        CableCompletado.ganado = false;
        Alcantarilla.terminado = false;
}

    // Update is called once per frame
    void Update()
    {
        
    }
}
