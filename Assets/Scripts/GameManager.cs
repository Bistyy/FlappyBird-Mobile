using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI scoreText;
    [SerializeField] GameObject gameOverPanel;
    int score = 0;

    public void AddScore()
    {
        score++;
        scoreText.text = score.ToString();
    }

    public void GameOver()
    {
        Time.timeScale = 0;
        if (gameOverPanel) gameOverPanel.SetActive(true);
    }

    public void Restart()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}