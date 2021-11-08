using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Line_Script : MonoBehaviour
{
    private Touch_Script TS;
    private LineRenderer line;
    public GameObject Touch_Effect;
    public bool color_switch;
    private float width;

    private Color color1;

    private Vector3 PointO = new Vector3(0,0,0);

    //public GameObject trail;

    // Start is called before the first frame update
    void Start()
    {
        TS = GetComponent<Touch_Script>();
        line = GetComponent<LineRenderer>();
        line.positionCount = 2;
        line.numCapVertices = 10;
        line.numCornerVertices = 10;
    }

    // Update is called once per frame
    void Update()
    {
        if (color_switch == true)
        {
            color1 = new Color(0.05f, 0.05f, 0.05f, 1);
        }
        else if (color_switch == false)
        {
            color1 = new Color(0.9f, 0.9f, 0.9f, 1);
        }

        if (TS.touch_now0 == true)
        {
            var parent = this.transform;
            GameObject instance0 = (GameObject)Instantiate(Touch_Effect, TS.W_touch0, Quaternion.Euler(0, 0, 0), parent);
            TES_play tes0 = instance0.GetComponent<TES_play>();
            tes0.Effect_Num = 0;
            tes0.color = color1;
            TS.touch_now0 = false;
        }
        /*
        else if (TS.touch_now1 == true)
        {
            var parent = this.transform;
            GameObject instance1 = (GameObject)Instantiate(Touch_Effect, TS.W_touch1, Quaternion.Euler(0, 0, 0), parent);
            TES_play tes1 = instance1.GetComponent<TES_play>();
            tes1.Effect_Num = 1;
            TS.touch_now1 = false;
        }
        else if (TS.touch_now2 == true)
        {
            var parent = this.transform;
            GameObject instance2 = (GameObject)Instantiate(Touch_Effect, TS.W_touch2, Quaternion.Euler(0, 0, 0), parent);
            TES_play tes2 = instance2.GetComponent<TES_play>();
            tes2.Effect_Num = 2;
            TS.touch_now2 = false;
        }
        */

        if (TS.back == true)
        {
            line.positionCount = 4;
            line.SetPosition(0, TS.W_touch0);
            line.SetPosition(1, TS.W_touch1);
            line.SetPosition(2, TS.W_touch2);
            line.SetPosition(3, TS.W_touch0);
            //line.SetColors(color1, color1);
        }
        else if (TS.back == false)
        {
            if(Setting_GM.swipe_mode == true && Play_Manager.PlayCellmin == true)
            {
                line.positionCount = 3;
                if (TS.longtone == true)
                {
                    //line.positionCount = 2;
                    line.SetPosition(0, PointO);
                    line.SetPosition(1, TS.W_touch0);
                    line.SetPosition(2, TS.W_touch1);
                    //line.SetColors(color1, color1);
                }
                else if (TS.longtone == false)
                {
                    line.SetPosition(0, PointO);
                    line.SetPosition(1, TS.W_touch0);
                    line.SetPosition(2, TS.W_pre_touch0);
                    //line.SetColors(color1, color1);
                    //trail.transform.position = TS.W_touch0;
                    //line.positionCount = 2;
                }
            }
            else
            {
                line.positionCount = 2;
                if (TS.longtone == true)
                {
                    //line.positionCount = 2;
                    line.SetPosition(0, TS.W_touch0);
                    line.SetPosition(1, TS.W_touch1);
                    //line.SetColors(color1, color1);
                }
                else if (TS.longtone == false)
                {
                    line.SetPosition(0, TS.W_touch0);
                    line.SetPosition(1, TS.W_pre_touch0);
                    //line.SetColors(color1, color1);
                    //trail.transform.position = TS.W_touch0;
                    //line.positionCount = 2;
                }
            }
            
        }

        if (TS.touch0_switch == true)
        {
            width = Mathf.Lerp(width, 0.1f, 0.1f);
        }
        else
        {
            width = Mathf.Lerp(width, 0, 0.1f);
        }
        line.startWidth = width;
        line.endWidth = width;
    }
}
