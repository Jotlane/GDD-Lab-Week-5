using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

public class ScoreManager : MonoBehaviour
{
    // Start is called before the first frame update
    public float score = 0;
    float multiplier = 1;
    TextMeshProUGUI scoreText;
    void Start()
    {
        score = 0;
        multiplier = 1;
        scoreText = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        score += Time.deltaTime * multiplier;
        scoreText.text = "Score: " + Math.Round(score).ToString();
    }
    public void IncreaseScoreMultiplier()
    {
        multiplier = 5;
        Debug.Log("inc");
    }
    public void ResetScoreMultiplier()
    {
        multiplier = 1;
        Debug.Log("rst");
    }
    public void PauseScore()
    {
        multiplier = 0;
    }
    public void ResetScore()
    {
        ResetScoreMultiplier();
        score = 0;
        multiplier = 1;
    }
}
