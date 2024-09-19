using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Timer : MonoBehaviour
{
    float timer = 200f;
    bool timerRunnning = true;
    public TextMeshProUGUI timeText;
    public GameObject Alarm;

    // Update is called once per frame
    void Update()
    {   if (timerRunnning)
        {
            if (timer > 0)
            {
                timer -= Time.deltaTime;
            }
            else
            {
                timer = 0;
                Alarm.SetActive(true);
                timerRunnning = false;
            }
        }

        //calculate time remaining;
        float minutes = Mathf.FloorToInt(timer / 60);
        float seconds = Mathf.FloorToInt(timer % 60);
        float seconds2 = Mathf.FloorToInt(timer);
        float milliSeconds = (timer % 1) * 1000;


        if (timer > 180f)
        {
            timeText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
        }
        else if (timer > 0)
        {
            timeText.text = string.Format("{0:000}.{1:000}", seconds2, milliSeconds);
        }
        else
        {
            timeText.text = "0.000";
        }
    }


}
