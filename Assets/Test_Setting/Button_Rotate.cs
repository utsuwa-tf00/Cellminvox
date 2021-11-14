using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Button_Rotate : MonoBehaviour
{
    public Text Rotate_Text;
    public static bool Rotate;

    public void OnClick()
    {
        if(Rotate == true)
        {
            Rotate = false;
            Rotate_Text.text = "rotate : false";
        }
        else 
        {
            Rotate = true;
            Rotate_Text.text = "rotate : true";
        }
    }
}
