using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Button_Pitch2 : MonoBehaviour
{
    public Text Pitch2;

    public void Start()
    {
        Pitch2.text = $"pitch2 : {Setting_GM.pitch2}";
    }

    public void OnClick()
    {
        if(Setting_GM.pitch2 >= 6) Setting_GM.pitch2 = -6;
        else Setting_GM.pitch2++;

        Pitch2.text = $"pitch2 : {Setting_GM.pitch2}";
    }
}
