using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Button_Wave2 : MonoBehaviour
{
    public Text Wave2;

    public void Start()
    {
        Wave2.text = $"wave2 : {Setting_GM.change_wave2}";
    }
    public void OnClick()
    {
        if(Setting_GM.change_wave2 == "sin") Setting_GM.change_wave2 = "square";
        else if(Setting_GM.change_wave2 == "square") Setting_GM.change_wave2 = "triangle";
        else if(Setting_GM.change_wave2 == "triangle") Setting_GM.change_wave2 = "saw";
        else if(Setting_GM.change_wave2 == "saw") Setting_GM.change_wave2 = "sin";

        Wave2.text = $"wave2 : {Setting_GM.change_wave2}";
    }
}
