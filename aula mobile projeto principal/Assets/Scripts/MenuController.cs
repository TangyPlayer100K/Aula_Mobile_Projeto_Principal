using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    [SerializeField] GameObject pausePanel;
    [SerializeField] bool gameIsPaused = false;
    [SerializeField] bool audioIsMuted = false;
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

    public void AudioSwitch()
    {
        if (audioIsMuted == false)
        {
            //desliga o audio
            audioIsMuted = true;
        }
        else if (audioIsMuted == true)
        {
            //liga o audio
            audioIsMuted = false;
        }
    }

    #region Scenes
    public void ExitToMenu()
    {
        SceneManager.LoadScene(0);
    }
    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }
    #endregion

    public void ExitGame()
    {
        Debug.Log("morri!");
        Application.Quit();
    }
}
