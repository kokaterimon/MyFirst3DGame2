using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectionsScript : MonoBehaviour{

    public string student1 = "Anakin";
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

    public string[] studentsArray = new string[] { "Anakin", "Leia", "Han", "Rey", "Kilo Ren" };

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

    /*
      * ARRAYLIST
      * -Es heterogéneo (pude guardar diferentes tipos de datos en la misma estructura)
      * - Es de tamaño ajustable o variable (podemos más elementos en tiempo real y eliminarlos) 
      * - Tiene un orden(se aceede por posición)
    */

    public ArrayList inventory = new ArrayList();

    /*
     * DICCIONARIO <-HASHTABLE>
     * -se puede redimensionar dinámicamente (igual que una lista)
     * -puede contener información heterogena (podemos añadir más elementos en tiempo real y eliminarlos)
     * -Tiene un orden (se accede por posición)
    */

    public Hashtable personalDetails = new Hashtable();

    // Start is called before the first frame update
    void Start()
    {
        //ADD -> añade elementos al final de la lista
        //aquí, la lista está vacía

        studentsNames.Add("Anakin");
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

        
        //Acceso a arrays y tamaño del mismo
        Debug.Log("El tamaño del array de es : "+studentsArray.Length);

        int pos = 0;

        if (pos >= 06 && pos < studentsArray.Length)
        {
            Debug.Log("El primer estudiante del array:" + studentsArray[pos]);//El primer estudiante del array
        }


        //Acceso a lista y tamaño de las mismas
        Debug.Log("El tamaño de la lista de estudiantes es : " + studentsNames.Count);

        pos = 2;

        if (pos >= 0 && pos < studentsNames.Count)
        {
            string thirdStudent = studentsNames[pos];//El tercer estudiante de la lista
            Debug.Log("El tercer estudiante de la lista : " + thirdStudent);
        }


        inventory.Add(30);
        inventory.Add(3.14159265);
        inventory.Add("Luke Skywalker");
        inventory.Add(false);
        inventory.Add(GameObject.FindGameObjectsWithTag("Fireworks"));

        //Pedimos el tipo de dato que va a salir de la arraylist)
        Debug.Log(inventory[2].GetType());
        Debug.Log(inventory[4].GetType());


        personalDetails.Add("firstName",   "Luke Skywalker");
        personalDetails.Add("lastName",    "Paucar");
        personalDetails.Add("age",         10);
        personalDetails.Add("gender",      "male");
        personalDetails.Add("isMarried",   false);
        personalDetails.Add("hasChildren", false);

        if (personalDetails.Contains("firstName") && personalDetails.Contains("age"))
        {
            string name = (string)personalDetails["DNI"];
            int age = (int)personalDetails["age"];

            Debug.Log(personalDetails[name]);
        }else
        {
            Debug.Log("El diccionario no contiene las claves que se han pedido");
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
