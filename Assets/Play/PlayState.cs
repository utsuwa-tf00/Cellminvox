using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayState : MonoBehaviour
{
    public GameObject P;
    private Play_Manager PM;
    private Shake_Script SS;
    private Touch_Script TS;
    public string wave_name;

    // Start is called before the first frame update
    void Start()
    {
        SS = GetComponent<Shake_Script>();
        TS = GetComponent<Touch_Script>();
        PM = P.GetComponent<Play_Manager>();
        wave_name = Setting_GM.change_wave;
    }

    //振動の実行
    void Vibration()
    {
        VibrationMng.ShortVibration();
    }

    // Update is called once per frame
    void Update()
    {
        if (SS.shake == true && TS.back == false && Setting_GM.wave_change == false)
        {
            if(Setting_GM.double_tone == true)
            {
                if(PM.rotate_now == false)
                {
                    if (wave_name == "sin")
                    {
                        wave_name = "square";
                        Vibration();
                    }
                    else if (wave_name == "square")
                    {
                        wave_name = "triangle";
                        Vibration();
                    }
                    else if (wave_name == "triangle")
                    {
                        wave_name = "saw";
                        Vibration();
                    }
                    else if (wave_name == "saw")
                    {
                        wave_name = "sin";
                        Vibration();
                    }
                    SS.shake = false;
                }
                else
                {
                    SS.shake = false;
                }
            }
            else
            {
                if (wave_name == "sin")
                    {
                        wave_name = "square";
                        Vibration();
                        SS.shake = false;
                    }
                    else if (wave_name == "square")
                    {
                        wave_name = "triangle";
                        Vibration();
                        SS.shake = false;
                    }
                    else if (wave_name == "triangle")
                    {
                        wave_name = "saw";
                        Vibration();
                        SS.shake = false;
                    }
                    else if (wave_name == "saw")
                    {
                        wave_name = "sin";
                        Vibration();
                        SS.shake = false;
                    }
            }
        }
    }
}
