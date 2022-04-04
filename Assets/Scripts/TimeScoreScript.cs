using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;
public class TimeScoreScript : MonoBehaviour
{
    float time;
    public Text timeText;
    int scoreTime;
    int scoreBeat;
    int score = 0;

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        score = (int)Math.Round(time);
        timeText.text = score.ToString();     
    }

    public int GetTheGodamnScoreFam()
    {
        return score;
    }
}
