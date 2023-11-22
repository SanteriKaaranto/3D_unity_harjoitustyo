using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{

    [Header("Component")]
    public TextMeshProUGUI timerText;

    public float currentTime;
    private bool timerIsOn = false;

    private void Start()
    {
        currentTime = 0;
    }

    public void Update()
    {
        // Tarkastellaan onko timer päällä
        if (timerIsOn)
        {
            currentTime += Time.deltaTime;
            UpdateTimerText();
        }
        else if (!timerIsOn)
        {
            UpdateTimerText();
        }
    }

    // Päivitetään timer
    private void UpdateTimerText()
    {
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
        currentTime = 0;
        timerIsOn = false;
    }

    public void StopTimer()
    {
        timerIsOn = false;
    }

    public float ReturnTime()
    {
        return currentTime;
    }
}

