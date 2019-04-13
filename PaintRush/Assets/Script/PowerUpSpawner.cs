using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpSpawner : MonoBehaviour
{
    public GameObject[] powerUps;
    public Transform[] spawnLocations;
    private float timeSpawns;
    public float timeBTWs;
    public GameObject temp;
    // Use this for initialization
    void Start()
    {
        timeSpawns = timeBTWs;
    }

    // Update is called once per frame
    void Update()
    {
        
        //weapons
        if (timeSpawns <= 0)
        {
            int randInd = Random.Range(0, powerUps.Length);
            int randLocInd = Random.Range(0, spawnLocations.Length);
            Instantiate(powerUps[randInd], spawnLocations[randLocInd].position, Quaternion.identity);
            timeSpawns = timeBTWs;
        }
        else
        {
            timeSpawns -= Time.deltaTime;
        }
    }
}
