using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyLevel : MonoBehaviour
{
    int startlevel = 1;
    public static int currentlevel;
    public Text levelText;

    // Start is called before the first frame update
    void Start()
    {
        currentlevel = startlevel;
        DontDestroyOnLoad(levelText);
    }

    // Update is called once per frame
    void Update()
    {
        levelText.text = currentlevel.ToString();
    }

    public void UpdateLevel() {
        currentlevel += 1;
    }

    public void StartLevel() {
        currentlevel = 1;
    }

}
