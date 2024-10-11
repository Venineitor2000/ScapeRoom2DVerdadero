using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
public class AjustarPosicionManos : MonoBehaviour
{
    public Transform manos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Bounds bound = CameraExtensions.OrthographicBounds(Camera.main);
        manos.position = new Vector2(manos.position.x, bound.min.y);
    }
}
