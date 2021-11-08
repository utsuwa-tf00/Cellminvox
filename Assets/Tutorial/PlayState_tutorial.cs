using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayState_tutorial : MonoBehaviour
{
    public GameObject TM;
    private Tutorial_Manager T_TM;
    private Shake_Script SS;
    private Touch_Script TS;
    public string wave_name;

    // Start is called before the first frame update
    void Start()
    {
        T_TM = TM.GetComponent<Tutorial_Manager>();
        SS = GetComponent<Shake_Script>();
        TS = GetComponent<Touch_Script>();
        wave_name = Setting_GM.change_wave;
    }

    // Update is called once per frame
    void Update()
    {
        if (SS.shake == true && TS.back == false && T_TM.page >= 2)
        {
            if (wave_name == "sin")
            {
                wave_name = "square";
                SS.shake = false;
            }
            else if (wave_name == "square")
            {
                wave_name = "triangle";
                SS.shake = false;
            }
            else if (wave_name == "triangle")
            {
                wave_name = "saw";
                SS.shake = false;
            }
            else if (wave_name == "saw")
            {
                wave_name = "sin";
                SS.shake = false;
            }
        }
    }
}
