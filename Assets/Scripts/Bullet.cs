using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public int demage;
    public float Force;
    public Rigidbody rb;
    float czas;
    Transform start;
    // Start is called before the first frame update
    void Start()
    {
        rb.AddForce((transform.rotation * Vector3.forward) * Force);
        start.position = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        czas += Time.deltaTime;
        if(czas >= 5)
        {
            print(Vector3.Distance(start.position, transform.position));
            if (gameObject.name.EndsWith("clone"))
            {
                Destroy(gameObject);
            }
            if (gameObject.name.EndsWith("Clone"))
            {
                Destroy(gameObject);
            }

        }
        
    }
    
}
