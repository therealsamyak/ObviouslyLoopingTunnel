using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gold_Spawner: MonoBehaviour
{
    public GameObject Gold;
    public float startingXPosG = 50f;
    public float maxYPosForGold = 10f;
    public float minYPosForGold = 5f;
    public float minDistanceBetweenGold = 57;
    public float maxDistanceBetweenGold = 64;
    public float spawnTimeG = 100;
    private float spawnTimerG = 0;
    float delayG = 5f;
    float timerG = 0;

    private void Update()
    {

        spawnTimerG--;
        if (spawnTimerG <= 0)
        {
            SpawnGold();
            spawnTimerG = spawnTimeG;

            delayG = Random.Range(0.1f, 1.5f);
        }
    }

    private void SpawnGold()
    {
        if (timerG >= delayG)
        {
            
            timerG = 0;
            float yPos = Random.Range(minYPosForGold, maxYPosForGold);
            float distanceBetweenGold = Random.Range(minDistanceBetweenGold, maxDistanceBetweenGold);
            float newYPos = yPos + distanceBetweenGold;
            Instantiate(Gold, new Vector2(startingXPosG, newYPos), Quaternion.Euler(Vector3.forward * 1));
        }
        timerG += Time.deltaTime;

    }
}
