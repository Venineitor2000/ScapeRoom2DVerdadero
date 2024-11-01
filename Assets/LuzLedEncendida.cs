using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LuzLedEncendida : MonoBehaviour
{
    private void OnDisable()
    {
        GetComponent<AudioSource>().enabled = false;
    }
}
