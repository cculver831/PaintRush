using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Killzone : MonoBehaviour
{
    [SerializeField] private Transform Player;
    [SerializeField] private Transform respawnPoint;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player1"))
        {
            Live(other);
        }
        else if (other.CompareTag("Player 2"))
        {
            Live2(other);
        }
       
    }
    public void Live( Collider player)
    {
        
        player.transform.position = respawnPoint.transform.position;
    }
    public void Live2(Collider player)
    {

        player.transform.position = respawnPoint.transform.position;
    }
}
