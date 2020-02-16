using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn_Manager : MonoBehaviour
{
    public GameObject Spike;
    public float startingXPos = 50f;
    public float maxYPosForBottomSpikes = 10f;
    public float minYPosForBottomSpikes = 5f;
    public float minDistanceBetweenSpikes = 57;
    public float maxDistanceBetweenSpikes = 64;
    public float spawnTime = 100;
    private float spawnTimer = 0;
    float delay = 5f;
    float timer = 0;

    private void Update()
    {
        spawnTimer--;
        if (spawnTimer <= 0)
        {
            SpawnSpikes();
            spawnTimer = spawnTime;
            ;

            delay = Random.Range(5f, 15f);
            ;
        }
    }

    private void SpawnSpikes()
    {
        if (timer >= delay)
        {
            timer = 0;
            float yPos = Random.Range(minYPosForBottomSpikes, maxYPosForBottomSpikes);
            GameObject newSpike = Instantiate(Spike, new Vector2(startingXPos, yPos), Quaternion.identity);
            float distanceBetweenSpikes = Random.Range(minDistanceBetweenSpikes, maxDistanceBetweenSpikes);
            float newYPos = yPos + distanceBetweenSpikes;
            Instantiate(Spike, new Vector2(startingXPos, newYPos), Quaternion.Euler(Vector3.forward * 1));

        }
        timer += Time.deltaTime;

  
    }
}
