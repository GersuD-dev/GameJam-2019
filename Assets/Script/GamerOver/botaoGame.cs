using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class botaoGame : MonoBehaviour
{

    // Start is called before the first frame update

    public bool estado;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {


        if (estado == true)
        {
            Application.LoadLevel("menu");
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