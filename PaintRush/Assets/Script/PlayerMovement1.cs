using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement1 : MonoBehaviour
{
    
    public float speed = 5f;
    public float rotationSpeed = 5f;
    public string Horizontal = "Horizontal_P2";
    public string Vertical= "Vertical_P2";
   
    Vector3 currentPosition;
    Vector2 input;
    Vector3 _lastposition;
    float angle;
    Quaternion targetRotation;
   

    private void Start()
    {
        currentPosition = transform.position;

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
        input.x = Input.GetAxisRaw(Horizontal);
        input.y = Input.GetAxisRaw(Vertical);
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
    public void yeet()
    {
        speed = 10;
    }

}
