using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DestruirDontDestroy : MonoBehaviour
{
    public List<GameObject> objects;
    // Start is called before the first frame update
    

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AgregarObjeto(GameObject a)
    {
        objects.Add(a);
    }
    public void Destruir()
    {
        foreach (GameObject obj in objects) {
            if(obj != null) 
            Destroy(obj);
        }
        
        Destroy(gameObject);
    }
}
