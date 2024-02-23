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
    private bool wDown, wUp;
    private bool sDown, sUp;

    // Start is called before the first frame update
    void Start()
    {
        
    }


    void Update()
    {
        //obrót nie kfestcionuj jak dzia³a bo sam niewiem.
        rotation = Pointer.GetComponent<Poiter>().Ofset;
        transform.Rotate(new Vector3(rotation.y / 200, rotation.x / -200, 0));
        if (Input.GetKeyDown(KeyCode.W))
        {
            wDown = true;
        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            wDown = false;
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
        
        if (wDown)
        {
            rb.AddForce(transform.forward * accelerationSpeed * 1000 * Time.deltaTime);
        }

            sDown = true;
        }
        if (Input.GetKeyUp(KeyCode.S))
        {
            sDown = false;
        }
        Debug.Log(rb.velocity);
   
    }

    void FixedUpdate()
    {
       
        if (sDown)
        {
            if (rb.velocity.x > 0 || rb.velocity.z > 0) 
            {
                rb.AddForce(-transform.forward * 1000 * brakeSpeed * Time.deltaTime);
            }
        }

        rb.velocity = Vector3.ClampMagnitude(rb.velocity, maxSpeed);

    }
}
