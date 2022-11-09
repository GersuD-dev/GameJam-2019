using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jaulaMenu : MonoBehaviour
{

    public float tempo, speed;

    public GameObject[] transicao;
    public int direcao;
    public bool estado, estadinho; 

    void Start()
    {
        estadinho = true;
        speed = 4;
        direcao = -1;
        estado = false;
        tempo = 0;
        transicao[1].SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {

     
            tempo += Time.deltaTime;

                if (estadinho == true)
        {

        transform.Translate(0,-1*Time.deltaTime*speed,0);
        }

            
            if (tempo > 3.35 )
            {

                estadinho = false;
                transform.Translate(0,0,0);
                // animacao
            }

            if (tempo > 4)
            {
                       transicao[2].SetActive(false);
                              transicao[3].SetActive(false);
                transicao[0].SetActive(true);
            }
            if (tempo > 6)
                {
                    Application.LoadLevel("jogo");
                }
        }

    }
