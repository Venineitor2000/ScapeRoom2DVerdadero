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
    public AudioSource audio2, audioError;
    bool desactivado;
    public static bool terminado; 
    private void Update()
    {
        if(terminado) return;
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
            audio2.Play();
            input.gameObject.SetActive(false);
        }

        else
        {
            //input.Select();
            //input.ActivateInputField();
            audioError.Play();
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

