using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TES_play : MonoBehaviour
{
    public Material material;
    private Touch_Script TS;
    public Color color;
    private float count;
    public int Effect_Num;

    // Start is called before the first frame update
    void Start()
    {
        TS = this.transform.parent.gameObject.GetComponent<Touch_Script>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Effect_Num == 0)
        {
            if (TS.touch0_switch == true)
            {
                if (count < 0.5)
                {
                    count = count + 0.05f;
                }
                this.gameObject.GetComponent<Transform>().position = TS.W_touch0;
            }
            else if (TS.touch0_switch == false)
            {
                count = count - 0.05f;
                if (count < 0)
                {
                    Destroy(gameObject);
                }
            }
        }
        /*
        else if (Effect_Num == 1)
        {
            if (TS.touch1_switch == true)
            {
                if (count < 0.5)
                {
                    count = count + 0.05f;
                }
                this.gameObject.GetComponent<Transform>().position = TS.W_touch1;
            }
            else if (TS.touch1_switch == false)
            {
                count = count - 0.05f;
                if (count < 0)
                {
                    Destroy(gameObject);
                }
            }
        }
        else if (Effect_Num == 2)
        {
            if (TS.touch2_switch == true)
            {
                if (count < 0.5)
                {
                    count = count + 0.05f;
                }
                this.gameObject.GetComponent<Transform>().position = TS.W_touch2;
            }
            else if (TS.touch2_switch == false)
            {
                count = count - 0.05f;
                if (count < 0)
                {
                    Destroy(gameObject);
                }
            }
        }
        */

        material.SetFloat("_Radius", count);
        material.SetColor("_Color1", color);
    }
}
