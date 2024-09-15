using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BouncePlatform : MonoBehaviour
{
    public bool canBounce = false;
    [SerializeField] float bounceForce;



    private void OnCollisionEnter(Collision collision)
    {
        //making sure only the player can bounce on the pad
        if (collision.gameObject.CompareTag("Player") && canBounce)
        {
            //bouncing the player forward based on the pads rotation
            collision.gameObject.GetComponent<Rigidbody>().AddForce(transform.forward * bounceForce, ForceMode.Impulse);
        }
    }


}
