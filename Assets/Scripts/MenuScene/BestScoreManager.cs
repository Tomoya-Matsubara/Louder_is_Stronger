using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class BestScoreManager : MonoBehaviour
{
    private TextMeshProUGUI scoreText;

    // Start is called before the first frame update
    void Start()
    {
        scoreText = gameObject.GetComponent<TextMeshProUGUI>();

        if (PlayerPrefs.HasKey("Best Score")) 
        {
            int best_score = PlayerPrefs.GetInt("Best Score");
            
            if (best_score < ScoreManager.score)
            {
                PlayerPrefs.SetInt("Best Score", ScoreManager.score);
                PlayerPrefs.Save();
                scoreText.text = $"Best Score: {ScoreManager.score}";
            }
            else
            {
            scoreText.text = $"Best Score: {best_score}";
            }
        }
        else
        {
            scoreText.text = $"Best Score: {ScoreManager.score}";
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
