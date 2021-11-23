using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Button_AutoPitch : MonoBehaviour
{
    public Text AutoPitch;

    public void Start()
    {
        AutoPitch.text = $"auto pitch : {Setting_GM.auto_pich}";
    }

    public void OnClick()
    {
        if(Setting_GM.auto_pich == true) Setting_GM.auto_pich = false;
        else Setting_GM.auto_pich = true;

        AutoPitch.text = $"auto pitch : {Setting_GM.auto_pich}";
    }
}
