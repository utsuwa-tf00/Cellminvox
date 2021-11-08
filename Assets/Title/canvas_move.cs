using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class canvas_move : MonoBehaviour
{
    //public GameObject GM;
    private float posX = 15;
    private float end_posX = 0;

    public Text T1;
    public Text T2;
    public Text T3;

    public GameObject TM;
    private Title_Manager TM_TM;

    private float Col_S = 0.5f;
    private float Col_E = 0.05f;
    private float Col_T1;
    private float Col_T2;
    private float Col_T3;
    private float Col_T1_p;
    private float Col_T2_p;
    private float Col_T3_p;

    public string wave_name;
    public GameObject Title1;
    public GameObject Title2;
    public GameObject Title3;
    public GameObject Title4;

    // Start is called before the first frame update
    void Start()
    {
        TM_TM = TM.GetComponent<Title_Manager>();
        wave_name = Setting_GM.change_wave;
    }

    // Update is called once per frame
    void Update()
    {
        if(TM_TM.select_setting == 0){
            Col_T1 = Col_E;
            Col_T2 = Col_S;
            Col_T3 = Col_S;
        }
        else if(TM_TM.select_setting == 1){
            Col_T1 = Col_S;
            Col_T2 = Col_E;
            Col_T3 = Col_S;
        }
        else if(TM_TM.select_setting == 2){
            Col_T1 = Col_S;
            Col_T2 = Col_S;
            Col_T3 = Col_E;
        }

        if(wave_name == "sin"){
            Title1.SetActive(true);
            Title2.SetActive(false);
            Title3.SetActive(false);
            Title4.SetActive(false);
        }
        else if(wave_name == "square"){
            Title1.SetActive(false);
            Title2.SetActive(true);
            Title3.SetActive(false);
            Title4.SetActive(false);
        }
        else if(wave_name == "triangle"){
            Title1.SetActive(false);
            Title2.SetActive(false);
            Title3.SetActive(true);
            Title4.SetActive(false);
        }
        else if(wave_name == "saw"){
            Title1.SetActive(false);
            Title2.SetActive(false);
            Title3.SetActive(false);
            Title4.SetActive(true);
        }

        Col_T1_p = Mathf.Lerp(Col_T1_p, Col_T1, 0.075f);
        Col_T2_p = Mathf.Lerp(Col_T2_p, Col_T2, 0.075f);
        Col_T3_p = Mathf.Lerp(Col_T3_p, Col_T3, 0.075f);

        T1.color = new Color(Col_T1_p,Col_T1_p,Col_T1_p,1);
        T2.color = new Color(Col_T2_p,Col_T2_p,Col_T2_p,1);
        T3.color = new Color(Col_T3_p,Col_T3_p,Col_T3_p,1);

        posX = Mathf.Lerp(posX, end_posX, 0.05f);
        this.gameObject.transform.position = new Vector3(posX, 0, 0);
    }
}
