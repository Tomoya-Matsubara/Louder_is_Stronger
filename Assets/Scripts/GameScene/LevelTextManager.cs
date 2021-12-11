using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelTextManager : MonoBehaviour
{
    private Text levelText;
    // Start is called before the first frame update
    void Start()
    {
        levelText = gameObject.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        levelText.text = $"Level {EnemyLevel.currentLevel}";
    }
}
