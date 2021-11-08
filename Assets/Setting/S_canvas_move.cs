using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class S_canvas_move : MonoBehaviour
{
    //public GameObject GM;
    private float posX = 15;
    private float end_posX = 0;

    public GameObject SG;
    private Setting_GM SG_SG;

    public Text AutoPitch;
    public Text AutoPitchSwitch;
    public Text MultiPhonic;
    public Text MultiPhonicSwitch;
    public Text SwipeMode;
    public Text SwipeModeSwitch;
    public Text WaveChange;
    public Text WaveChangeSwitch;
    public Text Range1;
    public Text RangeValue1;
    public Text Range2;
    public Text RangeValue2;
    public Text Wave1;
    public Text Wave2;
    public Text Pitch1;
    public Text PitchValue1;
    public Text Pitch2;
    public Text PitchValue2;
    public Text Reset;
    public Text Back;

    private float Col_False = 0.5f;
    private float Col_True = 0.9f;
    private float Col_Not = 0.2f;
    private float AutoPitch_Col;
    private float MultiPhonic_Col;
    private float SwipeMode_Col;
    private float WaveChange_Col;
    private float Range1_Col;
    private float Range2_Col;
    private float Wave1_Col;
    private float Wave2_Col;
    private float Pitch1_Col;
    private float Pitch2_Col;
    private float Reset_Col;
    private float Back_Col;
    private float AutoPitch_Col_p;
    private float MultiPhonic_Col_p;
    private float SwipeMode_Col_p;
    private float WaveChange_Col_p;
    private float Range1_Col_p;
    private float Range2_Col_p;
    private float Wave1_Col_p;
    private float Wave2_Col_p;
    private float Pitch1_Col_p;
    private float Pitch2_Col_p;
    private float Reset_Col_p;
    private float Back_Col_p;

    public Material Mat1;
    public Material Mat2;

    // Start is called before the first frame update
    void Start()
    {
        SG_SG = SG.GetComponent<Setting_GM>();
    }

    void AutoPitchSetting()
    {
        AutoPitch_Col = Col_True;
        Wave1_Col = Col_False;
        Range1_Col = Col_False;
        Pitch1_Col = Col_False;
        
        if(Setting_GM.swipe_mode == true)
        {
            MultiPhonic_Col = Col_Not;
        }
        else
        {
            MultiPhonic_Col = Col_False;
        }

        if(Setting_GM.double_tone == true)
        {
            SwipeMode_Col = Col_Not;
            Wave2_Col = Col_False;
            Range2_Col = Col_False;
            Pitch2_Col = Col_False;
        }
        else
        {
            SwipeMode_Col = Col_False;
            Wave2_Col = Col_Not;
            Range2_Col = Col_Not;
            Pitch2_Col = Col_Not;
        }

        WaveChange_Col = Col_False;

        Reset_Col = Col_False;
        Back_Col = Col_False;
    }

    void MultiPhonicSetting()
    {
        AutoPitch_Col = Col_False;
        Wave1_Col = Col_False;
        Range1_Col = Col_False;
        Pitch1_Col = Col_False;
        
        if(Setting_GM.swipe_mode == true)
        {
            MultiPhonic_Col = Col_Not;
        }
        else
        {
            MultiPhonic_Col = Col_True;
        }

        if(Setting_GM.double_tone == true)
        {
            SwipeMode_Col = Col_Not;
            Wave2_Col = Col_False;
            Range2_Col = Col_False;
            Pitch2_Col = Col_False;
        }
        else
        {
            SwipeMode_Col = Col_False;
            Wave2_Col = Col_Not;
            Range2_Col = Col_Not;
            Pitch2_Col = Col_Not;
        }

        WaveChange_Col = Col_False;
        
        Reset_Col = Col_False;
        Back_Col = Col_False;
    }

    void SwipeModeSetting()
    {
        AutoPitch_Col = Col_False;
        Wave1_Col = Col_False;
        Range1_Col = Col_False;
        Pitch1_Col = Col_False;
        
        if(Setting_GM.swipe_mode == true)
        {
            MultiPhonic_Col = Col_Not;
        }
        else
        {
            MultiPhonic_Col = Col_False;
        }

        if(Setting_GM.double_tone == true)
        {
            SwipeMode_Col = Col_Not;
            Wave2_Col = Col_False;
            Range2_Col = Col_False;
            Pitch2_Col = Col_False;
        }
        else
        {
            SwipeMode_Col = Col_True;
            Wave2_Col = Col_Not;
            Range2_Col = Col_Not;
            Pitch2_Col = Col_Not;
        }

        WaveChange_Col = Col_False;
        
        Reset_Col = Col_False;
        Back_Col = Col_False;
    }

    void WaveChangeSetting()
    {
        AutoPitch_Col = Col_False;
        Wave1_Col = Col_False;
        Range1_Col = Col_False;
        Pitch1_Col = Col_False;
        
        if(Setting_GM.swipe_mode == true)
        {
            MultiPhonic_Col = Col_Not;
        }
        else
        {
            MultiPhonic_Col = Col_False;
        }

        if(Setting_GM.double_tone == true)
        {
            SwipeMode_Col = Col_Not;
            Wave2_Col = Col_False;
            Range2_Col = Col_False;
            Pitch2_Col = Col_False;
        }
        else
        {
            SwipeMode_Col = Col_False;
            Wave2_Col = Col_Not;
            Range2_Col = Col_Not;
            Pitch2_Col = Col_Not;
        }

        WaveChange_Col = Col_True;
        
        Reset_Col = Col_False;
        Back_Col = Col_False;
    }

    void WaveSetting1()
    {
        AutoPitch_Col = Col_False;
        Wave1_Col = Col_True;
        Range1_Col = Col_False;
        Pitch1_Col = Col_False;
        
        if(Setting_GM.swipe_mode == true)
        {
            MultiPhonic_Col = Col_Not;
        }
        else
        {
            MultiPhonic_Col = Col_False;
        }

        if(Setting_GM.double_tone == true)
        {
            SwipeMode_Col = Col_Not;
            Wave2_Col = Col_False;
            Range2_Col = Col_False;
            Pitch2_Col = Col_False;
        }
        else
        {
            SwipeMode_Col = Col_False;
            Wave2_Col = Col_Not;
            Range2_Col = Col_Not;
            Pitch2_Col = Col_Not;
        }

        WaveChange_Col = Col_False;
        
        Reset_Col = Col_False;
        Back_Col = Col_False;
    }

    void RangeSetting1()
    {
        AutoPitch_Col = Col_False;
        Wave1_Col = Col_False;
        Range1_Col = Col_True;
        Pitch1_Col = Col_False;
        
        if(Setting_GM.swipe_mode == true)
        {
            MultiPhonic_Col = Col_Not;
        }
        else
        {
            MultiPhonic_Col = Col_False;
        }

        if(Setting_GM.double_tone == true)
        {
            SwipeMode_Col = Col_Not;
            Wave2_Col = Col_False;
            Range2_Col = Col_False;
            Pitch2_Col = Col_False;
        }
        else
        {
            SwipeMode_Col = Col_False;
            Wave2_Col = Col_Not;
            Range2_Col = Col_Not;
            Pitch2_Col = Col_Not;
        }

        WaveChange_Col = Col_False;
        
        Reset_Col = Col_False;
        Back_Col = Col_False;
    }

    void PitchSetting1()
    {
        AutoPitch_Col = Col_False;
        Wave1_Col = Col_False;
        Range1_Col = Col_False;
        Pitch1_Col = Col_True;
        
        if(Setting_GM.swipe_mode == true)
        {
            MultiPhonic_Col = Col_Not;
        }
        else
        {
            MultiPhonic_Col = Col_False;
        }

        if(Setting_GM.double_tone == true)
        {
            SwipeMode_Col = Col_Not;
            Wave2_Col = Col_False;
            Range2_Col = Col_False;
            Pitch2_Col = Col_False;
        }
        else
        {
            SwipeMode_Col = Col_False;
            Wave2_Col = Col_Not;
            Range2_Col = Col_Not;
            Pitch2_Col = Col_Not;
        }

        WaveChange_Col = Col_False;
        
        Reset_Col = Col_False;
        Back_Col = Col_False;
    }

    void WaveSetting2()
    {
        AutoPitch_Col = Col_False;
        Wave1_Col = Col_False;
        Range1_Col = Col_False;
        Pitch1_Col = Col_False;
        
        if(Setting_GM.swipe_mode == true)
        {
            MultiPhonic_Col = Col_Not;
        }
        else
        {
            MultiPhonic_Col = Col_False;
        }

        if(Setting_GM.double_tone == true)
        {
            SwipeMode_Col = Col_Not;
            Wave2_Col = Col_True;
            Range2_Col = Col_False;
            Pitch2_Col = Col_False;
        }
        else
        {
            SwipeMode_Col = Col_False;
            Wave2_Col = Col_Not;
            Range2_Col = Col_Not;
            Pitch2_Col = Col_Not;
        }

        WaveChange_Col = Col_False;
        
        Reset_Col = Col_False;
        Back_Col = Col_False;
    }

    void RangeSetting2()
    {
        AutoPitch_Col = Col_False;
        Wave1_Col = Col_False;
        Range1_Col = Col_False;
        Pitch1_Col = Col_False;
        
        if(Setting_GM.swipe_mode == true)
        {
            MultiPhonic_Col = Col_Not;
        }
        else
        {
            MultiPhonic_Col = Col_False;
        }

        if(Setting_GM.double_tone == true)
        {
            SwipeMode_Col = Col_Not;
            Wave2_Col = Col_False;
            Range2_Col = Col_True;
            Pitch2_Col = Col_False;
        }
        else
        {
            SwipeMode_Col = Col_False;
            Wave2_Col = Col_Not;
            Range2_Col = Col_Not;
            Pitch2_Col = Col_Not;
        }

        WaveChange_Col = Col_False;
        
        Reset_Col = Col_False;
        Back_Col = Col_False;
    }

    void PitchSetting2()
    {
        AutoPitch_Col = Col_False;
        Wave1_Col = Col_False;
        Range1_Col = Col_False;
        Pitch1_Col = Col_False;
        
        if(Setting_GM.swipe_mode == true)
        {
            MultiPhonic_Col = Col_Not;
        }
        else
        {
            MultiPhonic_Col = Col_False;
        }

        if(Setting_GM.double_tone == true)
        {
            SwipeMode_Col = Col_Not;
            Wave2_Col = Col_False;
            Range2_Col = Col_False;
            Pitch2_Col = Col_True;
        }
        else
        {
            SwipeMode_Col = Col_False;
            Wave2_Col = Col_Not;
            Range2_Col = Col_Not;
            Pitch2_Col = Col_Not;
        }

        WaveChange_Col = Col_False;
        
        Reset_Col = Col_False;
        Back_Col = Col_False;
    }

    void ResetSetting()
    {
        AutoPitch_Col = Col_False;
        Wave1_Col = Col_False;
        Range1_Col = Col_False;
        Pitch1_Col = Col_False;
        
        if(Setting_GM.swipe_mode == true)
        {
            MultiPhonic_Col = Col_Not;
        }
        else
        {
            MultiPhonic_Col = Col_False;
        }

        if(Setting_GM.double_tone == true)
        {
            SwipeMode_Col = Col_Not;
            Wave2_Col = Col_False;
            Range2_Col = Col_False;
            Pitch2_Col = Col_False;
        }
        else
        {
            SwipeMode_Col = Col_False;
            Wave2_Col = Col_Not;
            Range2_Col = Col_Not;
            Pitch2_Col = Col_Not;
        }

        WaveChange_Col = Col_False;
        
        Reset_Col = Col_True;
        Back_Col = Col_False;
    }

    void BackSetting()
    {
        AutoPitch_Col = Col_False;
        Wave1_Col = Col_False;
        Range1_Col = Col_False;
        Pitch1_Col = Col_False;
        
        if(Setting_GM.swipe_mode == true)
        {
            MultiPhonic_Col = Col_Not;
        }
        else
        {
            MultiPhonic_Col = Col_False;
        }

        if(Setting_GM.double_tone == true)
        {
            SwipeMode_Col = Col_Not;
            Wave2_Col = Col_False;
            Range2_Col = Col_False;
            Pitch2_Col = Col_False;
        }
        else
        {
            SwipeMode_Col = Col_False;
            Wave2_Col = Col_Not;
            Range2_Col = Col_Not;
            Pitch2_Col = Col_Not;
        }

        WaveChange_Col = Col_False;
        
        Reset_Col = Col_False;
        Back_Col = Col_True;
    }

    // Update is called once per frame
    void Update()
    {
        if(SG_SG.select_setting == 0)
        {
            AutoPitchSetting();
        }
        else if(SG_SG.select_setting == 1)
        {
            WaveChangeSetting();
        }
        else if(SG_SG.select_setting == 2)
        {
            MultiPhonicSetting();
        }
        else if(SG_SG.select_setting == 3)
        {
            SwipeModeSetting();
        }
        else if(SG_SG.select_setting == 4)
        {
            WaveSetting1();
        }
        else if(SG_SG.select_setting == 5)
        {
            RangeSetting1();
        }
        else if(SG_SG.select_setting == 6)
        {
            PitchSetting1();
        }
        else if(SG_SG.select_setting == 7)
        {
            WaveSetting2();
        }
        else if(SG_SG.select_setting == 8)
        {
            RangeSetting2();
        }
        else if(SG_SG.select_setting == 9)
        {
            PitchSetting2();
        }
        else if(SG_SG.select_setting == 10)
        {
            ResetSetting();
        }
        else if(SG_SG.select_setting == 11)
        {
            BackSetting();
        }

        AutoPitch_Col_p = Mathf.Lerp(AutoPitch_Col_p, AutoPitch_Col, 0.075f);
        MultiPhonic_Col_p = Mathf.Lerp(MultiPhonic_Col_p, MultiPhonic_Col, 0.075f);
        SwipeMode_Col_p = Mathf.Lerp(SwipeMode_Col_p, SwipeMode_Col, 0.075f);
        WaveChange_Col_p = Mathf.Lerp(WaveChange_Col_p, WaveChange_Col, 0.075f);
        Range1_Col_p = Mathf.Lerp(Range1_Col_p, Range1_Col, 0.075f);
        Range2_Col_p = Mathf.Lerp(Range2_Col_p, Range2_Col, 0.075f);
        Wave1_Col_p = Mathf.Lerp(Wave1_Col_p, Wave1_Col, 0.075f);
        Wave2_Col_p = Mathf.Lerp(Wave2_Col_p, Wave2_Col, 0.075f);
        Pitch1_Col_p = Mathf.Lerp(Pitch1_Col_p, Pitch1_Col, 0.075f);
        Pitch2_Col_p = Mathf.Lerp(Pitch2_Col_p, Pitch2_Col, 0.075f);
        Reset_Col_p = Mathf.Lerp(Reset_Col_p, Reset_Col, 0.075f);
        Back_Col_p = Mathf.Lerp(Back_Col_p, Back_Col, 0.075f);


        AutoPitch.color = new Color(AutoPitch_Col_p,AutoPitch_Col_p,AutoPitch_Col_p,1);
        AutoPitchSwitch.color = new Color(AutoPitch_Col_p,AutoPitch_Col_p,AutoPitch_Col_p,1);

        MultiPhonic.color = new Color(MultiPhonic_Col_p,MultiPhonic_Col_p,MultiPhonic_Col_p,1);
        MultiPhonicSwitch.color = new Color(MultiPhonic_Col_p,MultiPhonic_Col_p,MultiPhonic_Col_p,1);

        SwipeMode.color = new Color(SwipeMode_Col_p,SwipeMode_Col_p,SwipeMode_Col_p,1);
        SwipeModeSwitch.color = new Color(SwipeMode_Col_p,SwipeMode_Col_p,SwipeMode_Col_p,1);

        WaveChange.color = new Color(WaveChange_Col_p,WaveChange_Col_p,WaveChange_Col_p,1);
        WaveChangeSwitch.color = new Color(WaveChange_Col_p,WaveChange_Col_p,WaveChange_Col_p,1);

        Range1.color = new Color(Range1_Col_p,Range1_Col_p,Range1_Col_p,1);
        RangeValue1.color = new Color(Range1_Col_p,Range1_Col_p,Range1_Col_p,1);

        Range2.color = new Color(Range2_Col_p,Range2_Col_p,Range2_Col_p,1);
        RangeValue2.color = new Color(Range2_Col_p,Range2_Col_p,Range2_Col_p,1);

        Wave1.color = new Color(Wave1_Col_p,Wave1_Col_p,Wave1_Col_p,1);
        Mat1.color = new Color(Wave1_Col_p,Wave1_Col_p,Wave1_Col_p,1);

        Wave2.color = new Color(Wave2_Col_p,Wave2_Col_p,Wave2_Col_p,1);
        Mat2.color = new Color(Wave2_Col_p,Wave2_Col_p,Wave2_Col_p,1);

        Pitch1.color = new Color(Pitch1_Col_p,Pitch1_Col_p,Pitch1_Col_p,1);
        PitchValue1.color = new Color(Pitch1_Col_p,Pitch1_Col_p,Pitch1_Col_p,1);

        Pitch2.color = new Color(Pitch2_Col_p,Pitch2_Col_p,Pitch2_Col_p,1);
        PitchValue2.color = new Color(Pitch2_Col_p,Pitch2_Col_p,Pitch2_Col_p,1);

        Reset.color = new Color(Reset_Col_p,Reset_Col_p,Reset_Col_p,1);

        Back.color = new Color(Back_Col_p,Back_Col_p,Back_Col_p,1);


        posX = Mathf.Lerp(posX, end_posX, 0.05f);
        this.gameObject.transform.position = new Vector3(posX, 0, 0);
    }
}
