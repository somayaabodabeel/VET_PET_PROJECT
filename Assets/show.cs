using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class show : MonoBehaviour
{

    public GameObject menueUI;
    private bool click;
    public void ShowTheMenue()
    {
        click = !click;
        menueUI.SetActive(click);
    }


}

