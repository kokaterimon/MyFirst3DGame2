using System.Collections;
using UnityEngine;

public class Coin : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("El juego ha comenzado");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Estamos en el update");
    }


    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Algo ha colisionado con la moeda");
    }
}
