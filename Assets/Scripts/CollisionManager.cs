using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class CollisionManager : MonoBehaviour
{
    private Timer timer;

    //Vaatii static, että muissa luokissa voi käyttää ilman instanssioimista
    public static float timerValue { get; set; } 

    void Start()
    {
        timer = GameObject.FindObjectOfType<Timer>();
    }
    void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("start"))
        {
            timer.StartTimer();
        }
        else if (collision.CompareTag("reset"))
        {
            timer.StopAndResetTimer();
        }
        else if (collision.CompareTag("finish"))
        {
            timer.StopTimer();
            timerValue = timer.currentTime;
            SceneManager.LoadScene(1);
        }
    }
}
