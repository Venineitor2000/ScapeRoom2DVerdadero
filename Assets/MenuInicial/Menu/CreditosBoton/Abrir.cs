using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Abrir : MonoBehaviour
{
    public Canvas canvasAbrir, canvasCerrar;

    public void Open()
    {
        canvasCerrar.enabled = false;
        canvasAbrir.enabled = true;
    }
}
