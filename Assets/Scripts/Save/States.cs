using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class States
{
    public string Studing;
    public string Working;
    public string Playing;
    public string Nothing;

    public States()
    {
        Working = "00:00:00";
        Studing = "00:00:00";
        Playing = "00:00:00";
        Nothing = "00:00:00";
    }

    public override string ToString()
    {
        return "Studing: " + Studing
            + "\nWorking: " + Working
            + "\nPlaying: " + Playing
            + "\nNothing: " + Nothing;
    }
}
