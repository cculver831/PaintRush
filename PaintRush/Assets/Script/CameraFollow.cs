using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;//what camerca will follow
    private Vector3 playerPosition;
    public Vector3 Offset;
    private void Start()
    {
        playerPosition = target.position;
        Offset = new Vector3(Offset.x, Offset.y, transform.position.z - target.position.z);
    }
    // Update is called once per frame
    void Update()
    {
        transform.position = target.position + Offset;
    }
}
