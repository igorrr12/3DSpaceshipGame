using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HpIlustrator : MonoBehaviour
{
    new float hp;
    new float maxHp;
    public GameObject reference;
    new float czas;
    // Start is called before the first frame update
    void Start()
    {
        maxHp = reference.GetComponent<PartsHp>().maxHp;
    }

    // Update is called once per frame
    void Update()
    {
        czas = czas + Time.deltaTime;
        hp = reference.GetComponent<PartsHp>().hp;
        hp = (hp / maxHp) * 100;
        print("hp"+hp);
        GetComponent<Image>().color = new Color(250 - (hp*2.5f), 0, 0);
        print("clolor" + (250 - (hp * 2.5f)));

    }
}
