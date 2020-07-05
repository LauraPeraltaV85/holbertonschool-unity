using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LevelSelect(int level)
    {
        switch (this.gameObject.name) 
        {
            case "Level01":
                SceneManager.LoadScene ("Level01");
                break;
            case "Level02":
                SceneManager.LoadScene ("Level02");
                break;
            case "Level03":
                SceneManager.LoadScene ("Level03");
                break;
            // case "OptionsButton":
            //     SceneManager.LoadScene ("Options");
            //     break;
        }
    }

    public void Options()
    {
        PlayerPrefs.SetString("previousScene", SceneManager.GetActiveScene().name);
        if (this.gameObject.name == "OptionsButton")
            SceneManager.LoadScene ("Options");
    }

    public void QuitPlatformer()
    {
        Debug.Log("Exit Game");
        Application.Quit();
    }

}
