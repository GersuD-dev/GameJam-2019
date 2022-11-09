using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class prenda : MonoBehaviour
{

    public GameObject[] velhas;

    public float timer, speed;

    public int direcao;

    void Start()
    {
        direcao = 1;
        timer = 0;

    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        transform.Translate(0,direcao*Time.deltaTime*speed,0);

        if (timer >= 0.5)
        {           
            timer = 0;
            direcao = direcao * -1;
        }

    }
}
