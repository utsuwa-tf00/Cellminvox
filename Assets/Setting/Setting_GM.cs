using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Setting_GM : MonoBehaviour
{
    public static bool auto_pich;
    public static bool double_tone;
    public static bool swipe_mode;
    public static bool wave_change;
    public static int range_setting = 4;
    public static string change_wave = "sin";
    public static int range_setting2 = 4;
    public static string change_wave2 = "sin";
    public static int pitch = 0;
    public static int pitch2 = 0;


    public bool auto_pich_text;
    public bool double_tone_text;
    public bool swipe_mode_text;
    public bool wave_change_text;
    public int range_setting_text;
    public string change_wave_text;
    public int range_setting_text2;
    public string change_wave_text2;
    public int pitch_text;
    public int pitch_text2;

    public int select_setting = 0;
    private int select_setting_Max = 11;

    private Setting_Quad_Manager SQM;
    private Touch_Script TS;
    private Shake_Script SS;
    private Line_Script LS;

    private int time;
    private bool timekeeper;

    public bool setting_end;

    private bool vib;


    // Start is called before the first frame update
    void Start()
    {
        SQM = GameObject.Find("Quad").gameObject.GetComponent<Setting_Quad_Manager>();
        TS = GetComponent<Touch_Script>();
        SS = GetComponent<Shake_Script>();
        LS = GetComponent<Line_Script>();
        time = 0;
        timekeeper = false;
    }

    //振動の実行
    void Vibration()
    {
        VibrationMng.ShortVibration();
    }

    void AutoPitch()
    {
        if (auto_pich == false)
        {
            auto_pich = true;
            SS.shake = false;
        }
        else if (auto_pich == true)
        {
            auto_pich = false;
            SS.shake = false;
        }
    }

    void MultiPhonic()
    {
        if (double_tone == false)
        {
            double_tone = true;
            SS.shake = false;
        }
        else if (double_tone == true)
        {
            double_tone = false;
            SS.shake = false;
        }
    }

    void SwipeMode()
    {
        if (swipe_mode == false)
        {
            swipe_mode = true;
            SS.shake = false;
        }
        else if (swipe_mode == true)
        {
            swipe_mode = false;
            SS.shake = false;
        }
    }

    void WaveChange()
    {
        if (wave_change == false)
        {
            wave_change = true;
            SS.shake = false;
        }
        else if (wave_change == true)
        {
            wave_change = false;
            SS.shake = false;
        }
    }

    void Wave1()
    {
        if (change_wave == "sin")
        {
            change_wave = "square";
            SS.shake = false;
        }
        else if (change_wave == "square")
        {
            change_wave = "triangle";
            SS.shake = false;
        }
        else if (change_wave == "triangle")
        {
            change_wave = "saw";
            SS.shake = false;
        }
        else if (change_wave == "saw")
        {
            change_wave = "sin";
            SS.shake = false;
        }
    }

    void Range1()
    {
        if (range_setting < 7)
        {
            range_setting++;
            SS.shake = false;
        }
        else if (range_setting >= 7)
        {
            range_setting = 2;
            SS.shake = false;
        }
    }

    void Pitch1()
    {
        if(pitch >= 6)
        {
            pitch = -6;
            SS.shake = false;
        }
        else
        {
            pitch++;
            SS.shake = false;
        }
    }

    void Wave2()
    {
        if (change_wave2 == "sin")
        {
            change_wave2 = "square";
            SS.shake = false;
        }
        else if (change_wave2 == "square")
        {
            change_wave2 = "triangle";
            SS.shake = false;
        }
        else if (change_wave2 == "triangle")
        {
            change_wave2 = "saw";
            SS.shake = false;
        }
        else if (change_wave2 == "saw")
        {
            change_wave2 = "sin";
            SS.shake = false;
        }
    }

    void Range2()
    {
        if (range_setting2 < 7)
        {
            range_setting2++;
            SS.shake = false;
        }
        else if (range_setting2 >= 7)
        {
            range_setting2 = 2;
            SS.shake = false;
        }
    }

    void Pitch2()
    {
        if(pitch2 >= 6)
        {
            pitch2 = -6;
            SS.shake = false;
        }
        else
        {
            pitch2++;
            SS.shake = false;
        }
    }

    void reset()
    {
        auto_pich = false;
        double_tone = false;
        swipe_mode = false;
        change_wave = "sin";
        range_setting = 4;
        pitch = 0;
        change_wave2 = "sin";
        range_setting2 = 4;
        pitch2 = 0;
        SS.shake = false;
    }

    void Back()
    {
        if(vib == false)
        {
            Vibration();
            vib = true;
        }
        setting_end = true;
    }

    void SwipeReset()
    {
        TS.swipe_Y_minus = false;
        TS.swipe_Y_plus = false;
    }

    void SDSwipemodeTrue()
    {
        if (select_setting >= select_setting_Max)
        {
            timekeeper = true;
            select_setting = 0;
            SwipeReset();
        }
        else if(select_setting == 1)
        {
            timekeeper = true;
            select_setting = 3;
            SwipeReset();
        }
        else if(select_setting >= 6 && select_setting < select_setting_Max-1)
        {
            timekeeper = true;
            select_setting = select_setting_Max-1;
            SwipeReset();
        }
        else
        {
            timekeeper = true;
            select_setting++;
            SwipeReset();
        }
    }

    void SDSwipemodeFalse()
    {
        if (select_setting >= select_setting_Max)
        {
            timekeeper = true;
            select_setting = 0;
            SwipeReset();
        }
        else if(select_setting >= 6 && select_setting < select_setting_Max-1)
        {
            timekeeper = true;
            select_setting = select_setting_Max-1;
            SwipeReset();
        }
        else
        {
            timekeeper = true;
            select_setting++;
            SwipeReset();
        }
    }

    void SDDoubleTrue()
    {
        if (select_setting >= select_setting_Max)
        {
            timekeeper = true;
            select_setting = 0;
            SwipeReset();
        }
        else if(select_setting == 2)
        {
            timekeeper = true;
            select_setting = 4;
            SwipeReset();
        }
        else
        {
            timekeeper = true;
            select_setting++;
            SwipeReset();
        }
    }

    void SDDoubleFalse()
    {
        if(swipe_mode == true)
        {
            SDSwipemodeTrue();
        }
        else
        {
            SDSwipemodeFalse();
        }
    }

    void SwipeDown()
    {
        if(double_tone == false)
        {
            SDDoubleFalse();
        }
        else if(double_tone == true)
        {
            SDDoubleTrue();
        }
    }

    void SUSwipemodeTrue()
    {
        if (select_setting <= 0)
        {
            timekeeper = true;
            select_setting = select_setting_Max;
            SwipeReset();
        }
        else if(select_setting == 3)
        {
            timekeeper = true;
            select_setting = 1;
            SwipeReset();
        }
        else if(select_setting > 6 && select_setting <= select_setting_Max-1)
        {
            timekeeper = true;
            select_setting = 6;
            SwipeReset();
        }
        else
        {
            timekeeper = true;
            select_setting--;
            SwipeReset();
        }
    }

    void SUSwipemodeFalse()
    {
        if (select_setting <= 0)
        {
            timekeeper = true;
            select_setting = select_setting_Max;
            SwipeReset();
        }
        else if(select_setting > 6 && select_setting <= select_setting_Max-1)
        {
            timekeeper = true;
            select_setting = 6;
            SwipeReset();
        }
        else
        {
            timekeeper = true;
            select_setting--;
            SwipeReset();
        }
    }

    void SUDoubleTrue()
    {
        if (select_setting <= 0)
        {
            timekeeper = true;
            select_setting = select_setting_Max;
            SwipeReset();
        }
        else if(select_setting == 4)
        {
            timekeeper = true;
            select_setting = 2;
            SwipeReset();
        }
        else
        {
            timekeeper = true;
            select_setting--;
            SwipeReset();
        }
    }

    void SUDoubleFalse()
    {
        if(swipe_mode == true)
        {
            SUSwipemodeTrue();
        }
        else
        {
            SUSwipemodeFalse();
        }
    }

    void SwipeUp()
    {
        if(double_tone == false)
        {
            SUDoubleFalse();
        }
        else if(double_tone == true)
        {
            SUDoubleTrue();
        }
    }


    // Update is called once per frame
    void Update()
    {
        LS.color_switch = false;

        auto_pich_text = auto_pich;
        double_tone_text = double_tone;
        swipe_mode_text = swipe_mode;
        wave_change_text = wave_change;
        range_setting_text = range_setting;
        change_wave_text = change_wave;
        range_setting_text2 = range_setting2;
        change_wave_text2 = change_wave2;
        pitch_text = pitch;
        pitch_text2 = pitch2;

        if(time == 0)
        {
            if (TS.swipe_Y_minus == true)
            {
                Vibration();
                SwipeDown();
            }
            else if (TS.swipe_Y_plus == true)
            {
                Vibration();
                SwipeUp();
            }
        }

        if (timekeeper == true)
        {
            time++;
            if (time >= 20)
            {
                time = 0;
                timekeeper = false;
            }
        }

        if (SS.shake == true && TS.back == false)
        {
            if (select_setting == 0)
            {
                Vibration();
                AutoPitch();
            }
            else if (select_setting == 1)
            {
                Vibration();
                WaveChange();
            }
            else if (select_setting == 2)
            {
                Vibration();
                MultiPhonic();
            }
            else if (select_setting == 3)
            {
                Vibration();
                SwipeMode();
            }
            else if (select_setting == 4)
            {
                Vibration();
                Wave1();
            }
            else if (select_setting == 5)
            {
                Vibration();
                Range1();
            }
            else if (select_setting == 6)
            {
                Vibration();
                Pitch1();
            }
            else if (select_setting == 7)
            {
                Vibration();
                Wave2();
            }
            else if (select_setting == 8)
            {
                Vibration();
                Range2();
            }
            else if (select_setting == 9)
            {
                Vibration();
                Pitch2();
            }
            else if (select_setting == 10)
            {
                Vibration();
                reset();
            }
            else if (select_setting == 11)
            {
                Back();
            }
        }

        if (TS.back == true && SS.shake == true)
        {
            if(vib == false)
            {
                Vibration();
                vib = true;
            }
            setting_end = true;
        }

        if (SQM.end_cg == true)
        {
            setting_end = false;
            SS.shake = false;
            SceneManager.LoadScene("Title");
        }
    }
}
