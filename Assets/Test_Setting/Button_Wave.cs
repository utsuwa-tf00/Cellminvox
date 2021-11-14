using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Button_Wave : MonoBehaviour
{
    public Text Wave;

    public void OnClick()
    {
        if(Setting_GM.change_wave == "sin")
        {
            Setting_GM.change_wave = "square";
            Wave.text = "wave : square";
        }
        else if(Setting_GM.change_wave == "square")
        {
            Setting_GM.change_wave = "triangle";
            Wave.text = "wave : triangle";
        }
        else if(Setting_GM.change_wave == "triangle")
        {
            Setting_GM.change_wave = "saw";
            Wave.text = "wave : saw";
        }
        else if(Setting_GM.change_wave == "saw")
        {
            Setting_GM.change_wave = "sin";
            Wave.text = "wave : sin";
        }
    }
}
