using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateEnemy : MonoBehaviour
{
    public GameObject enemy1;
    public GameObject enemy2;

    // Start is called before the first frame update
    void Start()
    {
        GameObject[] enemies = {enemy1, enemy2};
        int index = (EnemyLevel.currentLevel == 0) ? 0 : (EnemyLevel.currentLevel + 1) % enemies.Length;
        
        Debug.Log($"====InstantiateEnemy.cs====\nレベル：{EnemyLevel.currentLevel}\n配列の長さ：{enemies.Length}\nインデックス：{index}\n========================");
        
        GameObject obj = Instantiate(enemies[index], transform.position, transform.rotation);
        obj.transform.localScale = transform.localScale;
        obj.transform.parent = transform;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
