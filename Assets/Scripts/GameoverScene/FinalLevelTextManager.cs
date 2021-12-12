using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

using UnityEngine.UI;

public class FinalLevelTextManager : MonoBehaviour
{
    private TextMeshProUGUI levelClearText;
    // Start is called before the first frame update
    void Start()
    {
        levelClearText = gameObject.GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        levelClearText.text = $"Your Level: {EnemyLevel.currentLevel}";
    }
}
