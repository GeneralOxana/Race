using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class GoButton : MonoBehaviour
{
    public Button goButton;
    public GameObject[] players;
    public Collider collider;
    public AudioSource go;


    void Start()
    {
        goButton.onClick.AddListener(GoBtn);
        players = GameObject.FindGameObjectsWithTag("Player");
              
    }

    void GoBtn()
    {
        foreach (var player in players)
        {
            player.GetComponent<Move>().enabled = true;
            go.Play();
        }
    }
        
}
