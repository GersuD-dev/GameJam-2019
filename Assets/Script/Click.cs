using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Click : MonoBehaviour
{

    public static int vivos = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseOver()
    {
        Debug.Log(GetComponent<Health>().current);
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log(GetComponent<Health>().current);
            
            if (GetComponent<Health>().current > 0)
            {
                GetComponent<Health>().current -= 20;
            } else  {
                gameObject.SetActive(false);
                vivos += 1;
            }
            
        }
    }

}
