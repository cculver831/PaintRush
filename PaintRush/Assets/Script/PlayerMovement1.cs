using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement1 : MonoBehaviour
{
    public float speed = 100f;
    public float rotationSpeed = 100f;
    Vector2 input;
    float angle;
    Quaternion targetRotation;
 
    private void Start()
    {
    
    }
    void Update()
    {
        GetInput();
        if (Mathf.Abs(input.x) < 1 && Mathf.Abs(input.y) < 1) return;
        CalculateDirection();
        Rotate();
        Move();
    }
    void GetInput()
    {
        // Input based on WASD keys
        input.x = Input.GetAxisRaw("Horizontal2");
        input.y = Input.GetAxisRaw("Vertical2");
    }
    void CalculateDirection()
    {
        //Direction relative to player based on camera 
        angle = Mathf.Atan2(input.x, input.y);
        angle = Mathf.Rad2Deg * angle;
    }
    void Rotate()
    {
        targetRotation = Quaternion.Euler(0, angle, 0);
        transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);
    }
    void Move()
    {
        transform.position += transform.forward * speed * Time.deltaTime;
    }

}
