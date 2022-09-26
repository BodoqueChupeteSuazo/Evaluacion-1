using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WP_Actor : MonoBehaviour
{
    public float speed = 5.0f;
    public Transform target;
    public int vida;
    public Puntaje_Manager pm;
    void Start()
    {
        transform.LookAt(new Vector3(target.position.x,transform.position.y,target.position.z));
    }

    void awake()
    {
        pm=FindObjectOfType<Puntaje_Manager>();
    }
    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(0, 0, speed * Time.deltaTime));
        if (vida <= 0) 
        {
            pm.puntaje++;
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag=="WayPoint")
        {
            target=other.gameObject.GetComponent<WayPoint>().nextPoint;
            transform.LookAt(new Vector3(target.position.x,transform.position.y,target.position.z));
        }
        if(other.tag=="Bala")
        {
            vida--;
           
        }
    }
        
}
