using System;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Clock : MonoBehaviour
{
    public bool isClock;

    void Update()
    {
        if (isClock)
        {
            gameObject.GetComponent<TMP_Text>().text = DateTime.Now.ToString("HH:mm:ss");
        }
        else
        {
            gameObject.GetComponent<TMP_Text>().text = DateTime.Now.ToString("dd/MM/yyyy");

        }
    }
}
