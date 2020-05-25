using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Person {

    public string firtsName;
    public string lastName;
    public int age;
    public bool isMale;

    public Person spouse;

    //Constructor por defecto
    public Person()
    {

    }

    public Person(string pFirstName, string pLastName)
    {
        this.firtsName = pFirstName;
        this.lastName = pLastName;
    }

    public bool IsMarriedWith(Person otherPerson)
    {
        if (spouse == null)
        {
            return false;
            //aquí no está casado
        }else
        {
            if (otherPerson == this.spouse)
            {
                return true;
                //aquí está casado con otherPerson
            }
            else
            {
                return false;
                //aquí está casado pero no con otherPerson
            }
        }
    }

    public static void SayHello()
    {
        Debug.Log("Hola que tal!");
    }
}
