using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] float speed;

    private void Awake()
    {
        //start timer to destroy self
        StartCoroutine(DestroySelf());
    }


    // Update is called once per frame
    void FixedUpdate()
    {
        //moving projectile forward on its local axis because the spawner in at an angle
        transform.position += transform.TransformDirection(Vector3.fwd) * speed;
    }


    IEnumerator DestroySelf()
    {
        //after 4 seconds destroy game object so projectiles dont spawn infinitely
        yield return new WaitForSeconds(4);
        Destroy(gameObject);   
    }

}
