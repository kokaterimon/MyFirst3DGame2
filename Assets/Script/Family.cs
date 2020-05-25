using System.Collections;
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
        father = new Person();//Instancir
        //después de instanciar podemos inicializar las vriables
        father.firtsName = "Anakin";
        father.lastName = "Skywalker";
        father.age = 35;
        father.isMale = true;
        
        mother = new Person();
        mother.firtsName = "Padme";
        mother.lastName = "Amidala";
        mother.age = 28;
        mother.isMale = false;

        father.spouse = mother;
        mother.spouse = father;

        son = new Person();
        son.firtsName = "Luke";
        son.lastName = "Skywalker";
        son.age = 8;
        son.isMale = true;        

        daughter = new Person();
        daughter.firtsName = "Leia";
        daughter.lastName = "Organa";
        daughter.age = 8;
        daughter.isMale = false;

        son.spouse = null;

        Debug.Log(father.firtsName + " y " + mother.firtsName + " tiene un hijo llamado " + son.firtsName + " y una hija llamada " + daughter.firtsName);

        if (father.IsMarriedWith(mother))
        {
            Debug.Log(father.firtsName + " y " + mother.firtsName + " están casados");
        }else
        {
            Debug.Log(father.firtsName + " y " + mother.firtsName + " no están casados");
        }

        Person.SayHello();        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
