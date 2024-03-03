using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret : MonoBehaviour
{
    public GameObject target;
    public GameObject bullet;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(target.transform, Vector3.left);
        if (Input.GetMouseButtonDown(1))
        {
            Instantiate(bullet, transform.position, transform.rotation);
            
        }
    }
}
