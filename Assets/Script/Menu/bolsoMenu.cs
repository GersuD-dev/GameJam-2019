using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bolsoMenu : MonoBehaviour
{

    public static float timer, speed;


    public int direcao;

    void Start()
    {
        timer = 0;
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

            if (timer > 2)
            {
               Application.LoadLevel("jogo");
            }

    }
}
