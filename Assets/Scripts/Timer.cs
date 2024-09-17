using System;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Text timer;

    [SerializeField] private string startTime = "05:00";
    private TimeSpan timeRemaining;
    private bool timerRunning = true;

    void Start()
    {
        timeRemaining = TimeSpan.ParseExact(startTime, @"mm\:ss", null);
        timer.text = timeRemaining.ToString(@"mm\:ss");
    }

    void Update()
    {
        // If the timer is running and has time left
        if (timerRunning && timeRemaining.TotalSeconds > 0)
        {
            timeRemaining -= TimeSpan.FromSeconds(Time.deltaTime);

            timer.text = timeRemaining.ToString(@"mm\:ss");
        }

        if (timeRemaining.TotalSeconds <= 0)
        {
            timerRunning = false;
            timer.text = "00:00";
        }
    }
}
