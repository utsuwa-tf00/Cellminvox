using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Panel_Manager_2 : MonoBehaviour
{
    public GameObject Cellmin;
    private Volume Vol;
    private Gyro_Script Gyro;
    private PlayState PS;
    private Touch_Script TS;

    public Material Panel;

    private Gyroscope m_gyro;


    /*
    private float Col_R1_S = 0;
    private float Col_G1_S = 106;
    private float Col_B1_S = 255;
    private float Col_R1_E = 13;
    private float Col_G1_E = 255;
    private float Col_B1_E = 129;
    private float Col_R2_S = 255;
    private float Col_G2_S = 3;
    private float Col_B2_S = 31;
    private float Col_R2_E = 255;
    private float Col_G2_E = 180;
    private float Col_B2_E = 94;
    private float Col_R3_S = 71;
    private float Col_G3_S = 231;
    private float Col_B3_S = 255;
    private float Col_R3_E = 255;
    private float Col_G3_E = 248;
    private float Col_B3_E = 69;
    private float Col_R4_S = 97;
    private float Col_G4_S = 0;
    private float Col_B4_S = 255;
    private float Col_R4_E = 255;
    private float Col_G4_E = 129;
    private float Col_B4_E = 99;
    */

    private float ColValue;

    private float col_val_R1 = 0;
    private float col_val_G1 = 153;
    private float col_val_B1 = 255;
    private float col_val_R2 = 128;
    private float col_val_G2 = 128;
    private float col_val_B2 = 128;
    private float col_val_R3 = 255;
    private float col_val_G3 = 101;
    private float col_val_B3 = 0;

    private float Col_R_S;
    private float Col_G_S;
    private float Col_B_S;
    private float Col_R_E;
    private float Col_G_E;
    private float Col_B_E;

    private float Col_Light;
    private float Col_Light_Min = 0.05f;
    private float Col_Light_Max = 0.9f;

    private float Col_R_pre;
    private float Col_G_pre;
    private float Col_B_pre;
    private float Col_R_Max;
    private float Col_G_Max;
    private float Col_B_Max;
    private float Col_R = 0.05f;
    private float Col_G = 0.05f;
    private float Col_B = 0.05f;

    private float Col_R_S2;
    private float Col_G_S2;
    private float Col_B_S2;
    private float Col_R_E2;
    private float Col_G_E2;
    private float Col_B_E2;
    //private float Col_R2 = 0.05f;
    //private float Col_G2 = 0.05f;
    //private float Col_B2 = 0.05f;


    private int wave;
    private float move;

    // Start is called before the first frame update
    void Start()
    {
        Input.gyro.enabled = true;

        Vol = Cellmin.GetComponent<Volume>();
        TS = Cellmin.GetComponent<Touch_Script>();
        Gyro = Cellmin.GetComponent<Gyro_Script>();
        PS = Cellmin.GetComponent<PlayState>();
    }

    // Update is called once per frame
    void Update()
    {
        
        if(PS.wave_name == "sin"){
            wave = 0;
            move = 2;
            /*
            Col_R_S = Col_R1_S;
            Col_G_S = Col_G1_S;
            Col_B_S = Col_B1_S;
            Col_R_E = Col_R1_E;
            Col_G_E = Col_G1_E;
            Col_B_E = Col_B1_E;
            */
        }
        else if(PS.wave_name == "square"){
            wave = 1;
            move = 2;
            /*
            Col_R_S = Col_R2_S;
            Col_G_S = Col_G2_S;
            Col_B_S = Col_B2_S;
            Col_R_E = Col_R2_E;
            Col_G_E = Col_G2_E;
            Col_B_E = Col_B2_E;
            */
        }
        else if(PS.wave_name == "triangle"){
            wave = 2;
            move = 2;
            /*
            Col_R_S = Col_R3_S;
            Col_G_S = Col_G3_S;
            Col_B_S = Col_B3_S;
            Col_R_E = Col_R3_E;
            Col_G_E = Col_G3_E;
            Col_B_E = Col_B3_E;
            */
        }
        else if(PS.wave_name == "saw"){
            wave = 3;
            move = 2;
            /*
            Col_R_S = Col_R4_S;
            Col_G_S = Col_G4_S;
            Col_B_S = Col_B4_S;
            Col_R_E = Col_R4_E;
            Col_G_E = Col_G4_E;
            Col_B_E = Col_B4_E;
            */
        }
        
        
        //Col_Light = Col_Light_Min + (1 -Col_Light_Min)*Vol.volume;
        if(Setting_GM.swipe_mode == true)
        {
            ColValue = TS.SwipeToFreq;
        }
        else
        {
            ColValue = Gyro.gyro_value_x;
        }

        if(Button_Rotate.Rotate == true)
        {
            m_gyro = Input.gyro;
            transform.rotation = Quaternion.Euler(-90, 180-m_gyro.attitude.y*180, 0);
        }

        if(ColValue < 0.5f)
        {
            Col_R_S = col_val_R1;
            Col_G_S = col_val_G1;
            Col_B_S = col_val_B1;
            Col_R_E = col_val_R2;
            Col_G_E = col_val_G2;
            Col_B_E = col_val_B2;
            Col_R_Max = (Col_R_S + (Col_R_E - Col_R_S) * ColValue*2)/256;
            Col_G_Max = (Col_G_S + (Col_G_E - Col_G_S) * ColValue*2)/256;
            Col_B_Max = (Col_B_S + (Col_B_E - Col_B_S) * ColValue*2)/256;
        }
        else if(ColValue == 0.5f)
        {
            Col_R_S = col_val_R2;
            Col_G_S = col_val_G2;
            Col_B_S = col_val_B2;
            Col_R_E = col_val_R2;
            Col_G_E = col_val_G2;
            Col_B_E = col_val_B2;
            Col_R_Max = col_val_R2/256;
            Col_G_Max = col_val_G2/256;
            Col_B_Max = col_val_B2/256;
        }
        else if(ColValue > 0.5f)
        {
            Col_R_S = col_val_R2;
            Col_G_S = col_val_G2;
            Col_B_S = col_val_B2;
            Col_R_E = col_val_R3;
            Col_G_E = col_val_G3;
            Col_B_E = col_val_B3;
            Col_R_Max = (Col_R_S + (Col_R_E - Col_R_S) * (ColValue-0.5f)*2)/256;
            Col_G_Max = (Col_G_S + (Col_G_E - Col_G_S) * (ColValue-0.5f)*2)/256;
            Col_B_Max = (Col_B_S + (Col_B_E - Col_B_S) * (ColValue-0.5f)*2)/256;
        }

        

        //Col_R2 = (Col_R_S2 + (Col_R_E2 - Col_R_S2) * Gyro.gyro_value_y)/256;
        //Col_G2 = (Col_G_S2 + (Col_G_E2 - Col_G_S2) * Gyro.gyro_value_y)/256;
        //Col_B2 = (Col_B_S2 + (Col_B_E2 - Col_B_S2) * Gyro.gyro_value_y)/256;

        Col_R_pre = Col_Light_Min + (Col_R_Max - Col_Light_Min)*Vol.volume;
        Col_G_pre = Col_Light_Min + (Col_G_Max - Col_Light_Min)*Vol.volume;
        Col_B_pre = Col_Light_Min + (Col_B_Max - Col_Light_Min)*Vol.volume;

        Col_Light = Col_Light_Min + (Col_Light_Max -Col_Light_Min)*Vol.volume;


        Col_R = Mathf.Lerp(Col_R, Col_R_pre, 1);
        Col_G = Mathf.Lerp(Col_G, Col_G_pre, 1);
        Col_B = Mathf.Lerp(Col_B, Col_B_pre, 1);

        Panel.SetFloat("_R",Col_R);
        Panel.SetFloat("_G",Col_G);
        Panel.SetFloat("_B",Col_B);
        Panel.SetFloat("_Volume",Vol.volume);
        Panel.SetFloat("_Light",Col_Light);
        Panel.SetFloat("_MoveSpeed",move);
        Panel.SetInt("_PlayState",wave);
    }
}
