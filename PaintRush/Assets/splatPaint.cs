using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class splatPaint : MonoBehaviour
{
    Vector4 channelMask = new Vector4(1, 0, 0, 0);
    int splatsX = 1;
    int splatsY = 1;
    public Transform roller;
    public float splatScale = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Get how many splats are in the splat atlas
        splatsX = SplatManagerSystem.instance.splatsX;
        splatsY = SplatManagerSystem.instance.splatsY;

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            channelMask = new Vector4(1, 0, 0, 0);
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            channelMask = new Vector4(1, 1, 0, 0);
        }

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            channelMask = new Vector4(0, 0, 1, 0);
        }

        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            channelMask = new Vector4(0, 0, 0, 1);
        }


        Vector3 leftVec = Vector3.Cross(roller.transform.position, Vector3.up);
        float randScale = Random.Range(0.5f, 1.5f);

        GameObject newSplatObject = new GameObject();
        newSplatObject.transform.position = roller.transform.position;
        if (leftVec.magnitude > 0.001f)
        {
            newSplatObject.transform.rotation = Quaternion.LookRotation(leftVec, roller.transform.position);
        }
        newSplatObject.transform.localScale = new Vector3(randScale, randScale * 0.5f, randScale) * splatScale;

        Splat newSplat;
        newSplat.splatMatrix = newSplatObject.transform.worldToLocalMatrix;
        newSplat.channelMask = channelMask;

        float splatscaleX = 1.0f / splatsX;
        float splatscaleY = 1.0f / splatsY;
        float splatsBiasX = Mathf.Floor(Random.Range(0, splatsX * 0.99f)) / splatsX;
        float splatsBiasY = Mathf.Floor(Random.Range(0, splatsY * 0.99f)) / splatsY;

        newSplat.scaleBias = new Vector4(splatscaleX, splatscaleY, splatsBiasX, splatsBiasY);

        SplatManagerSystem.instance.AddSplat(newSplat);

        GameObject.Destroy(newSplatObject);
    }
}
