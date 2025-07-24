using UnityEngine;
using TMPro;


public class UIManager : MonoBehaviour
{
    public TMP_Text scoreText;
    public GameObject startScreen;
    public GameObject tutorialScreen;
    public GameObject gameOverScreen;
    public GameObject scoreUI;

    public void UpdateScore(int score)
    {
        scoreText.text = score.ToString();
    }

    public void ShowStart()
    {
        startScreen.SetActive(true);
        tutorialScreen.SetActive(false);
        gameOverScreen.SetActive(false);
        scoreUI.SetActive(false);
    }

    public void HideStart()
    {
        startScreen.SetActive(false);
    }

    public void ShowReady()
    {
        startScreen.SetActive(false);
        tutorialScreen.SetActive(true);
        gameOverScreen.SetActive(false);
    }

    public void HideReady()
    {
        tutorialScreen.SetActive(false);
        scoreUI.SetActive(true);
    }

    public void ShowGameOver()
    {
        gameOverScreen.SetActive(true);
    }


}
