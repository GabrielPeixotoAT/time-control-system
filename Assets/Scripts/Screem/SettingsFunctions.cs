using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingsFunctions : MonoBehaviour
{
    public void ChangeBackgorund(int index)
    {
        switch (index)
        {
            case 0:
                gameObject.GetComponent<ScreenSettings>().background.color = new Color32(0, 0, 0, 255);
                break;
            case 1:
                gameObject.GetComponent<ScreenSettings>().background.color = new Color32(25, 25, 27, 255);
                break;
            case 2:
                gameObject.GetComponent<ScreenSettings>().background.color = new Color32(0, 25, 0, 255);
                break;
            case 3:
                gameObject.GetComponent<ScreenSettings>().background.color = new Color32(0, 0, 25, 255);
                break;
            case 4:
                gameObject.GetComponent<ScreenSettings>().background.color = new Color32(25, 0, 0, 255);
                break;
            default:
                gameObject.GetComponent<ScreenSettings>().background.color = new Color32(0, 0, 0, 255);
                break;
        }
    }
}
