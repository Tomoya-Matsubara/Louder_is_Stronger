using UnityEngine;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour
{
    public void TitleGameButton() {
        ScoreManager.startScore();
        SceneManager.LoadScene("GameScene");
    }

    public void ResultTitleButton(){
        SceneManager.LoadScene("TitleScene");
    }

    public void ResultGameButton() {
        SceneManager.LoadScene("GameScene");
    }


}
