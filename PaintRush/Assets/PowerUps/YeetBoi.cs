using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YeetBoi : MonoBehaviour

{
    public static float speed;
    void OnTriggerEnter(Collider other)
    {
       if (other.CompareTag("Player1"))
        {
            StopCoroutine(PickUp(other));
            StartCoroutine(PickUp(other));
        }
       else if (other.CompareTag("Player 2"))
        {
            StopCoroutine(PickUp2(other));
            StartCoroutine(PickUp2(other));
        }
    }
    IEnumerator PickUp( Collider player)
    {
        PlayerMovement speed = GameObject.Find("Player1").GetComponent<PlayerMovement>();
        speed.yeet();
        Debug.Log("Bread Acquired");
        transform.position = new Vector3(transform.position.x + 100f, transform.position.y, transform.position.z + 100f);
        yield return new WaitForSeconds(5f);
        Destroy(gameObject);
    }
    IEnumerator PickUp2(Collider player)
    {
        PlayerMovement1 speed = GameObject.Find("Player2").GetComponent<PlayerMovement1>();
        speed.yeet();
        Debug.Log("Yeet");
        transform.position = new Vector3(transform.position.x + 100f, transform.position.y, transform.position.z + 100f);
        yield return new WaitForSeconds(5f);
        Destroy(gameObject);
    }

}
