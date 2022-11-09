using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class botao : MonoBehaviour
{

    // Start is called before the first frame update

    public GameObject[] itens;

    public static bool estadoBolso;
    public bool estado;

    public float timer;

    void Start()
    {
        itens[0].SetActive(false);
        estado = false;
    }

    // Update is called once per frame
    void Update()
    {

        timer += Time.deltaTime;

        if (estado == true)
        {
            timer = 0;  
            itens[0].SetActive(true);
            itens[1].SetActive(false);
            estado = false;
        }



    }

    private void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            estado = true;
        }



    }

}