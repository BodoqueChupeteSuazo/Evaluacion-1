using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puntaje_Manager : MonoBehaviour
{
    public int puntaje;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(puntaje_actualizado());
    }
    void puntaje1()
    {
        Debug.Log(puntaje);
    }
    IEnumerator puntaje_actualizado()
    {
        puntaje1();
        yield return new WaitForSeconds(3f);
        StartCoroutine(puntaje_actualizado());
    }

    
}
