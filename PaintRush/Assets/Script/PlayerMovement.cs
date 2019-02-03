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
        input.x = Input.GetAxisRaw("Horizontal");
        input.y = Input.GetAxisRaw("Vertical");
        PlayerMove = true;
        if (PlayerMove)
        {
            // spawns paint behind player (is supposed to)
            var position = transform.TransformPoint(Vector3.zero);
            var go = Instantiate(Brush, new Vector3( input.x + 2.0F,input.y + 0.1f, 0), Quaternion.identity, transform);
            _lastposition = transform.position;
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
