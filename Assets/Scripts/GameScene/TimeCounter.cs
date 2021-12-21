using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimeCounter : MonoBehaviour
{
    public float countdown = 30.0f;
    private Text timeText;
    
    // ダメージが0になったことを検知するため
    DamageManager damageVar;

    // Start is called before the first frame update
    void Start()
    {
        damageVar = GameObject.Find("AudioObject").GetComponent<DamageManager>();
        timeText = gameObject.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        // タイマーの更新は敵が生きている場合のみ
        if (damageVar.currentHP > 0) 
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
}
