using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // Private variables
    int score = 0;
    // Public variables
    [SerializeField] TMP_Text scoreText;
    [SerializeField] TMP_Text gameOverText;
    [SerializeField] Button restartButton;

    public int Score
    {
        get { return score; }
        set
        {
            score = value;
            scoreText.text = $"Score: {score}";
        }
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        score = 0;
        gameOverText.gameObject.SetActive(false);
        restartButton.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void GameOver()
    {
        gameOverText.gameObject.SetActive(true);
        restartButton.gameObject.SetActive(true);
    }

    public void Restart()
    {
        SceneManager.LoadScene(0);
    }
}
