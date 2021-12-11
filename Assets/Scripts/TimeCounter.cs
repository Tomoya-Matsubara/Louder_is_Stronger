using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimeCounter : MonoBehaviour
{
    private float countdown = 30.0f;
    public Text timeText;
    int retime;

    public EnemyLevel enemylevel = new EnemyLevel();
    
    // ダメージが0になったことを検知するため
    DamageManager damageVar;

    // Start is called before the first frame update
    void Start()
    {
        damageVar = GameObject.Find("AudioObject").GetComponent<DamageManager>();
    }

    // Update is called once per frame
    void Update()
    {
        // タイマーの更新は敵が生きている場合のみ
        if (damageVar.currentHP > 0) 
        {
            countdown -= Time.deltaTime;
            retime = (int)countdown;
            timeText.text = retime.ToString();

            if (retime == 0) 
            {
                SceneManager.LoadScene("GameoverScene");
                enemylevel.StartLevel();
            }
        }
        
    }
}
