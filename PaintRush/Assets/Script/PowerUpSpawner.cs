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
    public List<bool> isEmpty = new List<bool>();
    // Use this for initialization
    void Start()
    {
        timeSpawns = timeBTWs;
        foreach (Transform i in spawnLocations)
        {
            isEmpty.Add(true);
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
            if (isEmpty[randLocInd])
            {
                temp = Instantiate(powerUps[randInd], spawnLocations[randLocInd].position, Quaternion.identity);
                isEmpty[randLocInd] = false;
                if (temp.GetComponent("PaintSwitch") != null)
                {
                    temp.GetComponent<PaintSwitch>().returnI(randLocInd);
                }
                else if(temp.GetComponent("YeetBoi") != null)
                {
                    temp.GetComponent<YeetBoi>().returnI(randLocInd);
                }
                else
                {
                    temp.GetComponent<DummyThicc>().returnI(randLocInd);
                }
                
            }
            timeSpawns = timeBTWs;
        } 
        else
        {
            timeSpawns -= Time.deltaTime;
        }
    }
    public void powerBack(int i)
    {
        isEmpty[i] = true;
    }
}
