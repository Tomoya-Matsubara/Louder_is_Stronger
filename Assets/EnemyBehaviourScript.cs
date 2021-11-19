using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviourScript : MonoBehaviour
{
    // Animator コンポーネント
    private Animator animator;

    // 設定したフラグの名前
    private const string key_isAttacked = "isAttacked";
    private const string key_isDie = "isDie";

    // Start is called before the first frame update
    void Start()
    {
        this.animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        // WaitからAttackedに切り替える処理
        // スペースキーを押下している
        if (Input.GetKey(KeyCode.Space))
        {
            // WaitからAttackedに遷移する
            this.animator.SetBool(key_isAttacked, true);
        }
        else
        {
            // AttackedからWaitに遷移する
            this.animator.SetBool(key_isAttacked, false);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            // Wait or AttackedからDieに遷移する
            this.animator.SetBool(key_isDie, true);
        }
    }
}
