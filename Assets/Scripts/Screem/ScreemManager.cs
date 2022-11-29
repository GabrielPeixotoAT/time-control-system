using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreemManager : MonoBehaviour
{
    void Start()
    {
        Screen.sleepTimeout = SleepTimeout.NeverSleep;
    }
}
