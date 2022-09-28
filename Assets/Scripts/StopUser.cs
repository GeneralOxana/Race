using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StopUser : MonoBehaviour
{
    Text text;
    AudioSource go;

    void Start()
    {
        text = GameObject.Find("Canvas/Result").gameObject.GetComponent<Text>();
    }
    


   void OnTriggerEnter()
   {
        GetComponent<Move>().enabled = false;
        text.text += "\n" + name;
   }
}
