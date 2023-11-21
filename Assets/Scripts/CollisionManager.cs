using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CollisionManager : MonoBehaviour
{
    private Timer timer;
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
            Debug.Log("collision with finish");
        }
    }
}
