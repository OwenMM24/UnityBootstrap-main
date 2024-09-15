using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloatUI : MonoBehaviour
{
    Transform camera;

    // Start is called before the first frame update
    void Start()
    {
        //setting the players camera
        camera = Camera.main.transform;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //this makes the lock and key ui always face the players camera
        transform.rotation = Quaternion.LookRotation(transform.position - camera.transform.position);

    }
}
