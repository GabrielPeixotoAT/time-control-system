using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ListLogs : MonoBehaviour
{
    public GameObject listItem;
    public ScreenSettings settings;

    public string[] logs;

    void OnEnable()
    {
        logs = SaveSystem.LoadLogs();

        GameObject listIntemCopy = Instantiate(listItem, gameObject.transform);
        listIntemCopy.GetComponent<ListItem>().message = "Studing";
        listIntemCopy.GetComponent<ListItem>().time = logs[1];
        listIntemCopy.GetComponent<TMP_Text>().color = settings.fontColor;

        listIntemCopy = Instantiate(listItem, gameObject.transform);
        listIntemCopy.GetComponent<ListItem>().message = "Working";
        listIntemCopy.GetComponent<ListItem>().time = logs[0];
        listIntemCopy.GetComponent<TMP_Text>().color = settings.fontColor;

        listIntemCopy = Instantiate(listItem, gameObject.transform);
        listIntemCopy.GetComponent<ListItem>().message = "Playing";
        listIntemCopy.GetComponent<ListItem>().time = logs[2];
        listIntemCopy.GetComponent<TMP_Text>().color = settings.fontColor;

        listIntemCopy = Instantiate(listItem, gameObject.transform);
        listIntemCopy.GetComponent<ListItem>().message = "Nothing";
        listIntemCopy.GetComponent<ListItem>().time = "00:00:00";
        listIntemCopy.GetComponent<TMP_Text>().color = settings.fontColor;
    }

    void OnDisable()
    {
        foreach (Transform child in transform)
        {
            Destroy(child.gameObject);
        }
    }
}
