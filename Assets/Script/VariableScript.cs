using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariableScript : MonoBehaviour{


    /*
     
     SECCIÓN DE VARIABLES 
      
    */
    public int number1 = 5;
    public int number2 = 8;


    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            AddtwoNumbers();
        }
    }

    void AddtwoNumbers()
    {
        Debug.Log(number1 + number2);
    }
}
