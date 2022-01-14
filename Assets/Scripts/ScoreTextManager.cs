﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ScoreTextManager : MonoBehaviour
{
    private TextMeshProUGUI scoreText;
    // Start is called before the first frame update
    void Start()
    {
        scoreText = gameObject.GetComponent<TextMeshProUGUI>();
        scoreText.text = $"Score: {ScoreManager.score}";

        if (PlayerPrefs.HasKey("Best Score")) 
        {
            int best_score = PlayerPrefs.GetInt("Best Score");
            
            if (best_score < ScoreManager.score)
            {
                PlayerPrefs.SetInt("Best Score", ScoreManager.score);
            }
        }
        else
        {
            PlayerPrefs.SetInt("Best Score", ScoreManager.score);
        }
    }

    // Update is called once per frame
    void Update()
    {
  
    }
}
