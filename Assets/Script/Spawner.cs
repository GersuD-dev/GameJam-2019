using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    public int contadorBolsominion;
    public GameObject[] oldLadies;
    public float[] entitiesTimers;
    
    public GameObject[] aberto;

    public static float[] entitiesHealth;
    public static float tempo = 0;

    public float spawnInterval = 10, deathInterval = 5, spawnContador = 0, propIntervalo = 0;
    public int entitiesHealthDefault = 3;
    public static int contaminated;

    public bool jogo; 

    private void Start() 
    {
        contadorBolsominion = 40;

        aberto[0].SetActive(true);

        jogo = false; 

        spawnContador = spawnContador - 1;

        entitiesTimers = new float[oldLadies.Length];
        entitiesHealth = new float[oldLadies.Length];
        contaminated = 0;
        for (int i = 0; i < oldLadies.Length; i++)
        {
            oldLadies[i].SetActive(false);
        }
    }

    public void Update() {
        tempo += Time.deltaTime;
        
        if (jogo == false && tempo > 2)
        {
            
            aberto[0].SetActive(false);

            jogo = true;
            tempo = 0;
        }

        if (jogo == true)
        {
        contagemTemporal();
        if (contaminated > 10)
        {
            Application.LoadLevel("gameover");
        }

        }

        if (tempo > 30)
        {
            contadorBolsominion = 0;
        }
    }

    void contagemTemporal ()
    {
        if (tempo >= spawnContador) {
            int random = Random.Range(1,oldLadies.Length-contadorBolsominion-1);

            if (!oldLadies[random].activeSelf) {
                oldLadies[random].SetActive(true);
                entitiesTimers[random] = tempo;
                entitiesHealth[random] = entitiesHealthDefault;
                spawnContador = (spawnInterval) + spawnContador;
            }
        }

        for (int i = 0; i < oldLadies.Length; i++) {
            if (oldLadies[i].activeSelf && tempo > (entitiesTimers[i] + deathInterval)) {
                contaminated += 1;
                oldLadies[i].SetActive(false);
            }
        }
        
        if (tempo >= propIntervalo) {
            propIntervalo = propIntervalo + 30;
            spawnInterval = spawnInterval - 3;
        }

    }

}

