using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Impact : MonoBehaviour
{
    public GameObject enemy;
    private Rigidbody rb;

    public float forceX;
    public float forceZ;
    
    public float force;
    
    
    // Start is called before the first frame update
    void Start()
    {
        rb = enemy.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

   

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
           rb.AddForce(forceX, force , forceZ);
        }
    }
}
