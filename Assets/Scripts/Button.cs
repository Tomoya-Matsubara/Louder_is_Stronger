﻿using UnityEngine;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour
{
    public void MenuButton() {
        SceneManager.LoadScene("MenuScene");
    }

    public void GameButton() {
        ScoreManager.startScore();
        SceneManager.LoadScene("GameScene");
    }

    public void ManualButton() {
        SceneManager.LoadScene("ManualScene");
    }

    public void CharacterButton() {
        SceneManager.LoadScene("CharacterScene");
    }

    public void ResultGameButton() {
        SceneManager.LoadScene("GameScene");
    }


}
