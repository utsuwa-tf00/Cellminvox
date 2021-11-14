using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

 
public class ButtonScript : MonoBehaviour 
{

    public void OnClick()
    {
        if(Button_SymbolPattern.SymbolPattern == false)
        {
            SceneManager.LoadScene("Test_Play");
        }
        else
        {
            SceneManager.LoadScene("Test_Play_SymbolPattern");
        }
    }
}