﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DummyThicc : MonoBehaviour
{
    public static float multiplier = 2f;
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player1"))
        {
            PickUp(other);
        }
        else if (other.CompareTag("Player 2"))
        {
            PickUp(other);
        }
    }
    public void PickUp(Collider player)
    {
        splatPaint splatSize = GameObject.Find("Player1").GetComponent<splatPaint>();
        splatSize.Big();
        player.transform.localScale *= multiplier;
        Destroy(gameObject);
    }
}