using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Button_SymbolPattern : MonoBehaviour
{
    public Text SymbolPattern_Text;
    public static bool SymbolPattern;

    public void OnClick()
    {
        if(SymbolPattern == true)
        {
            SymbolPattern = false;
            SymbolPattern_Text.text = "symbol pattern : false";
        }
        else 
        {
            SymbolPattern = true;
            SymbolPattern_Text.text = "symbol pattern : true";
        }
    }
}
