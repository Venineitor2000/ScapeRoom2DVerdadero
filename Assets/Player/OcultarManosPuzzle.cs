using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OcultarManosPuzzle : MonoBehaviour
{
    [SerializeField] SpriteRenderer manos;
    [SerializeField] SpriteMask linterna;
    // Start is called before the first frame update
    public void Ocultar()
    {
        manos.enabled = false;
        linterna.enabled = false;
    }

    public void Desocultar()
    {
        manos.enabled = true;
        linterna.enabled = true;
    }
}
