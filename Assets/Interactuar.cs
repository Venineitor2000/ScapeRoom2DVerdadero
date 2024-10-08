using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactuar : MonoBehaviour
{
    [SerializeField] Canvas canvasInteractuar;
    bool playerDentroDeTrigger;
    bool Interactuable = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    

    void Interaccion()
    {
        if (GetComponent<SpriteRenderer>().color == Color.cyan)
        {
            GetComponent<SpriteRenderer>().color = Color.green;
        }
        else
        GetComponent<SpriteRenderer>().color = Color.cyan;
    }

   

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            if(Interactuable)
            {
                canvasInteractuar.gameObject.SetActive(true);
            }
            
            playerDentroDeTrigger = true;

        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            if(Interactuable)
            {
                canvasInteractuar.gameObject.SetActive(false);

            }

            playerDentroDeTrigger = false;
        }
    }

    private void Update()
    {

        if (playerDentroDeTrigger && Interactuable)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                Interaccion();
            }
        }
    }
        
    
    public void SetInteractuable(bool value)
    {
        Interactuable = value;
        if(!Interactuable && playerDentroDeTrigger)
        {
            canvasInteractuar.gameObject.SetActive(false);
        }
        else if(Interactuable && playerDentroDeTrigger)
        {
            canvasInteractuar.gameObject.SetActive(true);
        }
    }

    

}
