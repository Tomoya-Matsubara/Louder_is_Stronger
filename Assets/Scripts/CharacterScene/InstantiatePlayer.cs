using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiatePlayer : MonoBehaviour
{
    public GameObject player1;
    public GameObject player2;
    public GameObject player3;
    public GameObject player4;


    // Start is called before the first frame update
    void Start()
    {
        GameObject[] players = { player1, player2, player3, player4 };
        int index = setButton.charaindex - 1; 

        //Debug.Log($"====InstantiateEnemy.cs====\nレベル：{EnemyLevel.currentLevel}\n配列の長さ：{enemies.Length}\nインデックス：{index}\n========================");

        GameObject obj = Instantiate(players[index], transform.position, transform.rotation);
        obj.transform.localScale = transform.localScale;
        obj.transform.parent = transform;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
