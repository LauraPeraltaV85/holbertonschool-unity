using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Text timerText;
    public Text finalTime;
    public float timeStart;
    
    // Start is called before the first frame update
    void Start()
    {
        //timerText = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        timeStart += Time.deltaTime;
        string minutes = Mathf.Floor((timeStart % 3600) / 60).ToString("0");
        string seconds = (timeStart % 60).ToString("00");
        string miliseconds = ((timeStart * 100) % 100).ToString("00");
        timerText.text = minutes + ":" + seconds + ":" + miliseconds;   
    }

    public void Win()
    {
        finalTime.text = timerText.text;
    }
}
