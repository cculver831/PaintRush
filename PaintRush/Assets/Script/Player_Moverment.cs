using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Moverment : MonoBehaviour
{
    public float speed = 5f;
    public float jumpSpeed = 10f;
    public float rotationSpeed = 100f;
    private Rigidbody rb;
    private Vector3 moveDirection = Vector3.zero;
    private float heading;
    void Update()
    {

        float moveVert = Input.GetAxis("Horizontal") * speed;
        float moveHor = Input.GetAxis("Vertical") * speed;

        moveVert *= Time.deltaTime;
        moveHor *= Time.deltaTime;
    }
}
