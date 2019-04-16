using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car_Movement : MonoBehaviour
{
    public float speed = 7f;

    private bool dirRight = true;

    void Update()
    {
        if (dirRight)
            transform.Translate(Vector2.right * speed * Time.deltaTime);
        else
            transform.Translate(-Vector2.right * speed * Time.deltaTime);

        if (transform.position.x >= 24.0f)
        {
            dirRight = false;
        }

        if (transform.position.x <= -24)
        {
            dirRight = true;
        }
    }
}
