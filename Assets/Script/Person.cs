using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Person {

    private string firtsName;
    private string lastName;
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

    public Person(string firstName, string lastName, int age, bool isMale)
    {
        this.firtsName = firstName;
        this.lastName = lastName;
        this.age = age;
        this.isMale = isMale;
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

    /*SETTERS Y GETTERS*/
    public void setFirstName(string firstName)
    {
        this.firtsName = firstName;
    }
    public void setLastName(string lastName)
    {
        this.lastName = lastName;
    }

    public string getFirstName()
    {
        return this.firtsName;
    }
    public string getLastName()
    {
        return this.lastName;
    }
}
