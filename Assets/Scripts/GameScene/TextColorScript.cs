using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextColorScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Text text = this.GetComponent<Text>();

        Debug.Log($"====TextColorScript.cs====\nレベル：{EnemyLevel.currentLevel}\n========================");

        if (EnemyLevel.currentLevel % 12 >= 0 && EnemyLevel.currentLevel % 12 <= 5)
        {
            text.color = new Color(0.0f, 0.0f, 0.0f, 1.0f);
        }
        else if (EnemyLevel.currentLevel % 12 >= 6 && EnemyLevel.currentLevel % 12 <= 11)
        {
            text.color = new Color(1.0f, 1.0f, 1.0f, 1.0f);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
