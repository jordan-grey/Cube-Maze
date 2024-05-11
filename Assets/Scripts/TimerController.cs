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
    public GameObject winLabel;
    public GameObject loseLabel;
    private bool winnable = true;
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
                timerLabel.text = Mathf.FloorToInt(timeRemaining) + "s";
                timerRunning = false;
                winnable = false;
                loseLabel.SetActive(true);
            }
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pickup"))
        {
            other.gameObject.SetActive(false);
            timeRemaining += 10;
        }
        if (other.gameObject.CompareTag("Finish") && winnable)
        {
            winLabel.SetActive(true);
            timerRunning = false;
        }
    }
}
