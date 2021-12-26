using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Button_Range2 : MonoBehaviour
{
    public Text Range2;

    public void Start()
    {
        Range2.text = $"range2 : {Setting_GM.range_setting2}";
    }
    
    public void OnClick()
    {
        if (Setting_GM.range_setting2 < 7) Setting_GM.range_setting2++;
        else if (Setting_GM.range_setting2 >= 7) Setting_GM.range_setting2 = 2;

        Range2.text = $"range2 : {Setting_GM.range_setting2}";
    }
}
