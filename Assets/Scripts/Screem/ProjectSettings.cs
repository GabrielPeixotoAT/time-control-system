using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ProjectSettings : MonoBehaviour
{
    public TMP_Text buildVersion;

    void Start()
    {
        buildVersion.text = "********** build version " + Application.version + " **********";
    }
}
