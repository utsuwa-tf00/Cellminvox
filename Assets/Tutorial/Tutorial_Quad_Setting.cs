using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutorial_Quad_Setting : MonoBehaviour
{
    public GameObject Tutorial_Manager;
    private Tutorial_Manager TM;

    public float waveform_pos_y = 0.5f;
    public float waveform_pos_x = 1.5f;
    //private float pre_pos;
    public float pos_y;
    public float pos_x;
    public Material material;
    public bool end_cg;

    // Start is called before the first frame update
    void Start()
    {
        TM = Tutorial_Manager.GetComponent<Tutorial_Manager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (TM.clear_tutorial == true)
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
        material.SetFloat("_Col",TM.col);


        if (waveform_pos_x <= -0.1f)
        {
            end_cg = true;
        }
    }
}
