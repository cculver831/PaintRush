using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DummyThicc : MonoBehaviour
{
    public static float multiplier = 2f;
    [SerializeField] private float mainTimer;

    private float timer;
    private bool canCount = true;
    private bool doOnce = false;
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
        transform.position = new Vector3(transform.position.x + 100f, transform.position.y, transform.position.z + 100f);
        yield return new WaitForSeconds(5f);
        player.transform.localScale /= multiplier;
        splatSize.Big(2.54f);
        Destroy(gameObject);
    }
    IEnumerator PickUp2(Collider player)
    {
        splatPaint splatSize = GameObject.Find("Player2").GetComponent<splatPaint>();
        splatSize.Big(7f);
        player.transform.localScale *= multiplier;
        transform.position = new Vector3(transform.position.x + 100f, transform.position.y, transform.position.z + 100f);
        yield return new WaitForSeconds(5f);
        player.transform.localScale /= multiplier;
        splatSize.Big(2.54f);
        Destroy(gameObject);
    }


}
