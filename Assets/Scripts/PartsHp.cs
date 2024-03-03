using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PartsHp : MonoBehaviour
{
    public int hp;
    public int maxHp;
    public bool pass;
    public bool destory;
    public bool isWorking =true;
    public Transform reference;
    public AudioSource hit;
    public AudioSource kill;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = reference.transform.position;
        transform.rotation = reference.transform.rotation;
        if ( hp <= 0)
        {
            //kill.Play();
            if (destory)
            {
                Destroy(gameObject);
            }
            GetComponent<Collider>().isTrigger = true;
            isWorking = false;
        }
    }
    private void OnCollisionEnter(Collision other)
    {
        //print("hit");
        print(other.gameObject.name);
        if (other.gameObject.name.StartsWith("Dm"))
        {
            hit.Play();
            Destroy(other.gameObject);
            //print("ok");
            hp = hp - 100;
        }
    }
}
