using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float Force;
    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb.AddForce((transform.rotation * Vector3.forward) * Force);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
