using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using Unity.VisualScripting;
using UnityEngine;

public class SpaceshipFly : MonoBehaviour
{
    public GameObject Pointer;
    Vector3 rotation;
    public float maxSpeed;
    public float accelerationSpeed;
    public float brakeSpeed;
    public Rigidbody rb;
    public float Spead;

    // Start is called before the first frame update
    void Start()
    {
        
    }


    void Update()
    {
        //obrót nie kfestcionuj jak dzia³a bo sam niewiem.
        rotation = Pointer.GetComponent<Poiter>().Ofset;
        transform.Rotate(new Vector3(rotation.y / 200, rotation.x / -200, 0));
        if (Input.GetKey(KeyCode.W))
        {
            rb.AddForce((transform.rotation * Vector3.forward) * Spead);
        }
        if (Input.GetKey(KeyCode.S))
        {
            rb.AddForce((transform.rotation * Vector3.back) * Spead);
        }
        if (Input.GetKey(KeyCode.a))
        {
            rb.AddForce((transform.rotation * Vector3.left) * Spead);
        }
        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce((transform.rotation * Vector3.right) * Spead);
        }

        if (Input.GetKey(KeyCode.Space))
        {
            rb.AddForce((transform.rotation * Vector3.up) * Spead);
        }
        if (Input.GetKey(KeyCode.LeftControl))
        {
            rb.AddForce((transform.rotation * Vector3.down) * Spead);
        }
    }

    void FixedUpdate()
    {
       
       

    }
}
