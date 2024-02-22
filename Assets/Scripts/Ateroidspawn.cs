using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;

public class Ateroidspawn : MonoBehaviour
{
    public GameObject a1;
    public GameObject a2;
    public GameObject a3;
    public GameObject a4;
    public int numberOfAsteroids; //ile asteroid !!! Nie rób nigdy bez zmiennych, bo tu zrobiłeś po prostu '1000' a nie dałeś zmiennej !!!
    public int sizeOfSpawn; //Jak szerokie, długie i wysokie ma być pole gdzie się spawnują asteroidy. 
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < numberOfAsteroids; i++)
        {
            int x = Random.Range(0, 4);
            if (x == 1)
            {
                GameObject newObject = Instantiate(a1, new Vector3(Random.Range(-sizeOfSpawn, sizeOfSpawn), Random.Range(-sizeOfSpawn, sizeOfSpawn), Random.Range(-sizeOfSpawn, sizeOfSpawn)), Quaternion.Euler(Random.Range(-360, 360), Random.Range(-360, 360), Random.Range(-360, 360)));
                newObject.transform.localScale = new Vector3(Random.Range(0.5f, 5), Random.Range(0.5f, 5), Random.Range(0.5f, 5)); //Tylko ten będzie się zwężał lub rozszeżał
            }
            if (x == 2)
            {
                GameObject newObject1 = Instantiate(a1, new Vector3(Random.Range(-sizeOfSpawn, sizeOfSpawn), Random.Range(-sizeOfSpawn, sizeOfSpawn), Random.Range(-sizeOfSpawn, sizeOfSpawn)), Quaternion.Euler(Random.Range(-360, 360), Random.Range(-360, 360), Random.Range(-360, 360)));
            }
            if (x == 3)
            {
                GameObject newObject2 = Instantiate(a1, new Vector3(Random.Range(-sizeOfSpawn, sizeOfSpawn), Random.Range(-sizeOfSpawn, sizeOfSpawn), Random.Range(-sizeOfSpawn, sizeOfSpawn)), Quaternion.Euler(Random.Range(-360, 360), Random.Range(-360, 360), Random.Range(-360, 360)));
            }
            if (x == 0)
            {
                GameObject newObject3 = Instantiate(a1, new Vector3(Random.Range(-sizeOfSpawn, sizeOfSpawn), Random.Range(-sizeOfSpawn, sizeOfSpawn), Random.Range(-sizeOfSpawn, sizeOfSpawn)), Quaternion.Euler(Random.Range(-360, 360), Random.Range(-360, 360), Random.Range(-360, 360)));
            }

        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
