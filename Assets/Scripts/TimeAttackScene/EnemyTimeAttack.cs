using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTimeAttack : MonoBehaviour
{
    // Animator コンポーネント
    private Animator animator;

    // 設定したフラグの名前
    private const string key_isAttacked = "isAttacked";
    private const string key_isDie = "isDie";

    InfiniteDamage damageVar;

    // Start is called before the first frame update
    void Start()
    {
        this.animator = GetComponent<Animator>();
        damageVar = GameObject.Find("AudioObject").GetComponent<InfiniteDamage>();
    }

    // Update is called once per frame
    void Update()
    {
        // WaitからAttackedに切り替える処理
        if (damageVar.damage > 5)
        {
            // WaitからAttackedに遷移する
            this.animator.SetBool(key_isAttacked, true);
        }
        else
        {
            // AttackedからWaitに遷移する
            this.animator.SetBool(key_isAttacked, false);
        }
    }
    
}
