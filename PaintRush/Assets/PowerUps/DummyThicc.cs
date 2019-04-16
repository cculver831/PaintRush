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
            PickUp(other);
        }
        else if (other.CompareTag("Player 2"))
        {
            PickUp2(other);
        }
    }
    public void PickUp(Collider player)
    {
        splatPaint splatSize = GameObject.Find("Player1").GetComponent<splatPaint>();
        splatSize.Big(7f);
        player.transform.localScale *= multiplier;
        Destroy(gameObject);
    }
    public void PickUp2(Collider player)
    {
        splatPaint splatSize = GameObject.Find("Player2").GetComponent<splatPaint>();
        splatSize.Big(7f);
        player.transform.localScale *= multiplier;
        Destroy(gameObject);
   
        timer = mainTimer;

       if (timer >= 0.0f)
       {
       timer -= Time.deltaTime;
       Debug.Log("The clock is ticking");
       }
       if (timer <= 0.0f)
       {
        Debug.Log("Time's up)");
        player.transform.localScale /= multiplier;
        splatSize.Big(2.54f);
        }
 
    }


}
