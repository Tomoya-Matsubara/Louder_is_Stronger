using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using TMPro;
public class ScoreManager : MonoBehaviour
{
    public static int score = 0;
    public GameObject scoreTextObject;
    private TextMeshProUGUI scoreText;
    public GameObject timer;

    // Start is called before the first frame update
    void Start()
    {
        scoreText = scoreTextObject.GetComponent<TextMeshProUGUI>();
        updateScoreText();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void updateScoreWithDamage(int damage) {
        score += damage * 10;
        updateScoreText();
    }

    public void updateScoreWithRemainigTime() {
        int time = int.Parse(timer.GetComponent<TextMeshProUGUI>().text);
        score += time * 100;
        updateScoreText();
    }

    private void updateScoreText() {
        scoreText.text = $"{score}";
    }
}
