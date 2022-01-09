using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Time60Counter : MonoBehaviour
{
    public float countdown = 60.0f;
    private Text timeText;

    // Start is called before the first frame update
    void Start()
    {
        timeText = gameObject.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        countdown -= Time.deltaTime;
        timeText.text = $"Time: {(int) countdown}";

        if (countdown < 0) 
        {
            SceneManager.LoadScene("GameoverScene");
            EnemyLevel.StartLevel();
        }
        
    }
}
