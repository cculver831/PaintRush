using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeTest : MonoBehaviour
{
    public int band;
    public float startScale, ScalMultiplier;
    public bool useBuffer;
    Material material;
    private void Start()
    {
        material = GetComponent<MeshRenderer>().materials[0];
    }
    // Update is called once per frame
    void Update()
    {
        if(useBuffer)
        {
            transform.localScale = new Vector3(transform.localScale.x, (Audio.audioBandBuffer[band])* ScalMultiplier + startScale, transform.localScale.z);
            Color color = new Color(Audio.audioBandBuffer[band], Audio.audioBandBuffer[band], Audio.audioBandBuffer[band]);
            material.SetColor  ("_EmissionColor", color);
        }
        if (!useBuffer)
        {
            transform.localScale = new Vector3(transform.localScale.x, (Audio.audioBand[band] * ScalMultiplier) + startScale, transform.localScale.z);
            Color color = new Color(Audio.audioBandBuffer[band], Audio.audioBandBuffer[band], Audio.audioBandBuffer[band]);
            material.SetColor ("_EmissionColor", color);
        }
    }
}
