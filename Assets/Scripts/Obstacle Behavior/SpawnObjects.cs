using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObjects : MonoBehaviour
{
    [SerializeField] float spawnTime;
    [SerializeField] GameObject projectile;

    // Start is called before the first frame update
    void Start()
    {
        //as soon as the scene starts we can start spawning projectiles
        StartCoroutine(SpawnObject());
    }


    IEnumerator SpawnObject()
    {
        while (true)
        {
            //spawn the projectile prefab
            Instantiate(projectile, transform.position, transform.rotation);
            //wait a chosen amount of time to spawn another projectile
            yield return new WaitForSeconds(spawnTime);
        }
    }

}
