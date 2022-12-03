using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;

public static class SaveSystem
{
    public static Logs logs;

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
