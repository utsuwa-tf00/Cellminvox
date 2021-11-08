using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Title_Manager : MonoBehaviour
{
    private Title_Quad_Manager TQM;
    private Touch_Script TS;
    private Shake_Script SS;
    private Line_Script LS;

    public int select_setting = 0;

    private int time;
    private bool timekeeper;

    public bool delete;

    private bool vib;

    // Start is called before the first frame update
    void Start()
    {
        TQM = GameObject.Find("Quad").gameObject.GetComponent<Title_Quad_Manager>();
        TS = GetComponent<Touch_Script>();
        SS = GetComponent<Shake_Script>();
        LS = GetComponent<Line_Script>();
        time = 0;
        timekeeper = false;

        if (PlayerPrefs.HasKey("ClearTutorial"))
        {
            
        }
        else
        {
            SceneManager.LoadScene("Tutorial");
        }
    }

    //振動の実行
    void Vibration()
    {
        VibrationMng.ShortVibration();
    }

    // Update is called once per frame
    void Update()
    {
        if(delete == true)
        {
            PlayerPrefs.DeleteKey("ClearTutorial");
            delete = false;
        }

        LS.color_switch = true;

        if (TS.swipe_Y_minus == true && time == 0 && TQM.waveform_pos_x >= 0.9f)
        {
            Vibration();
            if (select_setting >= 2)
            {
                timekeeper = true;
                select_setting = 0;
                TS.swipe_Y_minus = false;
                TS.swipe_Y_plus = false;
            }
            else
            {
                timekeeper = true;
                select_setting++;
                TS.swipe_Y_minus = false;
                TS.swipe_Y_plus = false;
            }

        }

        if (TS.swipe_Y_plus == true && time == 0 && TQM.waveform_pos_x >= 0.9f)
        {
            Vibration();
            if (select_setting <= 0)
            {
                timekeeper = true;
                select_setting = 2;
                TS.swipe_Y_minus = false;
                TS.swipe_Y_plus = false;
            }
            else
            {
                timekeeper = true;
                select_setting--;
                TS.swipe_Y_minus = false;
                TS.swipe_Y_plus = false;
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

        if(SS.shake == true && vib == false)
        {
            Vibration();
            vib = true;
        }

        if (TQM.end_cg == true)
        {
            if (select_setting == 0)
            {
                SceneManager.LoadScene("Play");
                TQM.end_cg = false;
                SS.shake = false;
            }
            else if (select_setting == 1)
            {
                SceneManager.LoadScene("Setting");
                TQM.end_cg = false;
                SS.shake = false;
            }
            else if (select_setting == 2)
            {
                SceneManager.LoadScene("Tutorial");
                TQM.end_cg = false;
                SS.shake = false;
            }
            

        }

    }
}
