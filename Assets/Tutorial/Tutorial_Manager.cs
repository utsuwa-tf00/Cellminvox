using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Tutorial_Manager : MonoBehaviour
{
    public GameObject TQ;
    private Tutorial_Quad_Setting T_TQ;
    private Touch_Script TS;
    private Shake_Script SS;

    public GameObject Canvas;
    private T_Canvas_Move TCM;

    public GameObject Cellmin;
    private PlayState_tutorial PS;
    public GameObject Swipe;

    public Material line;
    public Material circle;
    public Material Image;
    public Material Back;

    public GameObject sin;
    public GameObject square;
    public GameObject triangle;
    public GameObject saw;

    public Text TutorialName;
    public Text EX1;
    public Text EX2;
    public Text WaveName;
    public Text line1;
    public Text line2;
    public Text NextTutorial;
    public Text line3;
    public Text line4;

    private string wave_name;

    public int page;
    public bool Col_Change;
    public float col;
    private float alpha = 1;
    private float Col_S = 0.4f;
    private float Col_E0 = 0.05f;
    private float Col_E1 = 0.9f;
    private float Col_T1;
    private float Col_T2;
    private float Col_T3;
    private float Col_T4;
    private float Col_T5;
    private float Col_T6;
    private float Col_T2_p;
    private float Col_T3_p;
    private float Col_T4_p;
    private float Col_T5_p;
    private float Col_T6_p;

    public bool clear_tutorial;

    public int select_setting;
    private int time;
    private bool timekeeper;

    public float timer = 15;
    public int timer_seconds;

    private bool vib;
    private bool vibS;
    

    // Start is called before the first frame update
    void Start()
    {
        T_TQ = TQ.GetComponent<Tutorial_Quad_Setting>();
        TS = GetComponent<Touch_Script>();
        SS = GetComponent<Shake_Script>();
        PS = Cellmin.GetComponent<PlayState_tutorial>();
        TCM = Canvas.GetComponent<T_Canvas_Move>();
    }

    //振動の実行
    void Vibration()
    {
        VibrationMng.ShortVibration();
    }

    //チュートリアルページクリア時の処理
    void Clear_T()
    {
        TCM.posReset = false;
        if(T_TQ.end_cg == true){
            if(page >= 5)
            {
                PlayerPrefs.SetInt("ClearTutorial" , 1);
                BackToTitle();
            }
            else
            {
                page++;
                TCM.posReset = true;
                clear_tutorial = false;
                T_TQ.end_cg = false;
                T_TQ.pos_x = 1.5f;    
                select_setting = 0;
                T_TQ.waveform_pos_x = 1.5f;
                T_TQ.waveform_pos_y = 0.5f;
                SS.shake = false;
                vib = false;
            }
        }
    }

    //タイトルに戻る
    void BackToTitle()
    {
        if (PlayerPrefs.HasKey("ClearTutorial"))
        {
            SceneManager.LoadScene("Title");
        }
        else
        {
            
        }
    }

    void BackMove()
    {
        if(SS.shake == true){
            if(TS.back == true){
                Vibration();
                BackToTitle();
                SS.shake = false;
            }
            else
            {
                SS.shake = false;
            }
        }
    }

    //０ページ目の処理
    void Page0()
    {
        Cellmin.SetActive(false);
        Swipe.SetActive(false);
        Col_Change = true;

        timer -= Time.deltaTime;
        timer_seconds = Mathf.CeilToInt(timer);
        if(timer_seconds < 0 && vib == false){
            Vibration();
            clear_tutorial = true;
            vib = true;
        }

        if(SS.shake == true){
            SS.shake = false;
        }

        BackMove();
    }

    //1ページ目の処理
    void Page1()
    {
        Cellmin.SetActive(true);
        Swipe.SetActive(true);
        Col_Change = false;

        if(T_TQ.waveform_pos_y <= 0.31f && T_TQ.waveform_pos_y >= 0.29f && select_setting == 2){
            if(vib == false){
                Vibration();
                vib = true;
            }
            clear_tutorial = true;
        }

        if(SS.shake == true){
            SS.shake = false;
        }

        BackMove();
    }

    //2ページ目の処理
    void Page2()
    {
        Col_Change = true;

        if(SS.shake == true && TS.back == false)
        {
            if(T_TQ.waveform_pos_y <= 0.31f && T_TQ.waveform_pos_y >= 0.29f && select_setting == 2)
            {
                if(vib == false){
                Vibration();
                vib = true;
                }
                clear_tutorial = true;
                SS.shake = false;
            }
            else
            {
                Vibration();
                SS.shake = false;
            }
        }

        BackMove();
    }

    //3ページ目の処理
    void Page3()
    {
        Col_Change = false;

        if(SS.shake == true && TS.back == false)
        {
            if(T_TQ.waveform_pos_y <= 0.31f && T_TQ.waveform_pos_y >= 0.29f && select_setting == 2)
            {
                if(vib == false){
                Vibration();
                vib = true;
                }
                clear_tutorial = true;
                SS.shake = false;
            }
            else
            {
                Vibration();
                SS.shake = false;
            }
        }

        BackMove();
    }

    //4ページ目の処理
    void Page4()
    {
        Col_Change = true;

        if(SS.shake == true && TS.back == false)
        {
            if(T_TQ.waveform_pos_y <= 0.31f && T_TQ.waveform_pos_y >= 0.29f  && select_setting == 2)
            {
                if(vib == false){
                Vibration();
                vib = true;
                }
                clear_tutorial = true;
                SS.shake = false;
            }
            else
            {
                Vibration();
                SS.shake = false;
            }
        }

        BackMove();
    }

    //5ページ目の処理
    void Page5()
    {
        Col_Change = false;

        if(SS.shake == true)
        {
            if(TS.back == true)
            {
                if(vib == false){
                Vibration();
                vib = true;
                }
                clear_tutorial = true;
                SS.shake = false;
            }
            else
            {
                Vibration();
                SS.shake = false;
            }
        }
    }
    
    //文字とimageの変更
    void Text_Change()
    {
        if(page == 0)
        {
            TutorialName.text = "Cellmin Tutorial";
            EX1.text = "Turn up the volume on your phone";
            EX2.text = "";

            if(timer_seconds > 0){
                NextTutorial.text = timer_seconds.ToString();
            }
            else
            {
                NextTutorial.text = "next tutorial";
            }

                line1.text = "";
                line2.text = "";
                line3.text = "";
                line4.text = "";
            
        }
        else if(page == 1)
        {
            TutorialName.text = "with SWIPE";
            EX1.text = "Select contents.";
            EX2.text = "Play Cellmin.";
            NextTutorial.text = "next tutorial";
            line1.text = "■■■■■■■■";
            line2.text = "■■■■■■■■";
            line3.text = "■■■■■■■■";
            line4.text = "■■■■■■■■";
        }
        else if(page == 2)
        {
            TutorialName.text = "with Shake";
            EX1.text = "Determine the selected content.";
            EX2.text = "Change the waveform.";
            NextTutorial.text = "next tutorial";
            line1.text = "■■■■■■■■";
            line2.text = "■■■■■■■■";
            line3.text = "■■■■■■■■";
            line4.text = "■■■■■■■■";
        }
        else if(page == 3)
        {
            TutorialName.text = "with CHANGING ANGLE";
            EX1.text = "Select tone intervals.";
            EX2.text = "";
            NextTutorial.text = "next tutorial";
            line1.text = "■■■■■■■■";
            line2.text = "■■■■■■■■";
            line3.text = "■■■■■■■■";
            line4.text = "■■■■■■■■";
        }
        else if(page == 4)
        {
            TutorialName.text = "with TWO FINGERS";
            EX1.text = "Make a line with two fingers and regulate the tone volume.";
            EX2.text = "";
            NextTutorial.text = "next tutorial";
            line1.text = "■■■■■■■■";
            line2.text = "■■■■■■■■";
            line3.text = "■■■■■■■■";
            line4.text = "■■■■■■■■";
        }
        else if(page == 5)
        {
            TutorialName.text = "with THREE FINGERS";
            EX1.text = "Choose another waveform (multi phonic mode)";
            EX2.text = "Back to the title (together with shake)";
            NextTutorial.text = "■■■■■■■■";
            line1.text = "■■■■■■■■";
            line2.text = "■■■■■■■■";
            line3.text = "■■■■■■■■";
            line4.text = "■■■■■■■■";
        }

        if(page < 2){
            WaveName.text = "";
            sin.SetActive(false);
            square.SetActive(false);
            triangle.SetActive(false);
            saw.SetActive(false);
        }

        if(wave_name == "sin")
        {
            if(page >= 2)
            {
                sin.SetActive(true);
                square.SetActive(false);
                triangle.SetActive(false);
                saw.SetActive(false);
            }
            else
            {
                sin.SetActive(false);
                square.SetActive(false);
                triangle.SetActive(false);
                saw.SetActive(false);
            }
            
            if(page == 2){
                WaveName.text = "sin wave";
            }
            else if(page > 2){
                WaveName.text = "";
            }
        }
        else if(wave_name == "square")
        {
            if(page >= 2)
            {
                sin.SetActive(false);
                square.SetActive(true);
                triangle.SetActive(false);
                saw.SetActive(false);
            }
            else
            {
                sin.SetActive(false);
                square.SetActive(false);
                triangle.SetActive(false);
                saw.SetActive(false);
            }
            if(page == 2){
                WaveName.text = "square wave";
            }
            else if(page > 2){
                WaveName.text = "";
            }
        }
        else if(wave_name == "triangle")
        {
            if(page >= 2)
            {
                sin.SetActive(false);
                square.SetActive(false);
                triangle.SetActive(true);
                saw.SetActive(false);
            }
            else
            {
                sin.SetActive(false);
                square.SetActive(false);
                triangle.SetActive(false);
                saw.SetActive(false);
            }
            if(page == 2){
                WaveName.text = "triangle wave";
            }
            else if(page > 2){
                WaveName.text = "";
            }
        }
        else if(wave_name == "saw")
        {
            if(page >= 2)
            {
                sin.SetActive(false);
                square.SetActive(false);
                triangle.SetActive(false);
                saw.SetActive(true);

            }
            else
            {
                sin.SetActive(false);
                square.SetActive(false);
                triangle.SetActive(false);
                saw.SetActive(false);
            }

            if(page == 2){
                WaveName.text = "saw wave";
            }
            else if(page > 2){
                WaveName.text = "";
            }
        }
    }

    //色の変更
    void Color_Change()
    {
        if(T_TQ.waveform_pos_x >= 0.2f && T_TQ.waveform_pos_x <= 1.3f)
        {
            alpha = 1;
        }
        else
        {
            alpha = 0;
        }

        if(Col_Change == true)
        {
            Col_T1 = Col_E0;
            if(select_setting == 0){
                Col_T2_p = Col_E0;
                Col_T3_p = Col_S;
                Col_T4_p = Col_S;
                Col_T5_p = Col_S;
                Col_T6_p = Col_S;
            }
            else if(select_setting == 1){
                Col_T2_p = Col_S;
                Col_T3_p = Col_E0;
                Col_T4_p = Col_S;
                Col_T5_p = Col_S;
                Col_T6_p = Col_S;
            }
            else if(select_setting == 2){
                Col_T2_p = Col_S;
                Col_T3_p = Col_S;
                Col_T4_p = Col_E0;
                Col_T5_p = Col_S;
                Col_T6_p = Col_S;
            }
            else if(select_setting == 3){
                Col_T2_p = Col_S;
                Col_T3_p = Col_S;
                Col_T4_p = Col_S;
                Col_T5_p = Col_E0;
                Col_T6_p = Col_S;
            }
            else if(select_setting == 4){
                Col_T2_p = Col_S;
                Col_T3_p = Col_S;
                Col_T4_p = Col_S;
                Col_T5_p = Col_S;
                Col_T6_p = Col_E0;
            }
            line.color = new Color(Col_E0,Col_E0,Col_E0,alpha);
            Image.color  = new Color(Col_E0,Col_E0,Col_E0,alpha);
            Back.color = new Color(Col_E1,Col_E1,Col_E1,1);
            col = Col_E0;
            circle.SetFloat("_Col",Col_E0);
        }
        else if(Col_Change == false)
        {
            Col_T1 = Col_E1;
            if(page == 0)
            {
                Col_T2_p = Col_E1;
                Col_T3_p = Col_E1;
                Col_T4_p = Col_E1;
                Col_T5_p = Col_E1;
                Col_T6_p = Col_E1;
            }
            else
            {
                if(select_setting == 0){
                    Col_T2_p = Col_E1;
                    Col_T3_p = Col_S;
                    Col_T4_p = Col_S;
                    Col_T5_p = Col_S;
                    Col_T6_p = Col_S;
                }
                else if(select_setting == 1){
                    Col_T2_p = Col_S;
                    Col_T3_p = Col_E1;
                    Col_T4_p = Col_S;
                    Col_T5_p = Col_S;
                    Col_T6_p = Col_S;
                }
                else if(select_setting == 2){
                    Col_T2_p = Col_S;
                    Col_T3_p = Col_S;
                    Col_T4_p = Col_E1;
                    Col_T5_p = Col_S;
                    Col_T6_p = Col_S;
                }
                else if(select_setting == 3){
                    Col_T2_p = Col_S;
                    Col_T3_p = Col_S;
                    Col_T4_p = Col_S;
                    Col_T5_p = Col_E1;
                    Col_T6_p = Col_S;
                }
                else if(select_setting == 4){
                    Col_T2_p = Col_S;
                    Col_T3_p = Col_S;
                    Col_T4_p = Col_S;
                    Col_T5_p = Col_S;
                    Col_T6_p = Col_E1;
                }
            }
            line.color = new Color(Col_E1,Col_E1,Col_E1,alpha);
            Image.color = new Color(Col_E1,Col_E1,Col_E1,alpha);
            Back.color = new Color(Col_E0,Col_E0,Col_E0,1);
            col = Col_E1;
            circle.SetFloat("_Col",Col_E1);
        }

        Col_T2 = Mathf.Lerp(Col_T2, Col_T2_p, 0.075f);
        Col_T3 = Mathf.Lerp(Col_T3, Col_T3_p, 0.075f);
        Col_T4 = Mathf.Lerp(Col_T4, Col_T4_p, 0.075f);
        Col_T5 = Mathf.Lerp(Col_T5, Col_T5_p, 0.075f);
        Col_T6 = Mathf.Lerp(Col_T6, Col_T6_p, 0.075f);

        TutorialName.color = new Color(Col_T1,Col_T1,Col_T1,alpha);
        EX1.color = new Color(Col_T1,Col_T1,Col_T1,alpha);
        EX2.color = new Color(Col_T1,Col_T1,Col_T1,alpha);
        WaveName.color = new Color(Col_T1,Col_T1,Col_T1,alpha);
        line1.color = new Color(Col_T2,Col_T2,Col_T2,alpha);
        line2.color = new Color(Col_T3,Col_T3,Col_T3,alpha);
        NextTutorial.color = new Color(Col_T4,Col_T4,Col_T4,alpha);
        line3.color = new Color(Col_T5,Col_T5,Col_T5,alpha);
        line4.color = new Color(Col_T6,Col_T6,Col_T6,alpha);
    }

    //スレッド変更処理
    void Select_Change()
    {
        if (TS.swipe_Y_minus == true && time == 0 && T_TQ.waveform_pos_x >= 0.9f && page > 0 && clear_tutorial == false)
        {
            Vibration();
            if (select_setting >= 4)
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

        if (TS.swipe_Y_plus == true && time == 0 && T_TQ.waveform_pos_x >= 0.9f && page > 0 && clear_tutorial == false)
        {
            Vibration();
            if (select_setting <= 0)
            {
                timekeeper = true;
                select_setting = 4;
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

        if(page == 0){
            if(TS.swipe_Y_minus == true || TS.swipe_Y_plus == true)
            {
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

        if(page == 0)
        {
            T_TQ.pos_y = 0.3f + 0.2f*(timer/15);
            //T_TQ.pos_y = 0.3f;
        }
        else
        {
            if(select_setting == 0)
            {
                T_TQ.pos_y = 0.5f;
            }
            else if(select_setting == 1)
            {
                T_TQ.pos_y = 0.4f;
            }
            else if(select_setting == 2)
            {
                T_TQ.pos_y = 0.3f;
            }
            else if(select_setting == 3)
            {
                T_TQ.pos_y = 0.2f;
            }
            else if(select_setting == 4)
            {
                T_TQ.pos_y = 0.1f;
            }
        }
    }

    void Tutorial_Move()
    {
        if(page == 0)
        {
            Page0();
        }
        else if(page == 1)
        {
            Page1();
        }
        else if(page == 2)
        {
            Page2();
        }
        else if(page == 3)
        {
            Page3();
        }
        else if(page == 4)
        {
            Page4();
        }
        else if(page == 5)
        {
            Page5();
        }
    }



    // Update is called once per frame
    void Update()
    {
        wave_name = PS.wave_name;
        Color_Change();
        Clear_T();
        Text_Change();
        Select_Change();

        Tutorial_Move();
    }
}
