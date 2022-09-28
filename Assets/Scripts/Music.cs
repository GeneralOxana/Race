using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music : MonoBehaviour
{
    public AudioSource sound;

    void Start()
    {
        if (GameObject.Find("sound") == null)
        {
            Instantiate(sound);
            sound.name = "sound";
            DontDestroyOnLoad(sound);
        }        
    }
}
    

