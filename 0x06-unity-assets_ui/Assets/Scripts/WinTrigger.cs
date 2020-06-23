using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static Timer;

public class WinTrigger : MonoBehaviour
{
    public Text timerText;
    public GameObject playerT;

    public GameObject winCanvas;

    void OnTriggerEnter(Collider other)
    {
        playerT.GetComponent<Timer>().enabled = false;
        //timerText.fontSize = 60;
        //timerText.color = Color.green;
        winCanvas.SetActive(true);
    }
}
