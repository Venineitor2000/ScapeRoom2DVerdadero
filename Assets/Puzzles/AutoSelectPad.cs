using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class AutoSelectPad : MonoBehaviour
{
    // El transform del objeto UI que deseas seleccionar
    [SerializeField] TMP_InputField input;

    void OnEnable()
    {
        Select();
    }

    public void Select()
    {
        StartCoroutine(SelectInputField());
    }

    private IEnumerator SelectInputField()
    {
        // Espera un frame para asegurarte de que el sistema de entrada esté listo
        yield return null;
        input.Select();
        input.ActivateInputField(); // Activa el campo para que esté listo para la entrada
    }
}
