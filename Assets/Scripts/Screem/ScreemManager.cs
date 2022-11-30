using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreemManager : MonoBehaviour
{
    public GameObject mainScreem, timeScreem;

    void Start()
    {
        Screen.sleepTimeout = SleepTimeout.NeverSleep;
    }

    public void BackToMain()
    {
        mainScreem.SetActive(true);
        timeScreem.SetActive(false);
    }

    public void TimeScreem()
    {
        timeScreem.SetActive(true);
        mainScreem.SetActive(false);
    }

    public void ExitApp()
    {
        Application.Quit();
    }
}
