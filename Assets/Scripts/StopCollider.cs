using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopCollider : MonoBehaviour
{
    public GameObject[] players;
    string plName;
    public GameObject collider;

    void Start()
    {
        players = GameObject.FindGameObjectsWithTag("Player");
    }

    
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {
        
        plName = other.transform.gameObject.name;
        
        foreach (var player in players)
        {
            player.GetComponent<Move>().enabled = false;
            
            
        }
    }
}
