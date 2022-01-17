using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterButton : MonoBehaviour
{
    //public GameObject chara;
    public int id;
    public GameObject Button1;
    public GameObject Button2;
    public GameObject Button3;
    public GameObject SetButton;
    setButton SB_var;

    // Start is called before the first frame update
    void Start()
    {

        SB_var = SetButton.GetComponent<setButton>();
        if(setButton.charaindex == id) {
            gameObject.GetComponent<Image>().color = new Color32(255, 22, 93, 255);
        }
        else {
            gameObject.GetComponent<Image>().color = new Color32(76, 68, 77, 255);
        }
        //Button1.GetComponent<Image>().color = Color.black;
        //Button2.GetComponent<Image>().color = Color.black;
        //Button3.GetComponent<Image>().color = Color.black;
    }


    public void onClick_Button() {
        if (setButton.charaindex != id) {
            gameObject.GetComponent<Image>().color = new Color32(255, 22, 93, 255);
            Button1.GetComponent<Image>().color = new Color32(76, 68, 77, 255);
            Button2.GetComponent<Image>().color = new Color32(76, 68, 77, 255);
            Button3.GetComponent<Image>().color = new Color32(76, 68, 77, 255);
        } 
        SB_var.setid(id);
    } 

    // Update is called once per frame
    void Update()
    {
        
    }
}
