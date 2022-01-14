using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using TMPro;

using UnityEngine.UI;

public class ShowDamageMessage : MonoBehaviour
{

    public GameObject damageText;

    //DamageManager damageVar;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void showDamageText(float damage) {
        damageText.GetComponent<TextMeshProUGUI>().text = $"{(damage).ToString("f0")}";

        GameObject obj = Instantiate(damageText, transform.position, Quaternion.identity);
        obj.transform.SetParent(gameObject.transform, false);
    }

    public void fadeOutText() {
        foreach(Transform child in transform) {
            child.GetComponent<TextMeshProUGUI>().color -= new Color32(0, 0, 0, 2);

            if (child.GetComponent<TextMeshProUGUI>().color.a <= 0)
            {
                Destroy(child.gameObject);
            }
        }
    }
}
