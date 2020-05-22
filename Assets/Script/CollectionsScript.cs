using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectionsScript : MonoBehaviour{

    public string student1 = "Luke";
    public string student2 = "Leia";
    public string student3 = "Han";
    public string student4 = "Rey";
    public string student5 = "Kilo Ren";

    //Todas las estructuras de datos, empiezan en la pocisión número 0
    //El último elemento de un array, es el de su dimensión -1


    /*
     * ARRAY
     * - Es homogéneo (solo un tipo de dato)
     * - Es de tamaño fijo (una vez creado, no puede contener más elementos)
     * - Tiene un orden(se aceede por posición)
    */

    public string[] studentsArray = new string[] { "Luke", "Leia", "Han", "Rey", "Kilo Ren" };

    public string[] familyNames = new string[5];

    int[] numberOfDoorsInMyStreet = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 11 };

    private bool[] hasPassedTheExam = new bool[] { true, false, false, true };


    /*
     *   LISTA
     * - Es homogéneo (solo un tipo de dato)
     * - Es de tamaño ajustable o variable (podemos más elementos en tiempo real y eliminarlos)
     * - Tiene un orden(se aceede por posición)
    */

    public List<string> studentsNames = new List<string>();


    // Start is called before the first frame update
    void Start()
    {
        //ADD -> añade elementos al final de la lista
        //aquí, la lista está vacía

        studentsNames.Add("Luke");        
        //aquí, la lista tiene un elemento, Luke

        studentsNames.Add("Leia");        
        //aquí, la lista tiene dos elementos, Luke y Leia

        studentsNames.Add("Han");        
        //aquí, la lista tiene tres elementos, Luke, Leia y Han

        studentsNames.Add("Rey");
        
        //aquí, la lista tiene tres elementos, Luke, Leia, Han y Rey

        studentsNames.Add("Kilo Ren");        
        //aquí, la lista tiene cutro elementos, Luke, Leia, Han, Rey y Kilo Ren

        studentsNames.Add("Jango");        
        //aquí, la lista tiene cutro elementos, Luke, Leia, Han, Rey, Kilo Ren y Jango

        //Contains -> nos dice si la lista contiene o un objeto: true o false
        if (studentsNames.Contains("Jango"))
        {
            // Remove -> elimina de la lista
            studentsNames.Remove("Jango");
        }
        
        studentsNames.Insert(2, "Boba");
        //ahora el orden es Luke, Leia, Boba, Han, Rey, Kilo Ren
        
        //ToArray() -> Convierte una lista en un Array
        string[] studentsNamesToArray = studentsNames.ToArray();

        //Clear -> Eliminar definitivamente todos los elementos de la lista
        //studentsNames.Clear();
        //ahora el Array está vacía [];

        Debug.Log("El primer estudiante del array:"+studentsArray[0]);//El primer estudiante del array

        string thirdStudent = studentsNames[2];//El tercer estudiante de la lista
        Debug.Log("El tercer estudiante de la lista:"+thirdStudent);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
