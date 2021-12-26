using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Button_Double : MonoBehaviour
{
    public Text Double;

    public void Start()
    {
        Double.text = $"Double : {Setting_GM.wave_change}";
    }

    public void OnClick()
    {
        if(Setting_GM.wave_change == true) Setting_GM.wave_change = false;
        else Setting_GM.wave_change = true;

        Double.text = $"Double : {Setting_GM.wave_change}";
    }
}
