using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ScoreTextManager : MonoBehaviour
{
    private TextMeshProUGUI scoreText;
    public string mode;

    // Start is called before the first frame update
    void Start()
    {
        scoreText = gameObject.GetComponent<TextMeshProUGUI>();
        scoreText.text = $"Score: {ScoreManager.score}";

        if (PlayerPrefs.HasKey(mode)) 
        {
            int best_score = PlayerPrefs.GetInt(mode);
            
            if (best_score < ScoreManager.score)
            {
                PlayerPrefs.SetInt(mode, ScoreManager.score);
            }
        }
        else
        {
            PlayerPrefs.SetInt(mode, ScoreManager.score);
        }
    }

    // Update is called once per frame
    void Update()
    {
  
    }
}
