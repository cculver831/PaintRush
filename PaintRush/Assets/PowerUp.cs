using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour

{
    public static float speed;
    void OnTriggerEnter(Collider other)
    {
       if (other.CompareTag("Player1"))
        {
            PickUp(other);
        }
       else if (other.CompareTag("Player 2"))
        {
            PickUp2();
        }
    }
    void PickUp( Collider player)
    {
        PlayerMovement speed = GameObject.Find("Player1").GetComponent<PlayerMovement>();
        speed.yeet();
        Debug.Log("Bread Acquired");
        Destroy(gameObject);
    }
    void PickUp2()
    {

        PlayerMovement1 speed = GameObject.Find("Player2").GetComponent<PlayerMovement1>();
        speed.yeet();
        Debug.Log("Yeet");
        Debug.Log("Speed now " + speed);
        Destroy(gameObject);
    }

}
