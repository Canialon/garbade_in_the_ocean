using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{


    public static bool GameIsPaused = false;
    public GameObject pauseMenuUI;
    public GameObject playMenuUI;

    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        playMenuUI.SetActive(true);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    public void Pause()
    {
        pauseMenuUI.SetActive(true);
        playMenuUI.SetActive(false);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

}
