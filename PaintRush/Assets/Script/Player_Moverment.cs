using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Moverment : MonoBehaviour
{
    public float speed = 100f;
    public float rotationSpeed = 100f;
    public Rigidbody rb;
    void Update()
    {
        if (Input.GetKey("w"))
        {
            transform.Translate(0f, 0f, speed * Time.deltaTime);
        }
        if (Input.GetKey("s"))
        {
            transform.Translate(0f, 0f, -speed* Time.deltaTime);
        }
        if (Input.GetKey("a"))
        {
            transform.Translate(-speed * Time.deltaTime, 0f,0f);
        }
        if (Input.GetKey("d"))
        {
            transform.Translate(speed * Time.deltaTime, 0f, 0f);
        }
    }
}
