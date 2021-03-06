﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Family : MonoBehaviour{

    public Person father;
    public Person mother;
    public Person son;
    public Person daughter;

    // Start is called before the first frame update
    void Start()
    {
        father = new Person("Anakin", "Skywalker");//Instancir
        //después de instanciar podemos inicializar las vriables
        father.age = 35;
        father.isMale = true;
        
        mother = new Person("Padme", "Amidala", 28, false);

        father.spouse = mother;
        mother.spouse = father;

        son = new Person("Luke", "Skywalker");        
        son.age = 8;
        son.isMale = true;        

        daughter = new Person("Leia", "Amidala", 8, false);

        son.spouse = null;

        Debug.Log(father.getFirstName() + " y " + mother.getFirstName() + " tiene un hijo llamado " + son.getFirstName() + " y una hija llamada " + daughter.getFirstName());

        if (father.IsMarriedWith(mother))
        {
            Debug.Log(father.getFirstName() + " y " + mother.getFirstName() + " están casados");
        }else
        {
            Debug.Log(father.getFirstName() + " y " + mother.getFirstName() + " no están casados");
        }

        Person.SayHello();        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
