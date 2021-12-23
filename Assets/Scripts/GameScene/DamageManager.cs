using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DamageManager : MonoBehaviour
{
    public GameObject damageTextObject; // ダメージを表示するオブジェクト
    private TextMeshProUGUI damageText; // ダメージを表示するためのテキストエリア
    MicrophoneSource microVar; // MicrophoneSource.csの変数
    public float damage;

    public int maxHP;
    public float currentHP;
    public Slider HPSlider;
    public GameObject textHPObject = null;
    public Text textHP;
    
    ShowDamageMessage dmVar;
    ScoreManager smVar;

    public float timeOut;  // timeOut[s]ごとに処理を実行
    private float timeElapsed; // 経過時間のカウンター


    // Start is called before the first frame update
    void Start()
    {
        // スリープ機能無効化（自動ロックしないようにする）
        Screen.sleepTimeout = SleepTimeout.NeverSleep;

        dmVar = GameObject.Find("DamageTexts").GetComponent<ShowDamageMessage>();

        // MicrophoneSource.csの変数を取得
        microVar = GetComponent<MicrophoneSource>();

        // ScoreManager.csの変数取得
        smVar = GameObject.Find("ScoreManagerObject").GetComponent<ScoreManager>();

        // HPバーの初期設定
        HPSlider.value = 1;

        textHP = textHPObject.GetComponent<Text>();

        // 毎回スクリプトが読み込まれるたびにレベルアップ
        EnemyLevel.UpdateLevel();
        Debug.Log($"レベル {EnemyLevel.currentLevel}です。");

        maxHP = EnemyLevel.maxHP;
        currentHP = maxHP;
        // Debug.Log($"初期HPは{currentHP}");
    }

    // Update is called once per frame
    void Update(){
        computeDamage();
        textHP.text = $"{(int)currentHP}/{maxHP}";
        dmVar.fadeOutText();
    }


    private void computeDamage() 
    {
        timeElapsed += Time.deltaTime;

        if (timeElapsed >= timeOut && currentHP > 0)
        {

            // ダメージを取得
            damage = microVar.meanAmp * 5000;

            if (damage > 1) 
            {
                damage = checkCriticalHit(damage);
                smVar.updateScoreWithDamage((int) damage);

                // ダメージは 0〜1000
                // damageText.text = $"{(damage).ToString("f1")} ダメージ！";
                // Debug.Log(damageText.text);
                updateHP();
                showDamage(damage);
            }

            timeElapsed = 0.0f;
        }
    }

    private void updateHP()
    {
        currentHP -= damage;
        HPSlider.value = currentHP / maxHP;

        // Debug.Log($"現在のHP：{currentHP}");
        // Debug.Log($"スライダーの値： {HPSlider.value}");

        if (currentHP <= 0) {
            damage = 0;
            currentHP = 0;

            damageTextObject.SetActive(true);
            // ダメージを表示するためのテキストエリアを取得
            damageText = damageTextObject.GetComponent<TextMeshProUGUI>();
            damageText.text = $"敵を倒した！";
            
            // 3秒後にシーン切り替え（敵が倒れるアニメーションを見るため）
            Invoke(nameof(MoveToResultScene), 3.0f);
        }
    }

    private void showDamage(float damage) 
    {
        dmVar.showDamageText(damage);
    }

    // 会心の一撃設定：乱数が一定値を越えればダメージ10倍
    private float checkCriticalHit(float damage) 
    {
        if (Random.value > 0.9) {
            damage *= 10;
            // Debug.Log("<color=red>会心の一撃！</color>");
        }
        return damage;
    }

    private void MoveToResultScene() 
    {
        SceneManager.LoadScene("ResultScene");
    }
}
