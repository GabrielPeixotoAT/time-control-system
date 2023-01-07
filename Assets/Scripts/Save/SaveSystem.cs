using System.IO;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;
using System;

public static class SaveSystem
{
    public static Logs logs;

    public static States states = new States();

    public static void SetStates(string working, string studing, string playing)
    {
        states.Working = (states.Working != "00:00:00") ? IncreseTime(states.Working, working) : working;

        states.Studing = (states.Studing != "00:00:00") ? IncreseTime(states.Studing, studing) : studing;

        states.Playing = (states.Playing != "00:00:00") ? IncreseTime(states.Playing, playing) : playing;
    }

    public static void SaveLogs()
    {
        PlayerPrefs.SetString("Working", states.Working);
        PlayerPrefs.SetString("Studing", states.Studing);
        PlayerPrefs.SetString("Playing", states.Playing);
    }

    public static string[] LoadLogs()
    {
        string working = PlayerPrefs.GetString("Working", "00:00:00");
        string studing = PlayerPrefs.GetString("Studing", "00:00:00");
        string playing = PlayerPrefs.GetString("Playing", "00:00:00");

        return new string[] { working, studing, playing };
    }

    private static string IncreseTime(string timeOne, string timeTwo)
    {
        TimeSpan timeSpan = TimeSpan.ParseExact(timeOne, @"hh\:mm\:ss", System.Globalization.CultureInfo.InvariantCulture) 
            + TimeSpan.ParseExact(timeTwo, @"hh\:mm\:ss", System.Globalization.CultureInfo.InvariantCulture);

        return timeSpan.ToString(@"hh\:mm\:ss");
    }

    public static void SaveData()
    {
        BinaryFormatter formatter = new BinaryFormatter();

        string path = Application.persistentDataPath + "/logs.fun";
        FileStream stream = new FileStream(path, FileMode.Create);

        formatter.Serialize(stream, logs);
        stream.Close();
    }

    public static Logs LoadData()
    {
        string path = Application.persistentDataPath + "/logs.fun";
        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            Logs logs = formatter.Deserialize(stream) as Logs;
            stream.Close();

            return logs;
        }
        else
        {
            Debug.LogError("Save file not found in" + path);
            return null;
        }
    }
}
