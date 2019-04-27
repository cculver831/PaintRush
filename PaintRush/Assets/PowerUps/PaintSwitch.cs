using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaintSwitch : MonoBehaviour
{

    public static float speed;
    public float timer = 7f;
    public float timer2 = 7f;
    public GameObject PaintSwitchPrefab;
    public GameObject[] powerManager;
    void Awake()
    {
        powerManager = GameObject.FindGameObjectsWithTag("powerManager");
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player1"))
        {
           StopCoroutine(TheOlSwticheroo(other));
            StartCoroutine(TheOlSwticheroo(other));
        }
        else if (other.CompareTag("Player 2"))
        {
            StopCoroutine(TheOlSwitcheroo2(other));
            StartCoroutine(TheOlSwitcheroo2(other));
        }
    }
    //switches player2 paint color
    IEnumerator TheOlSwticheroo(Collider player)
    {
        splatPaint switcher = GameObject.Find("Player2").GetComponent<splatPaint>();
        switcher.change(1);
        Debug.Log("Paint switched2");
        //transform.position = new Vector3(transform.position.x + 100f, transform.position.y, transform.position.z + 100f);
        gameObject.GetComponent<MeshRenderer>().enabled = false;
        gameObject.GetComponent<CapsuleCollider>().enabled = false;
        yield return new WaitForSeconds(5f);
        powerManager[0].GetComponent<PowerUpSpawner>().addTransform(gameObject.transform);
        switcher.change(3);
        gameObject.GetComponent<MeshRenderer>().enabled = true;
        gameObject.GetComponent<CapsuleCollider>().enabled = true;
        Destroy(gameObject);
        Debug.Log("Gottem");
       
    }
    //switches player1 paint color
   IEnumerator TheOlSwitcheroo2(Collider player)
    {
        splatPaint switcher = GameObject.Find("Player1").GetComponent<splatPaint>();
        switcher.change(3);
        Debug.Log("Paint switched");
        //transform.position = new Vector3(transform.position.x + 100f, transform.position.y, transform.position.z + 100f);
        gameObject.GetComponent<MeshRenderer>().enabled = false;
        gameObject.GetComponent<CapsuleCollider>().enabled = false;
        yield return new WaitForSeconds(5f);
        powerManager[0].GetComponent<PowerUpSpawner>().addTransform(gameObject.transform);
        gameObject.GetComponent<MeshRenderer>().enabled = true;
        gameObject.GetComponent<CapsuleCollider>().enabled = true;
        Destroy(gameObject);
        switcher.change(1);
       
 
    }

}

