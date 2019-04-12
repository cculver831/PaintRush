using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bar_Movement : MonoBehaviour
{
    public float speed = 7f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
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
