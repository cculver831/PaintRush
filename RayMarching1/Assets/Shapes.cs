using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shapes : MonoBehaviour
{
    public int band;
    public float startScale;
    public float ScalMultiplier = 0.2f;
    public bool useBuffer;
    Material material;
    private void Start()
    {
        material = GetComponent<MeshRenderer>().materials[0];
    }
    // Update is called once per frame
    void Update()
    {
        if (useBuffer)
        {
            transform.localScale = new Vector3((Audio.audioBandBuffer[band]) * ScalMultiplier, (Audio.audioBandBuffer[band]) * ScalMultiplier, (Audio.audioBandBuffer[band]) * ScalMultiplier);
            Color color = new Color(Audio.audioBandBuffer[band], Audio.audioBandBuffer[band], Audio.audioBandBuffer[band]);
            material.SetColor("_EmissionColor", color);
        }
    }
}
