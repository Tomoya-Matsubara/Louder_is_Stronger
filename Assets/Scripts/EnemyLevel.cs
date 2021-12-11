using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class EnemyLevel : MonoBehaviour
{
    public static int currentLevel = 0;
    public static int maxHP = 100;
    public int levelHP;

    // Start is called before the first frame update
    void Start()
    {
        levelHP = maxHP;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public static void UpdateLevel() {
        currentLevel += 1;
        maxHP += (int) Math.Round(50 * UnityEngine.Random.value);
    }

    public static void StartLevel() {
        currentLevel = 0;
        maxHP = 100;
    }

}
