using System;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Task : MonoBehaviour
{
    public TMP_Text taskClock;

    string Studing = "00:00:00", Working = "00:00:00", Playing = "00:00:00", Nothing = "00:00:00";

    States states;

    float taskTime, refTime;
    int currentTask = 3;

    void Start()
    {
        states = new States();
    }

    void Update()
    {
        switch (currentTask)
        {
            case 0:
                TimeIncremet();
                break;
            case 1:
                TimeIncremet();
                break;
            case 2:
                TimeIncremet();
                break;
            case 3:
                
                break;
        }
    }

    public void TaskChange(int index)
    {
        SetStateTime();

        if (SaveSystem.logs == null)
        {
            List<Days> days = new List<Days>();

            days.Add(CreteDay());

            SaveSystem.logs = new Logs(days);
        }
        else
        {
            SaveSystem.logs.AddDay(Studing, Working, Playing, Nothing);
        }

        SaveSystem.SaveData();
        
        ResetTime();
        currentTask = index;
        refTime = Time.time;
    }

    void SetStateTime()
    {
        switch (currentTask)
        {
            case 0:
                Studing = taskClock.text;
                break;
            case 1:
                Working = taskClock.text;
                break;
            case 2:
                Playing = taskClock.text;
                break;
            case 3:
                Nothing = taskClock.text;
                break;
        }
    }
    
    void ResetTime()
    {
        taskTime = 0;
        taskClock.text = "00:00:00";
        Studing = "00:00:00";
        Working = "00:00:00";
        Playing = "00:00:00";
        Nothing = "00:00:00";
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

    Days CreteDay()
    {
        return new Days(DateTime.Now.ToString("dd/MM/yyyy"), states);
    }
}
