using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objeto : MonoBehaviour
{
    [SerializeField] float distanciaDesaparecer =.5f;
    [SerializeField] Transform player;
    [SerializeField] SpriteRenderer spriteRenderer;
    [SerializeField] Interactuar interactuar;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (player.transform.position.y - distanciaDesaparecer > transform.position.y)
        {
            spriteRenderer.enabled = false;
            interactuar.SetInteractuable(false);
        }

        else
        {
            spriteRenderer.enabled = true;
            interactuar.SetInteractuable(true);
        }
    }
}
