using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Interactuar : MonoBehaviour
{
    [SerializeField] Canvas canvasInteractuar;
    [SerializeField] SpriteRenderer spriteRenderer;
    Canvas canvasObjeto;//Si tenes este se basa en canvas
    public GameObject objeto;//Si tenes este es por que el puzzle se basa en sprites
    GameObject player;
    bool playerDentroDeTrigger;
    bool Interactuable = true;
    bool canvasObjetoAbierto;
    [SerializeField] float distanciaTextoInteractuar = 100;
    
    // Start is called before the first frame update
    void Start()
    {
            if(objeto == null)
                canvasObjeto = GetComponentInChildren<Canvas>(true);
        
        player = GameObject.FindGameObjectWithTag("Player");
    }

    

    void Interaccion()
    {
        if(!canvasObjetoAbierto)
        {
            
            canvasObjetoAbierto = true;
            
            canvasInteractuar.gameObject.SetActive(false);
            if (objeto == null)
                canvasObjeto.gameObject.SetActive(true);
            if(objeto != null) 
                objeto.SetActive(true);
            player.GetComponent<Movimiento>().Detener();

            if(objeto == null)
            {
                RectTransform contenedorRectTransform = canvasObjeto.transform.Find("Contenedor").GetComponent<RectTransform>();
                Vector3 screenPosition = Camera.main.WorldToScreenPoint(transform.position);
                Vector2 localPoint;
                RectTransformUtility.ScreenPointToLocalPointInRectangle(canvasObjeto.GetComponent<RectTransform>(), screenPosition, canvasObjeto.worldCamera, out localPoint);
                contenedorRectTransform.anchoredPosition = new Vector2(localPoint.x, contenedorRectTransform.anchoredPosition.y);

            }

            player.GetComponent<OcultarManosPuzzle>().Ocultar();
        }

        else
        {
            canvasObjetoAbierto = false;
            canvasInteractuar.gameObject.SetActive(true);
            if(objeto == null)
                canvasObjeto.gameObject.SetActive(false);
            if(objeto != null)
                objeto.SetActive(false );
            if(player != null)
            {
                player.GetComponent<Movimiento>().ReanudarMovimiento();
                player.GetComponent<OcultarManosPuzzle>().Desocultar();
            }
            
        }
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
        else if(Interactuable && playerDentroDeTrigger && !canvasObjetoAbierto)
        {
            //Obtengo el punto mas alto del sprite
            Bounds spriteBounds = spriteRenderer.bounds;
            float topY = spriteBounds.max.y;

            //Creo el nuevo Vector tomando en cuenta X del transform y Y del sprite mas alto
            Vector2 posicion = new Vector2(transform.position.x, topY);

            RectTransform textoRectTransform = canvasInteractuar.transform.Find("Texto").GetComponent<RectTransform>();
            Vector3 screenPosition = Camera.main.WorldToScreenPoint(posicion);
            Vector2 localPoint;
            RectTransformUtility.ScreenPointToLocalPointInRectangle(canvasInteractuar.GetComponent<RectTransform>(), screenPosition, canvasInteractuar.worldCamera, out localPoint);
            textoRectTransform.anchoredPosition = new Vector2(localPoint.x, localPoint.y + distanciaTextoInteractuar);
            canvasInteractuar.gameObject.SetActive(true);
        }
    }

    

}
