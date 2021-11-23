using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Button_Range : MonoBehaviour
{
    public Text Range;

    public void Start()
    {
        Range.text = $"range : {Setting_GM.range_setting}";
    }
    
    public void OnClick()
    {
        if (Setting_GM.range_setting < 7) Setting_GM.range_setting++;
        else if (Setting_GM.range_setting >= 7) Setting_GM.range_setting = 2;

        Range.text = $"range : {Setting_GM.range_setting}";
    }
}
