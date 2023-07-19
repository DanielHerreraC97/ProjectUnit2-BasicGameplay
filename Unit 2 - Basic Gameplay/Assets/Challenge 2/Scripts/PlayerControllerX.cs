using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    public float spawnInterval = 2.0f;  // Time interval between dog spawns
    private float lastSpawnTime = 0.0f;  // Time of the last dog spawn

    // Update is called once per frame
    void Update()
    {
        // Check if enough time has passed since the last spawn
        if (Time.time - lastSpawnTime >= spawnInterval)
        {
            // On spacebar press, send dog and update the last spawn time
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
                lastSpawnTime = Time.time;
            }
        }
    }
}
