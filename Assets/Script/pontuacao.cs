using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class pontuacao : MonoBehaviour
{
    public Text infectados;
    public Text vivos;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        infectados.text = Spawner.contaminated.ToString();
        vivos.text = Click.vivos.ToString();
    }
}
