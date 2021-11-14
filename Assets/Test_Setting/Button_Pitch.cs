using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Button_Pitch : MonoBehaviour
{
    public Text Pitch;

    public void OnClick()
    {
        if(Setting_GM.pitch >= 6)
        {
            Setting_GM.pitch = -6;
            Pitch.text = "pitch : -6";
        }
        else
        {
            Setting_GM.pitch++;
            Pitch.text = "pitch : " + Setting_GM.pitch;
        }
    }
}
