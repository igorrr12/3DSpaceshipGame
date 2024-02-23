using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Poiter:MonoBehaviour
{
    public Vector3 Mouse;
    public Vector3 Center;
    public Vector3 Ofset;

    // Start is called before the first frame update
    void Start()
    {
        Center = new Vector3(Screen.width / 2, Screen.height / 2, 0);
    }

    // Update is called once per frame
    void Update()
    {
        Mouse = Input.mousePosition;
        Ofset = Center - Mouse;
    }
}
