using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ListItem : MonoBehaviour
{
    public string message, time;

    void Start()
    {
        gameObject.GetComponent<TMP_Text>().text = message + " - " + time;
    }
}
