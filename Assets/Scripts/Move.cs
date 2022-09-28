using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    float lastTime = 1f;
    float velocity = 1f;
    //public Animator anim;
    public Animation anim;

    void Start()
    {
        anim = GetComponent<Animation>();
        GetComponent<Animation>().Play("Take");
    }

    void Update()
       {
        if (Time.time - lastTime > 1f)
        {
            velocity = Random.Range(1f, 1.5f);
            anim["Take"].speed = Random.Range(0.5f, 2.0f);
            lastTime = Time.time;
        
        }

        transform.Translate(new Vector3(0, 0, velocity) * Time.deltaTime);
        }
}
