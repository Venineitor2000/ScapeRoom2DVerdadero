using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerMarcasPared : MonoBehaviour
{
    public AudioSource audioPared;
    bool a;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if(collision.tag == "Player")
        {
            if (!a)
            {
                audioPared.enabled = true;
                a = true;
            }
            
        }
    }
}
