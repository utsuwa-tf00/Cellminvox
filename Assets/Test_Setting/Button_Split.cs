using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Button_Split : MonoBehaviour
{
    public Text Split_Text;
    public static int Split = 1;
    
    public void Start()
    {
        Split_Text.text = $"split : {Split}";
    }

    public void OnClick()
    {
        if(Split < 10) Split++;
        else Split = 1;
        
        Split_Text.text = $"split : {Split}";
    }
}
