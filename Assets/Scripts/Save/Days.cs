using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Days
{
    public string Date;
    public States StateList;

    public Days(string date, States stateList)
    {
        Date = date;
        StateList = stateList;
    }
}
