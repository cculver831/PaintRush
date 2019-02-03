using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public GameObject Brush;
    public float BrushSize = 5f;
    public float speed = 5f;
    public float rotationSpeed = 5f;
    private bool PlayerMove = false;
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
        input.x = Input.GetAxisRaw("Horizontal");
        input.y = Input.GetAxisRaw("Vertical");
        PlayerMove = true;
        if (PlayerMove)
        {
            var position = transform.TransformPoint(Vector3.zero);
            var go = Instantiate(Brush, transform.TransformPoint(Vector3.zero), Quaternion.identity, transform);
        }
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
