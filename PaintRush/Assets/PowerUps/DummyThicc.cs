using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DummyThicc : MonoBehaviour
{
    public static float multiplier = 2f;
    [SerializeField] private float mainTimer;
    public int index;
    public GameObject powerManager;
    private void Start()
    {
        powerManager = GameObject.FindGameObjectWithTag("powerManager");
    }
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
    IEnumerator PickUp(Collider player)
    {
        splatPaint splatSize = GameObject.Find("Player1").GetComponent<splatPaint>();
        splatSize.Big(7f);
        player.transform.localScale *= multiplier;
        //transform.position = new Vector3(transform.position.x + 100f, transform.position.y, transform.position.z + 100f);
        gameObject.GetComponent<MeshRenderer>().enabled = false;
        gameObject.GetComponent<BoxCollider>().enabled = false;
        yield return new WaitForSeconds(5f);
        player.transform.localScale /= multiplier;
        splatSize.Big(2.54f);
        gameObject.GetComponent<MeshRenderer>().enabled = true;
        gameObject.GetComponent<BoxCollider>().enabled = true;
        powerManager.GetComponent<PowerUpSpawner>().powerBack(index);
        Destroy(gameObject);
    }
    IEnumerator PickUp2(Collider player)
    {
        splatPaint splatSize = GameObject.Find("Player2").GetComponent<splatPaint>();
        splatSize.Big(7f);
        player.transform.localScale *= multiplier;
        //transform.position = new Vector3(transform.position.x + 100f, transform.position.y, transform.position.z + 100f);
        gameObject.GetComponent<MeshRenderer>().enabled = false;
        gameObject.GetComponent<BoxCollider>().enabled = false;
        yield return new WaitForSeconds(5f);
        player.transform.localScale /= multiplier;
        gameObject.GetComponent<MeshRenderer>().enabled = true;
        gameObject.GetComponent<BoxCollider>().enabled = true;
        splatSize.Big(2.54f);
        powerManager.GetComponent<PowerUpSpawner>().powerBack(index);
        Destroy(gameObject);
    }
    public void returnI(int i)
    {
        index = i;
    }

}
