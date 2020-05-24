using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopsScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        /*
         * FOREACH -> iterar sobre los elementos de una colección
         *  foreach(Typeelement in collection)
         *  {
         *     //Código del bucle
         *  }
        */
        List<string> studentsNames = new List<string>();
        studentsNames.Add("Luke");
        studentsNames.Add("Leia");
        studentsNames.Add("Han");
        studentsNames.Add("Rey");
        studentsNames.Add("Kilo Ren");

        Debug.Log("IMPRIMIENDO CON FOREACH");
        foreach (string person in studentsNames)
        {
            Debug.Log(person);
        }

        int[] someInts = new int[] { 4, 8, 3, 0, 9, 6, 8, 7 };
        int sum = 0;
        int n = someInts.Length;
        foreach (int i in someInts)
        {
            sum = sum + i;
            Debug.Log("La suma vale ahora: " + sum);
        }

        Debug.Log("La media de los números vale: " + sum / n);

        /*
         * FOR -> acceder a posiciones
         * for(inicialización; condición de continuación; iterador)
         * {
         *     //Código del bucle 
         * }
         */

        Debug.Log("IMPRIMIENDO CON EL FOR");
        for (int i = 1; i <= 10; i++)
        {
            Debug.Log(i);
        }

        Debug.Log("CUENTA ATRÁS CON EL FOR");
        for (int j = 10; j >= 0; j--)
        {
            Debug.Log(j);
        }

        for (int pos = 0; pos < studentsNames.Count; pos++)
        {
            string name = studentsNames[pos];
            Debug.Log("El elemento número " + pos + " de la lista es " + studentsNames[pos]);
        }

        /*
         * WHILE
         * Inicialización
         * while(condición de continuación)
         * {
         *  //Código a ejecutar
         *  iterador
         * }
         *  La bariable de bucle sigue existiendo después...
         */

        Debug.Log("CONTAR DE 1 a 10 CON BUCLE WHILE");
        int counter = 1;
        while (counter <= 10)
        {
            Debug.Log(counter);
            counter++;
        }

        bool isRainig = false;
        while (!isRainig)
        {
            //ir a la playa
            //controlar si llueve
            isRainig = true;
        }


        for (int i = 0; i < 100; i++)
        {
            if (i == 0)
            {
                Debug.Log("El número cero es especial...");
            } else if (IsNumberEven(i))
            {
                Debug.Log("El número " + i + " es par.");
            } else
            {
                Debug.Log("El número " + i + " es impar.");
            }
        }

        Debug.Log("Números primos");

        int number = 42;
        bool isPrime = true;
        for(int i = 2; i < number; i++)
        {
            int remaider = number % i;
            if(number % i == 0)
            {
                isPrime = false;
            }
        }
        if (isPrime)
        {
            Debug.Log("El número " + number + " es primo.");
        }
        /*else
        {
            Debug.Log("El número " + number + " es compuesto.");
        }*/

    }

    Debug.Log("Algoritmos de búsqueda");

    public bool IsNumberEven(int number)
    {
        //int quotient = number / 2;
        int remainder = number % 2;

        if (remainder == 0)
        {
            return true;
        }else
        {
            return false;
        }

    }

  
}       
 