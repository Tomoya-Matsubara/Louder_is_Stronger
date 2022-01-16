using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class BestScoreManager : MonoBehaviour
{
    private TextMeshProUGUI scoreText;
    public string mode;
    public bool label = true;
    public bool isMenuScene = false;

    // Start is called before the first frame update
    void Start()
    {
        scoreText = gameObject.GetComponent<TextMeshProUGUI>();

        if (PlayerPrefs.HasKey(mode)) 
        {
            int best_score = PlayerPrefs.GetInt(mode);

            if (isMenuScene) {
                scoreText.text = label ? $"{mode}: {best_score}" : $"Best: {best_score}";
            }
            else {
                if (best_score < ScoreManager.score)
                {
                    PlayerPrefs.SetInt(mode, ScoreManager.score);
                    PlayerPrefs.Save();
                    scoreText.text = label ? $"{mode}: {ScoreManager.score}" : $"Best: {ScoreManager.score}";
                }
                else
                {
                scoreText.text = label ? $"{mode}: {best_score}" : $"Best: {best_score}";
                }
            }
        }
        else
        {
            PlayerPrefs.SetInt(mode, 0);
            scoreText.text = label ? $"{mode}: {ScoreManager.score}" : $"Best: {ScoreManager.score}";
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
