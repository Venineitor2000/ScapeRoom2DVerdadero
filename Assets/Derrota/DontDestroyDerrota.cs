using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroyDerrota : MonoBehaviour
{
    [SerializeField] GameObject derrota;
        private void Awake()
    {
        DontDestroyOnLoad(derrota);
    }
    
}
