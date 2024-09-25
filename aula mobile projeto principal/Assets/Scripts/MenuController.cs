using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    [SerializeField] GameObject pausePanel;
    [SerializeField] bool gameIsPaused = false;
    private void Start()
    {
        if (pausePanel != null)
        {
            pausePanel.SetActive(false);
        }
        else
        {
            pausePanel = null;
        }
    }
    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }

    public void ExitGame()
    {
        Debug.Log("morri!");
        Application.Quit();
    }

    public void ExitToMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void Pause()
    {
        if (gameIsPaused == false)
        {
            pausePanel.SetActive(true);
            gameIsPaused = true;
            Time.timeScale = 0;
        }
        else if (gameIsPaused == true)
        {
            pausePanel.SetActive(false);
            gameIsPaused = false;
            Time.timeScale = 1;
        }
    }
    #region lvls
    public void LoadLvl1()
    {
        SceneManager.LoadScene(2);
    }
    public void LoadLvl2()
    {
        SceneManager.LoadScene(3);
    }
    public void LoadLvl3()
    {
        SceneManager.LoadScene(4);
    }
    public void LoadLvl4()
    {
        SceneManager.LoadScene(5);
    }
    public void LoadLvl5()
    {
        SceneManager.LoadScene(6);
    }
    public void LoadLvl6()
    {
        SceneManager.LoadScene(7);
    }
    #endregion
    public void LoadFinalScore()
    {
        SceneManager.LoadScene(8);
    }
}
