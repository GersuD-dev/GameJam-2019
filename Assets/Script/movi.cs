using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movi : MonoBehaviour
{
    public int direccaoX;
    public int direccaoY;
    float timee;
    public float speeed;
    void Start()
    {   
        speeed = 2;
        timee = 0;
        direccaoX = Random.Range(-1,2);
        direccaoY = Random.Range(-1,2);
    }

    void Update()
    {



        timee += Time.deltaTime;

        if (timee > 5)
        {
                    direccaoX = Random.Range(-1,2);
                    direccaoY = Random.Range(-1,2);
                    timee = 0;
        }

        if (direccaoX < 0)
        {
               GetComponent<SpriteRenderer>().flipX = true;
        }
         else
        {
                GetComponent<SpriteRenderer>().flipX = false;
        }
            transform.Translate(direccaoX*Time.deltaTime*speeed,direccaoY*Time.deltaTime*speeed,0);
    }
       
    }
    