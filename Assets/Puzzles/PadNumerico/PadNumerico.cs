using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PadNumerico : MonoBehaviour
{
    [SerializeField] string valor;
    [SerializeField] AutoSelectPad autoSelect;
    [SerializeField] GameObject animacionPuerta;
    [SerializeField] TMP_InputField input;
    bool desactivado;
    private void Update()
    {
        if(CableCompletado.ganado)
        {
            input.gameObject.SetActive(true);
            ActivarInput();
        }
            
        else
        {
            input.gameObject.SetActive(false);
        }
    }

    public void Interactuar()
    {
        if (Timer.derrota)
            return;
            if(Validar())
            {
                animacionPuerta.SetActive(true);
                GameObject.FindGameObjectWithTag("Player").SetActive(false);
            foreach (var item in GameObject.FindGameObjectsWithTag("Interactuable"))
            {

                item.gameObject.SetActive(false);
            }
            }

            else
            {
                //input.Select();
                //input.ActivateInputField();
                input.text = "";
            }
        
    }

    void ActivarInput()
    {
        input.Select();
        input.ActivateInputField();
    }

    bool Validar()
    {
        return input.text == valor;
    }
}

