using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Minigame1 : MonoBehaviour
{
    [SerializeField] private float maxBar = 100f;
    [SerializeField] private float currentBar = 0;
    [SerializeField] private Slider barra = null;
    [SerializeField] private float score = 0;
    [SerializeField] private float time;
    [SerializeField] private GameObject gameOverPanel = null;
    [SerializeField] private TextMeshProUGUI scoreText = null;
    [SerializeField] private TextMeshProUGUI scoreT = null;

    void Start()
    {
        if (gameOverPanel == null)
        {
            print("n colocou o panel");

        }
        if (barra == null)
        {
            print("n colocou a barra");

        }
        if (scoreText == null)
        {
            print("n colocou o text");

        }
        gameOverPanel.SetActive(false);
        barra.maxValue = maxBar;
    }
    
    void Update()
    {
        if (currentBar > maxBar)
        {
            currentBar = maxBar;
        }
        barra.value = currentBar;

        if (currentBar > 0)
        {
            currentBar -= 10f * Time.deltaTime;
        }
        if (time > 0)
        {
            time -= 1f * Time.deltaTime;
        }
        if (time <= 0)
        {
            GameOver();
        }

        if (barra.value > 25 % maxBar && barra.value < 50 % maxBar)
        {
            score += 25f * Time.deltaTime;
        }
        if (barra.value > 50 % maxBar && barra.value < 75 % maxBar)
        {
            score += 50f * Time.deltaTime;
        }
        if (barra.value > 75 % maxBar && barra.value < 95 % maxBar)
        {
            score += 100f * Time.deltaTime;
        }
        if (barra.value > 95 % maxBar)
        {
            score += 200f * Time.deltaTime;
        }
        scoreT.text = "Score: " + score;

    }

    public void ActionButton()
    {
        currentBar += 10f;
    }

    public void GameOver()
    {
        scoreText.text = "score maximo: " + score;
        gameOverPanel.SetActive(true);
        PlayerPrefs.SetFloat("maxScoreMinigame1", score);
    }
}