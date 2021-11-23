using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Button_WaveChange : MonoBehaviour
{
    public Text WaveChange;

    public void Start()
    {
        WaveChange.text = $"wave change : {Setting_GM.wave_change}";
    }

    public void OnClick()
    {
        if(Setting_GM.wave_change == true) Setting_GM.wave_change = false;
        else Setting_GM.wave_change = true;

        WaveChange.text = $"wave change : {Setting_GM.wave_change}";
    }
}
