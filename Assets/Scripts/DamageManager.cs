using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

using UnityEngine.UI;

public class DamageManager : MonoBehaviour
{
    public GameObject damageTextObject; // ダメージを表示するオブジェクト
    private TextMeshProUGUI damageText; // ダメージを表示するためのテキストエリア
    MicrophoneSource microVar; // MicrophoneSource.csの変数
    public float damage;

    public int maxHP = 10;
    public float currentHP;
    public Slider HPSlider;
    ShowDamageMessage dmVar;

    public float timeOut;  // timeOut[s]ごとに処理を実行
    private float timeElapsed; // 経過時間のカウンター

    // Start is called before the first frame update
    void Start()
    {
        // ダメージを表示するためのテキストエリアを取得
        damageText = damageTextObject.GetComponent<TextMeshProUGUI>();
        dmVar = GameObject.Find("DamageTexts").GetComponent<ShowDamageMessage>();

        // MicrophoneSource.csの変数を取得
        microVar = GetComponent<MicrophoneSource>();

        // HPバーの初期設定
        HPSlider.value = 1;
        currentHP = maxHP;
        Debug.Log($"初期HPは{currentHP}");
    }

    // Update is called once per frame
    void Update()
    {
        computeDamage();
        dmVar.fadeOutText();
    }


    private void computeDamage() 
    {
        timeElapsed += Time.deltaTime;

        if (timeElapsed >= timeOut && currentHP > 0)
        {

            // ダメージを取得
            damage = microVar.meanAmp * 1000;

            if (damage > 5) 
            {
                damage = checkCriticalHit(damage);

                // ダメージは 0〜1000
                damageText.text = $"{(damage).ToString("f1")} ダメージ！";
                Debug.Log(damageText.text);
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

        Debug.Log($"現在のHP：{currentHP}");
        Debug.Log($"スライダーの値： {HPSlider.value}");

        if (currentHP <= 0) {
            damageText.text = $"敵を倒した！";
        }
    }

    private void showDamage(float damage) {
        dmVar.showDamageText(damage);
    }

    // 会心の一撃設定：乱数が一定値を越えればダメージ10倍
    private float checkCriticalHit(float damage) {
        if (Random.value > 0.9) {
            damage *= 10;
            Debug.Log("<color=red>会心の一撃！</color>");
        }
        return damage;
    }
}
