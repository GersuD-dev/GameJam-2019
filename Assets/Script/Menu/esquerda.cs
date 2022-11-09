using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class esquerda : MonoBehaviour
{

    public float timer, speed;

    public int direcao;
    public bool estado; 

    void Start()
    {
        direcao = -1;
        estado = true;
        timer = 0;

    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        transform.Translate(direcao*Time.deltaTime,0,0);

        if (timer >= 45)
        {           
            timer = 0;
            estado = !estado;
            GetComponent<SpriteRenderer>().flipX = estado;

            direcao = direcao *-1;
 
        }

    }
}
