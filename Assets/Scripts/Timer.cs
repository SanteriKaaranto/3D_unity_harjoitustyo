using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    [Header("Component")]
    public TextMeshProUGUI timerText;

    private float currentTime = 0;
    private bool timerIsOn = false;

    private void Update()
    {
        if (timerIsOn)
        {
            currentTime += Time.deltaTime;
            UpdateTimerText();
        }
        else if (!timerIsOn)
        {
            currentTime = 0;
            UpdateTimerText();
        }
    }

    private void UpdateTimerText()
    {
        // Format the time as desired (e.g., minutes and seconds)
        string formattedTime = FormatTime(currentTime);
        timerText.text = formattedTime;
    }

    // Ajan formatointi
    private string FormatTime(float timeInSeconds)
    {
        int minutes = Mathf.FloorToInt(timeInSeconds / 60F);
        int seconds = Mathf.FloorToInt(timeInSeconds - minutes * 60);
        return string.Format("{0:00}:{1:00}", minutes, seconds);
    }

    public void StartTimer()
    {
        timerIsOn = true;
    }

    public void StopAndResetTimer()
    {
        timerIsOn = false;
    }
}

