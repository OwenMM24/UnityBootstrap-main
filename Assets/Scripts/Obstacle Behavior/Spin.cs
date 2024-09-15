using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spin : MonoBehaviour
{
    [SerializeField] float xSpeed;
    [SerializeField] float ySpeed;
    [SerializeField] float zSpeed;

    // Update is called once per frame
    void FixedUpdate()
    {
        //rotates the object the script is on, there are 3 variables so it can be adjusted exactly how the object will rotate
        transform.eulerAngles = transform.eulerAngles + new Vector3(xSpeed * Time.deltaTime, ySpeed * Time.deltaTime, zSpeed*Time.deltaTime);
    }
}
