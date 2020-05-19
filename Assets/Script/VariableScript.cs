using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariableScript : MonoBehaviour{


    /*
     
     SECCIÓN DE VARIABLES 
      
    */
    public int myNumber = 30;
    public int total;


    // Start is called before the first frame update
    void Start()
    {
        total = myNumber - 5;// total = 25
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
