using UnityEngine;
using UnityEngine.UI;
public class tempo : MonoBehaviour
{
    private string timerFormatted;



    bool isRunning = true;
    //
    void Start()
    {
        
    }


    void Update()
    {



        if (isRunning)
        {
            Spawner.tempo += Time.deltaTime;
       
            System.TimeSpan t = System.TimeSpan.FromSeconds(Spawner.tempo);
            timerFormatted = string.Format("{0:D1}:{1:D2}", t.Minutes, t.Seconds);


            GetComponent<Text>().text = timerFormatted;
        }


    }

}