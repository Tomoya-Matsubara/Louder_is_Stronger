using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimeCounter : MonoBehaviour
{
    private float countdown = 30.0f;
    public Text timeText;
    int retime;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        countdown -= Time.deltaTime;
        retime = (int)countdown;
        timeText.text = retime.ToString();

        if(retime == 0) {
            SceneManager.LoadScene("ResultScene");
        }
        
    }
}
