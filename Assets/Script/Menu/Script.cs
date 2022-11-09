using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class direita : MonoBehaviour
{

    public GameObject[] velhas;

    public float timer, speed;

    public int direcao;
    public bool estado; 

    void Start()
    {
        direcao = 1;
        estado = false;
        timer = 0;

    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        transform.Translate(direcao*Time.deltaTime*speed,0,0);

        if (timer >= 20)
        {           
            timer = 0;
            GetComponent<SpriteRenderer>().flipX = !estado;
            direcao = direcao *-1;
 
        }

    }
}
