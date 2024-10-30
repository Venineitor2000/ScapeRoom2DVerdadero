using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Pad2 : MonoBehaviour
{
    [SerializeField] string valor;
    [SerializeField] AutoSelectPad autoSelect;
    [SerializeField] GameObject animacionPuerta;
    [SerializeField] TMP_InputField input;
    bool desactivado;
    public static bool terminado; 
    private void Update()
    {
        if (ManagerPerillas.terminado)
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
        if (Validar())
        {
            terminado = true;
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

