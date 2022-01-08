using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateEnemy : MonoBehaviour
{
    public GameObject enemy1;
    public GameObject enemy2;
    public GameObject enemy4;
    public GameObject enemy5;
    public GameObject enemy6;
    public GameObject enemy7;

    // Start is called before the first frame update
    void Start()
    {
        GameObject[] enemies = {enemy1, enemy2, enemy4, enemy5, enemy6, enemy7};
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
