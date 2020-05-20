using System.Collections;
using UnityEngine;

public class Coin : MonoBehaviour{


    public static int coinsCount = 0;

    // Start is called before the first frame update
    void Start()
    {
        Coin.coinsCount++;
        Debug.Log("El juego ha comenzado y ahora hay" + Coin.coinsCount + ("monedas"));
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("Estamos en el update");
    }


    private void OnTriggerEnter(Collider otherCollirder)
    {
        if (otherCollirder.CompareTag("Player") == true)
        {
            
            Coin.coinsCount--;

            Debug.Log("Hemos recogido la moneda y ahora hay" + Coin.coinsCount + ("monedas"));

            if (Coin.coinsCount == 0)
            {
                Debug.Log("El juego ha terminado");

                GameObject gameManager = GameObject.Find("GameManager");

                Destroy(gameManager);

                GameObject[] fireworksSystem = GameObject.FindGameObjectsWithTag("Fireworks");

                foreach(GameObject fireworks in fireworksSystem)
                {
                    fireworks.GetComponent<ParticleSystem>().Play();
                }
            }

            Destroy(gameObject);
        }
    }
}
