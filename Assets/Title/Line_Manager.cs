using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Line_Manager : MonoBehaviour
{
    public GameObject line1;
    public GameObject line2;
    public GameObject line3;

    private Title_Manager TM;

    // Start is called before the first frame update
    void Start()
    {
        TM = GetComponent<Title_Manager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (TM.select_setting == 0)
        {
            line1.SetActive(true);
            line2.SetActive(false);
            line3.SetActive(false);
        }
        else if (TM.select_setting == 1)
        {
            line1.SetActive(false);
            line2.SetActive(true);
            line3.SetActive(false);
        }
        else if (TM.select_setting == 2)
        {
            line1.SetActive(false);
            line2.SetActive(false);
            line3.SetActive(true);
        }
    }
}
