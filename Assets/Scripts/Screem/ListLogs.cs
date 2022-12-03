using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListLogs : MonoBehaviour
{
    public GameObject listItem;

    public Logs logs;

    Days currentDay;

    void OnEnable()
    {
        logs = SaveSystem.LoadData();

        if (logs != null)
        {
            currentDay = logs.FindLastDay();
        }

        if (currentDay != null)
        {
            GameObject listIntemCopy = Instantiate(listItem, gameObject.transform);
            listIntemCopy.GetComponent<ListItem>().message = "Studing";
            listIntemCopy.GetComponent<ListItem>().time = currentDay.StateList.Studing;

            listIntemCopy = Instantiate(listItem, gameObject.transform);
            listIntemCopy.GetComponent<ListItem>().message = "Working";
            listIntemCopy.GetComponent<ListItem>().time = currentDay.StateList.Working;

            listIntemCopy = Instantiate(listItem, gameObject.transform);
            listIntemCopy.GetComponent<ListItem>().message = "Playing";
            listIntemCopy.GetComponent<ListItem>().time = currentDay.StateList.Playing;

            listIntemCopy = Instantiate(listItem, gameObject.transform);
            listIntemCopy.GetComponent<ListItem>().message = "Nothing";
            listIntemCopy.GetComponent<ListItem>().time = currentDay.StateList.Nothing;
        }
    }

    void OnDisable()
    {
        foreach (Transform child in transform)
        {
            Destroy(child.gameObject);
        }
    }
}
