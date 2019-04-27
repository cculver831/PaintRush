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
    public List<Transform> availableLocation = new List<Transform>();
    // Use this for initialization
    void Start()
    {
        timeSpawns = timeBTWs;
        foreach(Transform i in spawnLocations)
        {
            availableLocation.Add(i);
        }
    }

    // Update is called once per frame
    void Update()
    {

        //weapons
        if (timeSpawns <= 0)
        {
            int randInd = Random.Range(0, powerUps.Length);
            int randLocInd = Random.Range(0, (spawnLocations.Length));
            if (availableLocation.Contains(spawnLocations[randLocInd]))
            {
                Instantiate(powerUps[randInd], availableLocation[availableLocation.IndexOf(spawnLocations[randLocInd])].position, Quaternion.identity);
                availableLocation.Remove(spawnLocations[randLocInd]);
            }
            timeSpawns = timeBTWs;
        } 
        else
        {
            timeSpawns -= Time.deltaTime;
        }
    }
    public void addTransform(Transform t)
    {
        availableLocation.Add(t);
    }
}
