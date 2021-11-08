using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Setting_Quad_Manager : MonoBehaviour
{
    private Setting_GM SM;
    private Touch_Script TS;
    private Shake_Script SS;
    private float waveform_pos_y = 0.75f;
    private float waveform_pos_x = 1.5f;
    //private float pre_pos;
    private float pos_y;
    private float pos_x;
    public Material material;
    public bool end_cg;

    // Start is called before the first frame update
    void Start()
    {
        SM = GameObject.Find("Setting_GM").gameObject.GetComponent<Setting_GM>();
        TS = GameObject.Find("Setting_GM").gameObject.GetComponent<Touch_Script>();
        SS = GameObject.Find("Setting_GM").gameObject.GetComponent<Shake_Script>();
        material.SetColor("_Color1", new Color(0.05f, 0.05f, 0.05f, 0));
        material.SetColor("_Color0", new Color(0.9f, 0.9f, 0.9f, 1));
    }

    // Update is called once per frame
    void Update()
    {
        if (SM.select_setting == 0)
        {
            pos_y = 0.85f;
        }
        else if (SM.select_setting == 1)
        {
            pos_y = 0.8f;
        }
        else if (SM.select_setting == 2)
        {
            pos_y = 0.75f;
        }
        else if (SM.select_setting == 3)
        {
            pos_y = 0.7f;
        }
        else if (SM.select_setting == 4)
        {
            pos_y = 0.6f;
        }
        else if (SM.select_setting == 5)
        {
            pos_y = 0.55f;
        }
        else if (SM.select_setting == 6)
        {
            pos_y = 0.5f;
        }
        else if (SM.select_setting == 7)
        {
            pos_y = 0.4f;
        }
        else if (SM.select_setting == 8)
        {
            pos_y = 0.35f;
        }
        else if (SM.select_setting == 9)
        {
            pos_y = 0.3f;
        }
        else if (SM.select_setting == 10)
        {
            pos_y = 0.2f;
        }
        else if (SM.select_setting == 11)
        {
            pos_y = 0.1f;
        }

        if (SM.setting_end == true)
        {
            pos_x = -0.2f;
        }
        else
        {
            pos_x = 0.9f;
        }

        waveform_pos_y = Mathf.Lerp(waveform_pos_y, pos_y, 0.075f);
        waveform_pos_x = Mathf.Lerp(waveform_pos_x, pos_x, 0.075f);

        material.SetFloat("_posY", waveform_pos_y);
        material.SetFloat("_posX", waveform_pos_x);


        if (waveform_pos_x <= -0.1f)
        {
            end_cg = true;
        }
    }
}
