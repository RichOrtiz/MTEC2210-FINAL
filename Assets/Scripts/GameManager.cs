using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{

    public int score;
    public TextMeshPro scoreText;
    private ScoreScript scoreScript;
    // Start is called before the first frame update
    void Start()
    {
        scoreScript = GameObject.Find("ScoreText").GetComponent<ScoreScript>();
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = score.ToString("00000");
        
    }

    public void IncreaseScore(int value)
    {
        score += value;
        scoreScript.PlayEnemyDeathAudio();
    }
    public void RestartGame()
    {
        SceneManager.LoadScene(0);
    }
    public void GameOver()
    {
        SceneManager.LoadScene(1);
    }
    public void Win()
    {
        SceneManager.LoadScene(2);
    }
}
