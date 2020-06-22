using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public bool paused = false;
    public GameObject pausedMenu;
    void Update ()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if(paused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }
    public void Pause()
    {
        pausedMenu.SetActive(true);
        Time.timeScale = 0f;
        paused = true;
        // SceneManager.LoadScene(SceneManager.GetActiveScene(), LoadSceneMode.Additive);
    }

    public void Resume()
    {
        pausedMenu.SetActive(false);
        Time.timeScale = 1f; 
        paused = false;      
        // GamePlay gp = FindObjectOfType<GamePlay>();
        // gp.paused = false;
        // SceneManager.UnloadScene ()
    }

    public void Restart ()
    {
        Time.timeScale = 1f; 
        if (this.gameObject.name == "RestartButton")
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void MainMenu ()
    {
        Time.timeScale = 1f; 
        if (this.gameObject.name == "MenuButton")
            SceneManager.LoadScene ("MainMenu");
    }
    public void Options ()
    {
        Time.timeScale = 1f; 
        if (this.gameObject.name == "OptionsButton")
            SceneManager.LoadScene ("Options");
    }
}