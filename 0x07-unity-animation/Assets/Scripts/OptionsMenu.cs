using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OptionsMenu : MonoBehaviour
{
    //private Stack<int> loadScenes;

    //[System.NonSerialized]
    //private bool initialized;

    // private void Init()
    // {
    //     loadScenes = new Stack<int>();
    //     initialized = true;
    // }

    // public void LoadScene(int buildIndex)
    // {
    //     if( initialized == false)
    //         Init();
    //     loadScenes.Push(SceneManager.GetActiveScene().buildIndex);
    //     SceneManager.LoadScene(buildIndex);
    // }

    public void Back()
    {
        // if (initialized == false)
        // {
        //     Debug.Log("Use Load scene first");
        // }
        // if (loadScenes.Count > 0)
        // {
        //     SceneManager.LoadScene(loadScenes.Pop());
        // }

        SceneManager.LoadScene (PlayerPrefs.GetString("previousScene"));
    }
}
