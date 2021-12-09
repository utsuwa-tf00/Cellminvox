using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_Quad_Split : MonoBehaviour
{
    public Material Back;
    
    // Start is called before the first frame update
    void Start()
    {
        Back.SetInt("_SquareNum",Button_Split.Split); 
    }
}
