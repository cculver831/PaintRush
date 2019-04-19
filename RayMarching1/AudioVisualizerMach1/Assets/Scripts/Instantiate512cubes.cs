using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instantiate512cubes : MonoBehaviour
{
    public GameObject sampleCube;
    GameObject[] sampleC = new GameObject[512];
    public float maxScale;
    // Start is called before the first frame update
    void Start()
    {
        //creates ring of cubes around gameobject
        for(int i = 0; i < 512; i++)
        {
            GameObject instanceofCube = (GameObject)Instantiate(sampleCube);
            instanceofCube.transform.position = this.transform.position;
            instanceofCube.transform.parent = this.transform;
            instanceofCube.name = "SampleCube" + i;
            this.transform.eulerAngles = new Vector3(0, -0.703125f * i,0);
            instanceofCube.transform.position = Vector3.forward * 100;
            sampleC[i] = instanceofCube;
        }
    }

    // Update is called once per frame
    void Update()
    {
        for(int i = 0; i < 512; i++)
        {
            if(sampleC != null)
            {
                sampleC[i].transform.localScale = new Vector3(10,( Audio.samples[i]*maxScale)+2, 10);
            }
        }
    }
}
