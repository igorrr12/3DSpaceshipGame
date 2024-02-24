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
    public Transform Gun1;
    public Transform Gun2;
    public GameObject bullet;


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
        if (Input.GetKey(KeyCode.A))
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


        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(bullet, Gun1.transform.position, Gun1.transform.rotation);
            Instantiate(bullet, Gun2.transform.position, Gun2.transform.rotation);
        }
    }

    void FixedUpdate()
    {
       
       

    }
}
