using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DamageManager : MonoBehaviour
{
    public GameObject damageTextObject; // ダメージを表示するオブジェクト
    MicrophoneSource microVar; // MicrophoneSource.csの変数
    private float damage;

    // Start is called before the first frame update
    void Start()
    {
        // MicrophoneSource.csの変数を取得
        microVar = GetComponent<MicrophoneSource>();
    }

    // Update is called once per frame
    void Update()
    {
        // ダメージを取得
        damage = microVar.meanAmp;

        // ダメージを表示するためのテキストエリアを取得
        TextMeshProUGUI damageText = damageTextObject.GetComponent<TextMeshProUGUI>();
        damageText.text = $"{damage} ダメージ！";
    }
}
