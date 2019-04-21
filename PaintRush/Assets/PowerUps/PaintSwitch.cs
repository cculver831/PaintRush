using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaintSwitch : MonoBehaviour
{
    [SerializeField] private float mainTimer;
    private float timer=0;
    public bool reset=false;
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player1"))
        {
            timer = 7;
            splatPaint switcher = GameObject.Find("Player2").GetComponent<splatPaint>();
            switcher.change(1);
            Destroy(gameObject);
            if (reset)
            {
                switcher.change(3);
                reset = false;
            }
        }
        else if (other.CompareTag("Player 2"))
        {
            timer = 7;
            splatPaint switcher = GameObject.Find("Player1").GetComponent<splatPaint>();
            switcher.change(3);
            Destroy(gameObject);
            if (reset)
            {
                switcher.change(1);
                reset = false;
            }

        }
    }
    private void Update()
    {
        if (timer > 0.0f)
        {
            Debug.Log("The clock is ticking" + timer);
            timer -= Time.deltaTime;
        }
        else if(timer <=0)
        {
            Debug.Log("Time's up)");
            reset = true;
        }
    }
}
