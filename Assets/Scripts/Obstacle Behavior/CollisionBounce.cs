using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionBounce : MonoBehaviour
{
    [SerializeField] float force;

    void OnCollisionEnter(Collision collision)
    {
        //making sure only the player can be moved
        if (collision.gameObject.CompareTag("Player"))
        {
            //reference to the players rigid body so we can use forces on it
            Rigidbody playerRB = collision.gameObject.GetComponent<Rigidbody>();

            //the direction to launch the player
            Vector3 forceDirection = (collision.transform.position - transform.position).normalized;

            //applying the force
            playerRB.AddForce(forceDirection * force, ForceMode.Impulse);
        }

    }
}
