using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Logs
{
    public List<Days> DaysList;

    public Logs(List<Days> daysList)
    {
        DaysList = daysList;
    }


    public void AddDay(string studing, string working, string playing, string nothing)
    {
        Days lastDay = FindLastDay();
        string toDay = DateTime.Now.ToString("dd/MM/yyyy");

        if (lastDay.Date == toDay)
        {
            Debug.LogWarning(studing + " old: " + lastDay.StateList.Studing);
            TimeSpan timeSpan = TimeSpan.Parse(lastDay.StateList.Studing) + TimeSpan.Parse(studing);
            lastDay.StateList.Studing = timeSpan.ToString(@"hh\:mm\:ss");

            timeSpan = TimeSpan.Parse(lastDay.StateList.Working) + TimeSpan.Parse(working);
            lastDay.StateList.Working = timeSpan.ToString(@"hh\:mm\:ss");

            timeSpan = TimeSpan.Parse(lastDay.StateList.Playing) + TimeSpan.Parse(playing);
            lastDay.StateList.Playing = timeSpan.ToString(@"hh\:mm\:ss");

            timeSpan = TimeSpan.Parse(lastDay.StateList.Nothing) + TimeSpan.Parse(nothing);
            lastDay.StateList.Nothing = timeSpan.ToString(@"hh\:mm\:ss");
        }
        else
        {
            States states = new() { Studing = studing, Working = working, Playing = playing, Nothing = nothing };
            Days day = new(toDay, states);

            DaysList.Add(day);
        }
    }

    public Days FindLastDay()
    {
        foreach (Days day in DaysList)
        {
            if (DaysList.IndexOf(day) == DaysList.Count - 1)
            {
                return day;
            }
        }

        return null;
    }
}
