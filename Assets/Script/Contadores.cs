using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Contadores : MonoBehaviour
{

    
/*   
     Quantidade de velhos (OUTRO SCRIPT)
     Proporção quantidade a cada tempo (OK)
     Limite contaminados (OK)
     Tempo (OK)
     Pontuação de quantidade de velhos dentro de casa (O que da para fazer upgrade) (OUTRO SCRIPT)
     Tempo regressivo da velinha na rua após surgir (OK)
     Quantas velinhas que você botou em casa  (OUTRO SCRIPT)
*/

    public static bool estadoRegressivo;
    public int ProporcaoQuantidade, LimiteContaminados, QuantidadeContaminados;
    public float tempoRegressivo = 10, tempo = 0, contagemTempo = 60;

    void Start()
    {
        ProporcaoQuantidade = 1; LimiteContaminados = 10;
    }

    // Loop
    void Update()
    {
        tempoVoid ();
        contagemTemporal();
        cronometroVoid();
    }
    
    
    void contagemTemporal ()
    {

        if (tempoVoid() >= contagemTempo) // condição para cada UM MINITO a proporão de idosos nascendo aumentar
        {
            contagemTempo = contagemTempo + 60;
            ProporcaoQuantidade = ProporcaoQuantidade * 2;
        }

    }

    public float tempoVoid ()
    {
    tempo += Time.deltaTime; // Tempo aumentando por segundo;
        return tempo;
    }

    void cronometroVoid ()
    {


        if (estadoRegressivo == true)
        {
            tempoRegressivo -= Time.deltaTime;
            if (tempoRegressivo < 0)
            {
                QuantidadeContaminados = QuantidadeContaminados + 1;

                if (QuantidadeContaminados > LimiteContaminados)
                {
                    // Situação de GameOver
                    //Application.LoadLevel("nomeDaScene"); // MUDANÇA DE SCENE PARA O GAME-OVER
                }

                tempoRegressivo = 10;
                estadoRegressivo = false;
            }
        }

    }
    }

