using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SpaceshipFly : MonoBehaviour
{
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
        
        if (wDown)
        {
            rb.AddForce(transform.forward * accelerationSpeed * 1000 * Time.deltaTime);
        }

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
