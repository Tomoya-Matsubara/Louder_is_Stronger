using UnityEngine;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour
{
    public void TitleGameButton() {
        SceneManager.LoadScene("GameScene");
    }

    public void ResultTitleButton(){
        SceneManager.LoadScene("TitleScene");
    }

    public void ResultGameButton() {
        SceneManager.LoadScene("GameScene");
    }


}
