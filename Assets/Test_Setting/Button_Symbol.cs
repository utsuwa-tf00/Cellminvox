using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Button_Symbol : MonoBehaviour
{
    public Text Symbol_Text;
    public static bool Symbol;

    public void Start()
    {
        Symbol_Text.text = $"symbol : {Symbol}";
    }

    public void OnClick()
    {
        if(Symbol == true) Symbol = false;
        else Symbol = true;

        Symbol_Text.text = $"symbol : {Symbol}";
    }
}
