using System;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Task : MonoBehaviour
{
    public TMP_Text TaskClock;

    string studing = "00:00:00", working = "00:00:00", playing = "00:00:00", nothing = "00:00:00";

    float taskTime, refTime;
    int currentTask = 3;

    void Start()
    {
        string[] logs = new string[3];

        logs = SaveSystem.LoadLogs();

        working = logs[0];
        studing = logs[1];
        playing = logs[2];
    }

    void Update()
    {
        if (currentTask != 3)
        {
            TimeIncremet();
        }
    }

    public void TaskChange(int index)
    {
        SetStateTime();

        SaveSystem.SetStates(working, studing, playing);

        SaveSystem.SaveLogs();
        
        ResetTime();
        currentTask = index;
        refTime = Time.time;
    }

    void SetStateTime()
    {
        switch (currentTask)
        {
            case 0:
                studing = TaskClock.text;
                break;
            case 1:
                working = TaskClock.text;
                break;
            case 2:
                playing = TaskClock.text;
                break;
            case 3:
                nothing = TaskClock.text;
                break;
        }
    }
    
    void ResetTime()
    {
        taskTime = 0;
        TaskClock.text = "00:00:00";
        studing = "00:00:00";
        working = "00:00:00";
        playing = "00:00:00";
        nothing = "00:00:00";
    }

    void TimeIncremet()
    {
        if (refTime < Time.time)
        {
            refTime++;
            taskTime++;
            TaskClock.text = TimeSpan.FromSeconds(taskTime).ToString();
        }
    }
}
