using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CreateField : MonoBehaviour
{
    float valuePlayers = GlobalP.valuePlayers;
    public GameObject[] players;
    float step;
    float stepText;
    float road = -4.5f;
    float roadText = -450;
    GameObject ball;

    private Text inst_text;
    public Text prefabText;

    void Start()
    {        
        step = 9f / valuePlayers / 2;
        stepText = 900 / valuePlayers / 2;
       
        for (int i = 0; i < valuePlayers; i++)
        {
            road += step;
            ball = Instantiate(players[i], new Vector3(road, 0.1f, -9), Quaternion.Euler(0, 0, Random.Range(-180, 180)));
            ball.name = players[i].name;

            roadText += stepText;
            inst_text = Instantiate(prefabText, new Vector3(roadText, 330, 0), Quaternion.identity);
            inst_text.transform.SetParent(GameObject.FindGameObjectWithTag("pref").transform, false);
            //inst_text.transform.position = ball.transform.position;
            // inst_text.text = ball.name.ToString();
            inst_text.text = (i+1).ToString();

            road += step;
            roadText+= stepText;
        }
    }

    private void OnEnable()
    {
        valuePlayers = GlobalP.valuePlayers;
    }
    
}
// Random.Range(-45, 45)
