using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectionsScript : MonoBehaviour{

    public string student1 = "Luke";
    public string student2 = "Leia";
    public string student3 = "Han";
    public string student4 = "Rey";
    public string student5 = "Kilo ren";

    //Todas las estructuras de datos, empiezan en la pocisión número 0
    //El último elemento de un array, es el de su dimensión -1


    /*
     * ARRAY
     * - Es homogéneo (solo un tipo de dato)
     * - Es de tamaño fijo (una vez creado, no puede contener más elementos)
    */

    public string[] students = new string[] { "Luke", "Leia", "Han", "Rey", "Kilo ren" };

    public string[] familyNames = new string[5];

    int[] numberOfDoorsInMyStreet = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 11 };

    private bool[] hasPassedTheExam = new bool[] { true, false, false, true };


    /*
     * LISTA
     * - Es homogéneo (solo un tipo de dato)
     * - Es de tamaño ajustable o variable (podemos más elementos en tiempo real y eliminarlos)
     * - Tiene un orden(se aceede por posición
    */

    public List<string> studentsNames = new List<string>();


    // Start is called before the first frame update
    void Start()
    {
        //ADD -> añade elementos a una lista
        //aquí, la lista está vacía
        studentsNames.Add("Luke");
        //aquí, la lista tiene un elemento, Luke
        studentsNames.Add("Leia");
        //aquí, la lista tiene dos elementos, Luke y Leia
        studentsNames.Add("Han");
        //aquí, la lista tiene tres elementos, Luke, Leia y Han
        studentsNames.Add("Rey");
        //aquí, la lista tiene tres elementos, Luke, Leia, Han y Rey
        studentsNames.Add("Kilo ren");
        //aquí, la lista tiene tres elementos, Luke, Leia, Han, Rey y Kilo ren
        studentsNames.Add("Jango");

        //Contains -> nos dice si la lista contiene o un objeto: true o false
        if (studentsNames.Contains("Jango"))
        {
            // Remove -> elimina de la lista
            studentsNames.Remove("Jango");
        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
