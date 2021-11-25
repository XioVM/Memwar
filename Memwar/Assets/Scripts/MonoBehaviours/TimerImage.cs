using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerImage : AppObject
{
    public float totalTime = 10f;
    public float timeRemaining = 0f;
    public bool timerIsRunning = false;
    public Image timerImage;


    // Update is called once per frame
    void Update()
    {
        if (timerIsRunning)
        {
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
                // timeremaing = 10 
                //time.deltatime = 1 esta corriendo
                //el menos igual es practicamente: timeRemaining = timeRemaining - Time.deltaTime;
                //time remainig -= time.deltatime el resultado de esto menos esto es y += que es el resultado de esto mas esto es: 
                DisplayTime(timeRemaining); //muestra esto en la pantalla
            }
            else
            {
                Debug.Log("El tiempo se termino");
                InvokeEvent<TimeOutEvent>(new TimeOutEvent());
                timeRemaining = 0;
                DisplayTime(0);
                timerIsRunning = false;
                
            }

        }
    }

    void DisplayTime(float timeToDisplay)
    {

       timerImage.fillAmount = timeToDisplay / totalTime;


    }

    public void StartTimer()
    {
        timerIsRunning = true;
        timeRemaining = totalTime;
        DisplayTime(totalTime);
    }

    public void StopTimer()
    {
        timerIsRunning = false;
    }

}
