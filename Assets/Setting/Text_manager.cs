using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Text_manager : MonoBehaviour
{
    public Text auto_pich;
    public Text multiphonic;
    public Text SwipeMode;
    public Text WaveChange;
    public Text range;
    public Text range2;
    public Text pitch;
    public Text pitch2;

    /*
    public GameObject line1;
    public GameObject line2;
    public GameObject line3;
    public GameObject line4;
    public GameObject line5;
    public GameObject line6;
    public GameObject line7;
    */

    public GameObject sin1;
    public GameObject square1;
    public GameObject triangle1;
    public GameObject saw1;
    public GameObject sin2;
    public GameObject square2;
    public GameObject triangle2;
    public GameObject saw2;

    private Setting_GM SG;

    // Start is called before the first frame update
    void Start()
    {
        SG = GetComponent<Setting_GM>();
    }

    // Update is called once per frame
    void Update()
    {
        /*
        if (SG.select_setting == 0)
        {
            line1.SetActive(true);
            line2.SetActive(false);
            line3.SetActive(false);
            line4.SetActive(false);
            line5.SetActive(false);
            line6.SetActive(false);
            line7.SetActive(false);
        }
        else if (SG.select_setting == 1)
        {
            line1.SetActive(false);
            line2.SetActive(true);
            line3.SetActive(false);
            line4.SetActive(false);
            line5.SetActive(false);
            line6.SetActive(false);
            line7.SetActive(false);
        }
        else if (SG.select_setting == 2)
        {
            line1.SetActive(false);
            line2.SetActive(false);
            line3.SetActive(true);
            line4.SetActive(false);
            line5.SetActive(false);
            line6.SetActive(false);
            line7.SetActive(false);
        }
        else if (SG.select_setting == 3)
        {
            line1.SetActive(false);
            line2.SetActive(false);
            line3.SetActive(false);
            line4.SetActive(true);
            line5.SetActive(false);
            line6.SetActive(false);
            line7.SetActive(false);
        }
        else if (SG.select_setting == 4)
        {
            line1.SetActive(false);
            line2.SetActive(false);
            line3.SetActive(false);
            line4.SetActive(false);
            line5.SetActive(true);
            line6.SetActive(false);
            line7.SetActive(false);
        }
        else if (SG.select_setting == 5)
        {
            line1.SetActive(false);
            line2.SetActive(false);
            line3.SetActive(false);
            line4.SetActive(false);
            line5.SetActive(false);
            line6.SetActive(true);
            line7.SetActive(false);
        }
        else if (SG.select_setting == 6)
        {
            line1.SetActive(false);
            line2.SetActive(false);
            line3.SetActive(false);
            line4.SetActive(false);
            line5.SetActive(false);
            line6.SetActive(false);
            line7.SetActive(true);
        }
        */

        if (SG.auto_pich_text == true)
        {
            auto_pich.text = "true";
        }
        else if (SG.auto_pich_text == false)
        {
            auto_pich.text = "false";
        }

        if (SG.double_tone_text == true)
        {
            multiphonic.text = "true";
        }
        else if (SG.double_tone_text == false)
        {
            multiphonic.text = "false";
        }

        if (SG.swipe_mode_text == true)
        {
            SwipeMode.text = "true";
        }
        else if (SG.swipe_mode_text == false)
        {
            SwipeMode.text = "false";
        }

        if (SG.wave_change_text == true)
        {
            WaveChange.text = "false";
        }
        else if (SG.wave_change_text == false)
        {
            WaveChange.text = "true";
        }

        pitch.text = SG.pitch_text.ToString();
        pitch2.text = SG.pitch_text2.ToString();

        range.text = SG.range_setting_text.ToString();
        if (SG.change_wave_text == "sin")
        {
            sin1.SetActive(true);
            square1.SetActive(false);
            triangle1.SetActive(false);
            saw1.SetActive(false);
        }
        else if (SG.change_wave_text == "square")
        {
            sin1.SetActive(false);
            square1.SetActive(true);
            triangle1.SetActive(false);
            saw1.SetActive(false);
        }
        else if (SG.change_wave_text == "triangle")
        {
            sin1.SetActive(false);
            square1.SetActive(false);
            triangle1.SetActive(true);
            saw1.SetActive(false);
        }
        else if (SG.change_wave_text == "saw")
        {
            sin1.SetActive(false);
            square1.SetActive(false);
            triangle1.SetActive(false);
            saw1.SetActive(true);
        }

        range2.text = SG.range_setting_text2.ToString();
        if (SG.change_wave_text2 == "sin")
        {
            sin2.SetActive(true);
            square2.SetActive(false);
            triangle2.SetActive(false);
            saw2.SetActive(false);
        }
        else if (SG.change_wave_text2 == "square")
        {
            sin2.SetActive(false);
            square2.SetActive(true);
            triangle2.SetActive(false);
            saw2.SetActive(false);
        }
        else if (SG.change_wave_text2 == "triangle")
        {
            sin2.SetActive(false);
            square2.SetActive(false);
            triangle2.SetActive(true);
            saw2.SetActive(false);
        }
        else if (SG.change_wave_text2 == "saw")
        {
            sin2.SetActive(false);
            square2.SetActive(false);
            triangle2.SetActive(false);
            saw2.SetActive(true);
        }
    }
}
