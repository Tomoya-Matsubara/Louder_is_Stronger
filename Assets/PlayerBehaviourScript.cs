using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviourScript : MonoBehaviour
{
    // Animator コンポーネント
    private Animator animator;

    // 設定したフラグの名前
    private const string key_isShout = "isShout";

    // Start is called before the first frame update
    void Start()
    {
        this.animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        // WaitからShoutに切り替える処理
        // スペースキーを押下している
        if (Input.GetKey(KeyCode.Space))
        {
            // WaitからShoutに遷移する
            this.animator.SetBool(key_isShout, true);
        }
        else
        {
            // ShoutからWaitに遷移する
            this.animator.SetBool(key_isShout, false);
        }
    }
}
