using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TimerController : MonoBehaviour
{
    public float duration = 60;
    public float timeRemaining;
    public bool timerRunning = false;
    public TextMeshProUGUI timerLabel;
    // Start is called before the first frame update
    void Start()
    {
        timerRunning = true;
        timeRemaining = duration;
    }

    // Update is called once per frame
    void Update()
    {
        if (timerRunning)
        {
            if(timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
                timerLabel.text = Mathf.FloorToInt(timeRemaining) + "s";
            } else {
                timeRemaining = 0;
                timerRunning = false;
            }
        }
    }
}
