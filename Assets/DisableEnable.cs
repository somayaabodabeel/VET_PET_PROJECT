using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class DisableEnable : MonoBehaviour
{
    public GameObject rightframe;
    public bool isEnabled = true;
    public void ButtonClicked()
    {
        isEnabled = !isEnabled;
        rightframe.SetActive(isEnabled);
    }
}
