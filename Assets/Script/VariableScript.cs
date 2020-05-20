using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariableScript : MonoBehaviour{


    /*
     
     SECCIÓN DE VARIABLES 
      
    */
    public int number1 = 5;
    public int number2 = 8;

    private void Awake()
    {
        Debug.Log("El objeto ha despertado");
    }

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("El objeto ha arrancado");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("El objeto se está actualizando");
        
        if (Input.GetKeyDown(KeyCode.Return))
        {
            AddtwoNumbers();
        }
    }

    private void FixedUpdate()
    {
        Debug.Log(Time.time);
    }

    void AddtwoNumbers()
    {
        Debug.Log(number1 + number2);
    }
}
