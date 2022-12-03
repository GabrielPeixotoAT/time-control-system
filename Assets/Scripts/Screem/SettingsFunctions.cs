using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class SettingsFunctions : MonoBehaviour
{
    public TMP_Text[] texts;
    public TMP_Dropdown[] dropdowns;
    public Button[] buttons;
    public Image[] dropdownItenBackgorunds;

    public void SetColor()
    {
        foreach (TMP_Text text in texts)
        {
            text.color = gameObject.GetComponent<ScreenSettings>().fontColor;   
        }

        foreach (TMP_Dropdown drop in dropdowns)
        {
            drop.GetComponent<Image>().color = gameObject.GetComponent<ScreenSettings>().fontColor;
        }

        foreach (Image image in dropdownItenBackgorunds)
        {
            image.color = gameObject.GetComponent<ScreenSettings>().fontColor; ;
        }

        foreach (Button btn in buttons)
        {
            btn.GetComponent<Image>().color = gameObject.GetComponent<ScreenSettings>().fontColor;
        }
    }

    public void ChangeFontColor(int index)
    {
        switch (index)
        {
            case 0:
                gameObject.GetComponent<ScreenSettings>().fontColor = new Color32(0, 255, 0, 255);
                SetColor();
                break;
            case 1:
                gameObject.GetComponent<ScreenSettings>().fontColor = new Color32(0, 0, 255, 255);
                SetColor();
                break;
            case 2:
                gameObject.GetComponent<ScreenSettings>().fontColor = new Color32(255, 0, 0, 255);
                SetColor();
                break;
            case 3:
                gameObject.GetComponent<ScreenSettings>().fontColor = new Color32(255, 255, 0, 255);
                SetColor();
                break;
            case 4:
                gameObject.GetComponent<ScreenSettings>().fontColor = new Color32(255, 255, 255, 255);
                SetColor();
                break;
            case 5:
                gameObject.GetComponent<ScreenSettings>().fontColor = new Color32(255, 0, 255, 255);
                SetColor();
                break;
            case 6:
                gameObject.GetComponent<ScreenSettings>().fontColor = new Color32(0, 255, 255, 255);
                SetColor();
                break;
            case 7:
                gameObject.GetComponent<ScreenSettings>().fontColor = new Color32(255, 128, 0, 255);
                SetColor();
                break;
            default:
                gameObject.GetComponent<ScreenSettings>().fontColor = new Color32(0, 255, 0, 255);
                SetColor();
                break;
        }
    }

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
