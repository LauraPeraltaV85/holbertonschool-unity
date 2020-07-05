using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutsceneController : MonoBehaviour
{
    public GameObject timeCanvas;
    public GameObject playerT;
    public GameObject mainCamera;
    public GameObject cutsceneCamera;

    // Update is called once per frame
    void Update()
    {
        //OnStateExit();
    }
    // override public void OnStateExit (Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    // {
    //     timeCanvas.SetActive(true);
    //     playerT.GetComponent<Timer>().enabled = true;
    //     playerT.GetComponent<PlayerController>().enabled = true;
    //     cutsceneCamera.GetComponent<CutsceneController>().enabled = false;
    // }

    public void StartEverything()
    {
        timeCanvas.SetActive(true);
        mainCamera.SetActive(true);
        playerT.GetComponent<PlayerController>().enabled = true;
        cutsceneCamera.GetComponent<CutsceneController>().enabled = false;
        cutsceneCamera.SetActive(false);
    }
}
