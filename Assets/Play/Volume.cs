using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Volume : MonoBehaviour
{
    private Touch_Script TS;

    private Vector2 pos1;
    private Vector2 pos2;
    //private float move;

    //private float move1;
    //private float move2;
    //private float move_value;

    //private float MIN_move = 0;
    //private float MAX_move = 75;

    public float volume;
    // Start is called before the first frame update
    void Start()
    {
        TS = GetComponent<Touch_Script>();
    }

    // Update is called once per frame
    void Update()
    {
        if (TS.back == false)
        {
            if(Setting_GM.swipe_mode == true)
            {
                if (TS.longtone == true)
                {
                    volume = Vector2.Distance(TS.touch0_position, TS.touch1_position) / Screen.width;
                    if (volume >= 1)
                    {
                        volume = 1;
                    }
                }
                else if (TS.longtone == false)
                {
                    volume = Vector2.Distance(TS.touch0_position, TS.pre_touch0_position) / ((Screen.width/8)*3);
                    if (volume >= 1)
                    {
                        volume = 1;
                    }
                }
            }
            else
            {
                if (TS.longtone == true)
                {
                    volume = Vector2.Distance(TS.touch0_position, TS.touch1_position) / Screen.height;
                    if (volume >= 1)
                    {
                        volume = 1;
                    }
                }
                else if (TS.longtone == false)
                {
                    volume = Vector2.Distance(TS.touch0_position, TS.pre_touch0_position) / ((Screen.height/4)*3);
                    if (volume >= 1)
                    {
                        volume = 1;
                    }
                }
            }
        }
        else
        {
            volume = 0;
        }
        
    }
}
