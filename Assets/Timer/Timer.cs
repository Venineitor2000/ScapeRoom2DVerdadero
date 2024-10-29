using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Timer : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI textMeshPro;
    [SerializeField] float tiempo;
    public float tiempoAlIniciar;//Esto solo es para usarlo en otro script no le des un valor
    [SerializeField] GameObject canvasDerota;
    public static bool derrota;
    public static bool victoria;

    private void Awake()
    {
        tiempoAlIniciar = tiempo;
    }

    // Update is called once per frame
    void Update()
    {
        if (victoria)
            return;
        if(tiempo > 0)
        {
            tiempo -= Time.deltaTime;
            textMeshPro.text = Mathf.Round(tiempo).ToString() + "s";
        }

        else if(!derrota)
        {
            GameObject.FindGameObjectWithTag("Player").SetActive(false);
            foreach(var item in GameObject.FindGameObjectsWithTag("Interactuable"))
            {
                item.gameObject.SetActive(false);
            }    
            derrota = true;
            canvasDerota.SetActive(true);
        }
    }

    public float GetTime()
    {
        return tiempo;
    }
}
