using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bala_Funcion : MonoBehaviour
{
   
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Enemigo")
        {
            Destroy(gameObject);
            
        }
    }

   
}
