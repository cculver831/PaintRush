using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaintFollowTest : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject paintBrush;

    void Awake()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = paintBrush.transform.position;
    }
}
