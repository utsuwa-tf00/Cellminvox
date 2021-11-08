using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Title_Quad_Manager : MonoBehaviour
{
    private Title_Manager TM;
    private Touch_Script TS;
    private Shake_Script SS;
    private float waveform_pos_y = 0.5f;
    public float waveform_pos_x = 1.5f;
    //private float pre_pos;
    private float pos_y;
    private float pos_x;
    public Material material;
    public bool end_cg;

    // Start is called before the first frame update
    void Start()
    {
        TM = GameObject.Find("Title_Manager").gameObject.GetComponent<Title_Manager>();
        TS = GameObject.Find("Title_Manager").gameObject.GetComponent<Touch_Script>();
        SS = GameObject.Find("Title_Manager").gameObject.GetComponent<Shake_Script>();
        material.SetColor("_Color1", new Color(0.9f, 0.9f, 0.9f, 0));
        material.SetColor("_Color0", new Color(0.05f, 0.05f, 0.05f, 1));
    }

    // Update is called once per frame
    void Update()
    {
        if (TM.select_setting == 0)
        {
            pos_y = 0.5f;
        }
        else if (TM.select_setting == 1)
        {
            pos_y = 0.4f;
        }
        else if (TM.select_setting == 2)
        {
            pos_y = 0.2f;
        }

        if (SS.shake == true && waveform_pos_x <=0.91f)
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
