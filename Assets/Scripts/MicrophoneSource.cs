using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MicrophoneSource : MonoBehaviour
{
    AudioSource audioSource;  // 音源となるコンポーネント（Audio Source）

    // Start is called before the first frame update
    void Start()
    {
        // Audio Source を取得
        audioSource = GetComponent<AudioSource>();

        // Audio Source の Audio Clip をマイク入力に設定
        // 引数は、
        //    デバイス名（デフォルトは null）
        //    ループの可否
        //    何秒取るか
        //    サンプリング周波数
        audioSource.clip = Microphone.Start(null, true, 1, 44100);

        // マイクが Ready になるまで待機（一瞬）
        while (Microphone.GetPosition(null) <= 0) {}

        // 録音した音声を再生
        audioSource.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // オーディオが読まれるたびに実行
    // data：音波の振幅を記録した配列（-1.0〜1.0を取る）
    //       ex) [0.5, -0.2, 0.3, 0.1, -1.0, ...]
    // channel: 音源の数（今は１のはず）
    private void OnAudioFilterRead(float[] data, int channels)
    {
        float sumAmp = 0f;  // サンプリング中の振幅総和（音量の総和に相当）
        float meanAmp = 0f; // サンプリング区間の平均振幅（音量平均）
        foreach (float amp in data)
        {
            sumAmp += Mathf.Abs(amp); // 振幅の絶対値（音量）を足す
        }

        // 音量総和をデータ数（サンプリング数）で割って平均音量とする
        meanAmp = sumAmp / (float) data.Length;
        Debug.Log($"平均音量は {meanAmp} です。");

        // meanAmp の値で音の大きさは判別できるので、ここを使えばダメージ計算は比較的簡単にできそう
        // 音の長さを測定したい場合は一定の値を超えているかを保存するフラグを作り、
        // フラグが立っている　かつ　今回の区間でも一定の値を超えた　　＝＞　連続して音を出せている
        // それ以外　＝＞　連続して音を出せていない　＝＞　フラグを下ろす
        // といった流れにする
        if (meanAmp >= 0.5) {
            Debug.Log($"<color=red>うるさいです</color>");
        }
    }
}
