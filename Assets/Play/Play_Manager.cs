using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Play_Manager : MonoBehaviour
{
    private PlayState PS;
    private PlayState2 PS2;
    private Touch_Script TS;
    private Shake_Script SS;
    private Line_Script LS;

    public GameObject sin1;
    public GameObject square1;
    public GameObject triangle1;
    public GameObject saw1;

    public GameObject Cellmin1;
    public GameObject Cellmin2;

    public GameObject sin2;
    public GameObject square2;
    public GameObject triangle2;
    public GameObject saw2;

    //public bool multiphonic;

    public GameObject ImageRotate;
    public float R_value;
    public float R_value_pre;
    public bool rotate_now;

    public Material Image;
    public Material Image2;

    private Frequency CF1;
    private Frequency2 CF2;
    public Text SoundName1;
    public Text SoundName2;
    private float col1;
    private float col2;
    private float col1_pre;
    private float col2_pre;

    public static bool PlayCellmin;

    // Start is called before the first frame update
    void Start()
    {
        TS = GetComponent<Touch_Script>();
        PS = GameObject.Find("Cellmin1").gameObject.GetComponent<PlayState>();
        PS2 = Cellmin2.GetComponent<PlayState2>();
        SS = GetComponent<Shake_Script>();
        LS = GetComponent<Line_Script>();
        CF1 = Cellmin1.GetComponent<Frequency>();
        CF2 = Cellmin2.GetComponent<Frequency2>();

        col1_pre = 0.05f;
        col2_pre = 0.05f;

        PlayCellmin = true;
    }

    //振動の実行
    void Vibration()
    {
        VibrationMng.ShortVibration();
    }

    void TextChange()
    {
        if(Setting_GM.auto_pich == true)
        {
            if(Setting_GM.double_tone == true)
            {
                SoundName1.text = CF1.sound_name;
                SoundName2.text = CF2.sound_name;
            }
            else if(Setting_GM.double_tone == false)
            {
                SoundName1.text = "";
                SoundName2.text = CF1.sound_name;
                
            }
        }
        else
        {
            SoundName1.text = "";
            SoundName2.text = "";
        }

        SoundName1.color = new Color(col1,col1,col1,1);
        SoundName2.color = new Color(col2,col2,col2,1);

        Image.color = new Color(col1,col1,col1,1);
        Image2.color = new Color(col2,col2,col2,1);
    }

    // Update is called once per frame
    void Update()
    {
        //Setting_GM.double_tone = multiphonic;

        LS.color_switch = false;

        if (SS.shake == true)
        {
            if(TS.back == true)
            {
                Vibration();
                PlayCellmin = false;
                SceneManager.LoadScene("Title");
            }
            else
            {
                SS.shake = false;
            }
        }

        if (PS.wave_name == "sin")
        {
            sin1.SetActive(true);
            square1.SetActive(false);
            triangle1.SetActive(false);
            saw1.SetActive(false);
        }
        else if (PS.wave_name == "square")
        {
            sin1.SetActive(false);
            square1.SetActive(true);
            triangle1.SetActive(false);
            saw1.SetActive(false);
        }
        else if (PS.wave_name == "triangle")
        {
            sin1.SetActive(false);
            square1.SetActive(false);
            triangle1.SetActive(true);
            saw1.SetActive(false);
        }
        else if (PS.wave_name == "saw")
        {
            sin1.SetActive(false);
            square1.SetActive(false);
            triangle1.SetActive(false);
            saw1.SetActive(true);
        }

        if(Setting_GM.double_tone == true)
        {
            if (PS2.wave_name == "sin")
            {
                sin2.SetActive(true);
                square2.SetActive(false);
                triangle2.SetActive(false);
                saw2.SetActive(false);
            }
            else if (PS2.wave_name == "square")
            {
                sin2.SetActive(false);
                square2.SetActive(true);
                triangle2.SetActive(false);
                saw2.SetActive(false);
            }
            else if (PS2.wave_name == "triangle")
            {
                sin2.SetActive(false);
                square2.SetActive(false);
                triangle2.SetActive(true);
                saw2.SetActive(false);
            }
            else if (PS2.wave_name == "saw")
            {
                sin2.SetActive(false);
                square2.SetActive(false);
                triangle2.SetActive(false);
                saw2.SetActive(true);
            }
            Cellmin2.SetActive(true);
        }
        else
        {
            sin2.SetActive(false);
            square2.SetActive(false);
            triangle2.SetActive(false);
            saw2.SetActive(false);
            Cellmin2.SetActive(false);
        }

        

        if(Setting_GM.double_tone == true){
            sin1.transform.position = new Vector3(0, 0.5f, 2);
            square1.transform.position = new Vector3(0, 0.5f, 2);
            triangle1.transform.position = new Vector3(0, 0.5f, 2);
            saw1.transform.position = new Vector3(0, 0.5f, 2);

            sin1.transform.localScale = new Vector3(1, 0.6f, 2);
            square1.transform.localScale = new Vector3(1, 0.6f, 2);
            triangle1.transform.localScale = new Vector3(1, 0.6f, 2);
            saw1.transform.localScale = new Vector3(1, 0.6f, 1);
        }
        else
        {
            sin1.transform.position = new Vector3(0, 0, 0);
            square1.transform.position = new Vector3(0, 0, 0);
            triangle1.transform.position = new Vector3(0, 0, 0);
            saw1.transform.position = new Vector3(0, 0, 0);

            sin1.transform.localScale = new Vector3(1, 1, 2);
            square1.transform.localScale = new Vector3(1, 1, 2);
            triangle1.transform.localScale = new Vector3(1, 1, 2);
            saw1.transform.localScale = new Vector3(1, 1, 2);
        }

        
        if(Setting_GM.double_tone == false)
        {
            col1_pre = 0.9f;
            col2_pre = 0.9f;
        }
        else if(Setting_GM.double_tone == true)
        {
            if(rotate_now == true)
            {
                //R_value_pre = 0;
                col1_pre = 0.35f;
                col2_pre = 0.9f;
                if(TS.rotate == true)
                {
                    rotate_now = false;
                    TS.rotate = false;
                }
            }
            else if(rotate_now == false)
            {
                //R_value_pre = 180;
                col1_pre = 0.9f;
                col2_pre = 0.35f;
                if(TS.rotate == true)
                {
                    rotate_now = true;
                    TS.rotate = false;
                }
            }
        }
        
        
        col1 = Mathf.Lerp(col1, col1_pre, 0.075f);
        col2 = Mathf.Lerp(col2, col2_pre, 0.075f);

        //R_value = Mathf.Lerp(R_value, R_value_pre, 0.25f);
        //ImageRotate.transform.rotation = Quaternion.Euler( 0f, 0f, R_value);

        TextChange();
    }
}
