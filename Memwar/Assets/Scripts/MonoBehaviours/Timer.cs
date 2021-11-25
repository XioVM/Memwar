using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : AppObject
{
    public float timeRemaining = 10f;
    public bool timerIsRunning = false;
    public Text timerText;

    // Start is called before the first frame update
   private void Start()
    {
        timerIsRunning = true;
    }

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
                timerIsRunning = false;
            }

        }
    }

    void DisplayTime(float timeToDisplay)
    {
        //el tiempo real 5 segundos son 6 porque se cuenta el 0
        timeToDisplay += 1;
        //Mathf es la libreria de unity de matematicas, floortoint es redondear la cantidad hacia abajo, en plan 2.9 lo redondea a 2 

        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);

        //Formato si le envias un codigo de alguna linea de texto podra imprimirlo automaticamente en el formato que tu le envies 

        timerText.text = string.Format("{00:00}:{1:00}", minutes, seconds);

    }

}
