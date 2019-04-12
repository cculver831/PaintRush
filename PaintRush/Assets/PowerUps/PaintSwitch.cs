using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaintSwitch : MonoBehaviour
{
    public static float speed;
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player1"))
        {
            TheOlSwticheroo(other);
        }
        else if (other.CompareTag("Player 2"))
        {
            TheOlSwitcheroo2(other);
        }
    }
    void TheOlSwticheroo(Collider player)
    {
        splatPaint switcher = GameObject.Find("Player2").GetComponent<splatPaint>();
        switcher.change(0);
        Destroy(gameObject);
    }
    void TheOlSwitcheroo2(Collider player)
    {
        splatPaint switcher= GameObject.Find("Player1").GetComponent<splatPaint>();
        switcher.change(3);
        Destroy(gameObject);
    }
}
