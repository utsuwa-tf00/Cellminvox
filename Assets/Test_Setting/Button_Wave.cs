using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Button_Wave : MonoBehaviour
{
    public Text Wave;

    public void Start()
    {
        Wave.text = "wave : " + Setting_GM.change_wave;
    }
    public void OnClick()
    {
        if(Setting_GM.change_wave == "sin") Setting_GM.change_wave = "square";
        else if(Setting_GM.change_wave == "square") Setting_GM.change_wave = "triangle";
        else if(Setting_GM.change_wave == "triangle") Setting_GM.change_wave = "saw";
        else if(Setting_GM.change_wave == "saw") Setting_GM.change_wave = "sin";

        Wave.text = "wave : " + Setting_GM.change_wave;
    }
}
