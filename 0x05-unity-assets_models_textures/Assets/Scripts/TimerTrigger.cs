using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerTrigger : MonoBehaviour
{
    public Text timerText;
    public GameObject playerT;

    void OnTriggerExit(Collider other)
    {
        playerT.GetComponent<Timer>().enabled = true;
    }
}
