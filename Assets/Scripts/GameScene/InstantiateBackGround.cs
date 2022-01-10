using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InstantiateBackGround : MonoBehaviour
{
    private Image m_Image;
    public Sprite morning;
    public Sprite daytime;
    public Sprite evening;
    public Sprite night;

    // Start is called before the first frame update
    void Start()
    {
        m_Image = GetComponent<Image>();
        Sprite[] backgrounds = { morning, daytime, evening, night };
        int index = 0;

        if (EnemyLevel.currentLevel % 12 == 0 || EnemyLevel.currentLevel % 12 == 1 || EnemyLevel.currentLevel % 12 == 2)
        {
            index = 0;    
        } else if (EnemyLevel.currentLevel % 12 == 3 || EnemyLevel.currentLevel % 12 == 4 || EnemyLevel.currentLevel % 12 == 5)
        {
            index = 1;
        } else if (EnemyLevel.currentLevel % 12 == 6 || EnemyLevel.currentLevel % 12 == 7 || EnemyLevel.currentLevel % 12 == 8)
        {
            index = 2;
        } else if (EnemyLevel.currentLevel % 12 == 9 || EnemyLevel.currentLevel % 12 == 10 || EnemyLevel.currentLevel % 12 == 11)
        {
            index = 3;
        }

        Debug.Log($"====InstantiateBackGround.cs====\nレベル：{EnemyLevel.currentLevel}\nインデックス：{index}\n========================");

        m_Image.sprite = backgrounds[index];

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
