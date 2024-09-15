using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    [SerializeField] GameObject lockObject;
    [SerializeField] GameObject bouncePad;


    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            //giving the player the key
            collision.gameObject.GetComponent<Inventory>().setKey();

            //unlocking the bounce pad
            bouncePad.gameObject.GetComponent<BouncePlatform>().canBounce = true;

            //destroy lock
            Destroy(lockObject);

            //destroy the key so we dont see it in the scene anymore
            Destroy(gameObject);
        }
    }

}
