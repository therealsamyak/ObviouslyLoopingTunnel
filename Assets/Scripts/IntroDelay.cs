using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntroDelay : MonoBehaviour
{
    public GameObject goldSpawn;
    public GameObject spikeSpawn;
    public GameObject introCam;
    public GameObject mainCam;

    public float timer = 60;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if(timer <= 0)
        {
            goldSpawn.GetComponent<Gold_Spawner>().enabled = true;
            spikeSpawn.GetComponent<Spawn_Manager>().enabled = true;
            introCam.SetActive(false);
            mainCam.SetActive(true);
        }
    }
}
