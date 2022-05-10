using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clonar : MonoBehaviour {

    public int clones;
    public int grados;
    public GameObject prefab;

    public void clonador()
    {
        GameObject clon;
        for (int i = 0; i < clones; i++)
        { 
        clon = Instantiate(prefab);
            clon.transform.Rotate(0, i * grados, 0);
            clon.transform.Translate(i, i, 0);
            //Detroy(clon, 1);
        }
    }
}
