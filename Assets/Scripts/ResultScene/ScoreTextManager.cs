using System.Collections;
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
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = $"Score: {ScoreManager.score}";
    }
}
