using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnGoodGuysController : MonoBehaviour
{
    public GameObject[] bananas;
    public GameObject tomato;
    public GameObject officerBob;
    public GameObject baguette;
    public GameObject commisionerPatrick;
    public float interval = 3.0f;
    public float startTime = 5.0f;
    float time;
    int done = 0;

    public float pOfBananas = 0.15f;
    public float pOfTomato = 0.30f;
    public float pOfBob = 0.40f;
    public float pOfBaguette = 0.40f;
    public float pOfPatrick = 0.40f;
    public int difficulty = 0;



    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnGoodGuys", startTime, interval);
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;

        if ((time > 10 && done == 0) || (time > 15 && done == 1) || (time > 20 && done == 2) || (time > 25 && done == 3) || (time > 30 && done == 4) || (time > 35 && done == 5))
        {
            IncreaseDifficulty();
            done++;
        }
        else if (time > 35 && pOfBaguette !> 0.9)
        {
            IncreaseDifficulty();
        }
    }


    void SpawnGoodGuys()
    {
        
        float rand = Random.value;

        if (rand < pOfBananas)
        {
            GameObject g = Instantiate(bananas[Random.Range(0, bananas.Length)], transform.position, Quaternion.identity);
        }
        else if (rand < pOfTomato)
        {
            GameObject g = Instantiate(tomato, transform.position, Quaternion.identity);
        }
        else if (rand < pOfBob)
        {
            GameObject g = Instantiate(officerBob, transform.position, Quaternion.identity);
        }
        else if (rand < pOfPatrick)
        {
            GameObject g = Instantiate(commisionerPatrick, transform.position, Quaternion.identity);
        }
        else if (rand < pOfBaguette)
        {
            GameObject g = Instantiate(baguette, transform.position, Quaternion.identity);
        }
        else
        {
            
        }
    }

    public void IncreaseDifficulty()
    {
        difficulty ++;

        if (difficulty <= 1)
        {
            pOfBananas += 0.03f;
            pOfTomato += 0.05f;
            pOfBob += 0.07f;
            interval -= 0.5f;
        }

        else if (difficulty == 2)
        {
            pOfPatrick = pOfBob + 0.1f;
            interval -= 0.25f;
        }

        else if (difficulty == 3)
        {
            pOfTomato += 0.02f;
            pOfBob += 0.02f;
            pOfPatrick += 0.1f;
            pOfBaguette = pOfPatrick + 0.1f;
        }

        else if (difficulty == 4) {

            pOfBananas = 0.05f;
            pOfTomato = 0.15f;
            pOfBob = 0.20f;
            pOfPatrick = 0.40f;
            pOfBaguette = 0.60f;
        }

        else if (difficulty > 4)
        {
            pOfBananas += 0.02f;
            pOfTomato += 0.04f;
            pOfBob += 0.06f;
            pOfPatrick += 0.1f;
            pOfBaguette += 0.12f;
            interval -= 0.5f;            
        }

        else
        {

        }
    }
}
