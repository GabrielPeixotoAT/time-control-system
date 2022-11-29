using System;
using UnityEngine;
using TMPro;

public class Task : MonoBehaviour
{
    public TMP_Text taskClock;

    float taskTime, refTime;
    int currentTask;

    void Update()
    {
        switch (currentTask)
        {
            case 1:
                TimeIncremet();
                break;
        }
    }

    public void TaskChange(int index)
    {
        currentTask = index;
        refTime = Time.time;
    }
    
    void TimeIncremet()
    {
        if (refTime < Time.time)
        {
            refTime++;
            taskTime++;
            taskClock.text = TimeSpan.FromSeconds(taskTime).ToString();
        }
    }
}
