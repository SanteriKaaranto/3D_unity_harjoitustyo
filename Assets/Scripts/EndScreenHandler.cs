using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EndScreenHandler : MonoBehaviour
{
    [Header("Component")]
    public TextMeshProUGUI timerText;

    private float newTimerValue;

    // Start is called before the first frame update
    void Start()
    {
        newTimerValue = CollisionManager.timerValue;

        string formattedTime = FormatTime(newTimerValue);
        timerText.text = formattedTime;
    }

    private string FormatTime(float timeInSeconds)
    {
        int minutes = Mathf.FloorToInt(timeInSeconds / 60F);
        int seconds = Mathf.FloorToInt(timeInSeconds - minutes * 60);
        return string.Format("{0:00}:{1:00}", minutes, seconds);
    }

    void Update()
    {
        if (Input.GetKeyDown("escape"))
        {
            Application.Quit();
        }
    }
}
