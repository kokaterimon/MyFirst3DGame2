using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Family : MonoBehaviour{

    public Person father;
    public Person mother;
    public Person son;

    // Start is called before the first frame update
    void Start()
    {
        father = new Person();//Instancir
        father.firtsName = "Anakin";
        father.lastName = "Skywalker";
        father.age = 35;
        father.isMale = true;
        father.isMarried = true;

        mother = new Person();
        mother.firtsName = "Padme";
        mother.lastName = "Amidala";
        mother.age = 28;
        mother.isMale = false;
        mother.isMarried = true;

        son = new Person();
        son.firtsName = "Luke";
        son.lastName = "Skywalker";
        son.age = 8;
        son.isMale = true;
        son.isMarried = false;


        Debug.Log(father.firtsName + " y " + mother.firtsName + " tiene un hijo llamado " + son.firtsName);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
