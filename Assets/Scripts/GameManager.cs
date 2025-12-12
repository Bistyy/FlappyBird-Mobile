using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI scoreText;
    [SerializeField] GameObject gameOverPanel;
    int score;

    public void GameOver()
    {
        Time.timeScale = 0;
        gameOverPanel.SetActive(true);
    }

    public void AddScore() { score++; scoreText.text = score.ToString(); }

    public void Restart() { Time.timeScale = 1; SceneManager.LoadScene(0); }
}