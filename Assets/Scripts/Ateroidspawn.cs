using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ateroidspawn : MonoBehaviour
{
    public GameObject a1;
    public GameObject a2;
    public GameObject a3;
    public GameObject a4;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 1000; i++)
        {
            int x = Random.Range(0, 4);
            if (x == 1)
            {
                GameObject newObject = Instantiate(a1, new Vector3(Random.Range(-500, 500), Random.Range(-500, 500), Random.Range(-500, 500)), Quaternion.Euler(Random.Range(-360, 360), Random.Range(-360, 360), Random.Range(-360, 360)));
                newObject.transform.localScale = new Vector3(Random.Range(0.5f, 5), Random.Range(0.5f, 5), Random.Range(0.5f, 5));
            }
            if (x == 2)
            {
                GameObject newObject = Instantiate(a2, new Vector3(Random.Range(-500, 500), Random.Range(-500, 500), Random.Range(-500, 500)), Quaternion.Euler(Random.Range(-360, 360), Random.Range(-360, 360), Random.Range(-360, 360)));
            }
            if (x == 3)
            {
                GameObject newObject = Instantiate(a3, new Vector3(Random.Range(-500, 500), Random.Range(-500, 500), Random.Range(-500, 500)), Quaternion.Euler(Random.Range(-360, 360), Random.Range(-360, 360), Random.Range(-360, 360)));
            }
            if (x == 0)
            {
                GameObject newObject = Instantiate(a4, new Vector3(Random.Range(-500, 500), Random.Range(-500, 500), Random.Range(-500, 500)), Quaternion.Euler(Random.Range(-360, 360), Random.Range(-360, 360), Random.Range(-360, 360)));
            }

        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
