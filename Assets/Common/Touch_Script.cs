using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Touch_Script : MonoBehaviour
{

    public bool touch_solo = false;
    public bool touch_duo = false;
    public bool touch_trio = false;

    public bool touch_now0 = false;
    public bool touch_now1 = false;
    public bool touch_now2 = false;
    public bool touch0_switch = false;
    public bool touch1_switch = false;
    public bool touch2_switch = false;


    public bool swipe_X_plus;
    public bool swipe_X_minus;
    public bool swipe_Y_plus;
    public bool swipe_Y_minus;
    //private bool swipe;

    public Vector2 touch0_position;
    public Vector2 touch1_position;
    public Vector2 pre_touch0_position;
    public Vector2 touch2_position;

    private Vector3 touch0_vec3;
    private Vector3 touch1_vec3;
    private Vector3 pre_touch0_vec3;
    private Vector3 touch2_vec3;

    public Vector3 W_touch0;
    public Vector3 W_touch1;
    public Vector3 W_pre_touch0;
    public Vector3 W_touch2;

    private Vector2 touch0_start;
    private Vector2 touch0_end;

    private float pos_move_speed = 5f;

    private float duo_distans;
    public bool duo_end;

    private int touchCount;

    public bool longtone = false;
    public float longtone_volume;
    public bool back = false;

    private float minSwipeDist = 40;
    private float swipeDistX;
    private float swipeDistY;
    private float SignValueX;
    private float SignValueY;
    private Vector2 startPos;
    private Vector2 endPos;

    public bool rotate;


    public float SwipeModeValue;
    private float dx;
    private float dy;
    public float SwipeToFreq;


    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        switch (Input.touchCount)
        {
            case 1:
                var touch = Input.GetTouch(0);
                switch (touch.phase)
                {
                    case TouchPhase.Began:
                        // 画面に指が触れた時
                        touch_duo = false;
                        longtone = false;
                        touch_solo = true;
                        touch_now0 = true;
                        touch0_switch = true;

                        pre_touch0_position = touch.position;
                        touch0_position = touch.position;
                        //pre_touch0_position = touch0_position;

                        startPos = touch.position;
                        break;

                    case TouchPhase.Moved:
                        // 画面上で指が動いたとき
                        touch_solo = true;
                        //swipe = true;
                        touch0_position = touch.position;
                        touch0_switch = true;
                        break;

                    case TouchPhase.Stationary:
                        // 指が画面に触れているが動いてはいない時
                        touch_solo = true;
                        //swipe = true;
                        touch0_position = touch.position;
                        touch0_switch = true;
                        break;

                    case TouchPhase.Ended:
                        // 画面から指が離れた時
                        touch_solo = false;
                        //touch0_position = new Vector2(0, 0);

                        endPos = touch.position;

                        swipeDistX = (new Vector3(endPos.x, 0, 0) - new Vector3(startPos.x, 0, 0)).magnitude;
                        print("X" + swipeDistX.ToString());
                        if (swipeDistX > minSwipeDist)
                        {
                            SignValueX = Mathf.Sign(endPos.x - startPos.x);

                            if (SignValueX > 0)
                            {
                                //右方向にスワイプしたとき
                                //ここに処理を書いてください
                                swipe_X_plus = true;
                            }
                            else if (SignValueX < 0)
                            {
                                //左方向にスワイプしたとき
                                //ここに処理を書いてください
                                swipe_X_minus = true;
                            }
                        }

                        swipeDistY = (new Vector3(0, endPos.y, 0) - new Vector3(0, startPos.y, 0)).magnitude;
                        //差分が最低スワイプ分を超えていた場合
                        if (swipeDistY > minSwipeDist)
                        {
                            SignValueY = Mathf.Sign(endPos.y - startPos.y);

                            if (SignValueY > 0)
                            {
                                //sin = 1
                                //上方向にスワイプしたとき
                                //ここに処理を書いてください
                                swipe_Y_plus = true;
                            }
                            else if (SignValueY < 0)
                            {
                                //sin = -1
                                //下方向にスワイプしたとき
                                //ここに処理を書いてください
                                swipe_Y_minus = true;
                            }
                        }

                        startPos = new Vector2(0, 0);
                        endPos = new Vector2(0, 0);

                        touch0_switch = false;

                        break;
                    case TouchPhase.Canceled:
                        // システムがタッチの追跡をキャンセルした時
                        touch_solo = false;
                        touch0_switch = false;
                        //swipe = false;
                        //touch0_position = new Vector2(0, 0);
                        break;
                }
                back = false;
                break;

            case 2:
                var touch0 = Input.GetTouch(0);
                var touch1 = Input.GetTouch(1);
                longtone = true;
                switch (touch0.phase)
                {
                    case TouchPhase.Began:
                        // 画面に指が触れた時
                        touch_solo = false;
                        touch0_position = touch0.position;
                        touch0_switch = true;
                        break;
                    case TouchPhase.Moved:
                        // 画面上で指が動いたとき
                        touch_solo = false;
                        touch0_position = touch0.position;
                        touch0_switch = true;
                        break;
                    case TouchPhase.Stationary:
                        // 指が画面に触れているが動いてはいない時
                        touch_solo = false;
                        touch0_position = touch0.position;
                        touch0_switch = true;
                        break;
                    case TouchPhase.Ended:
                        // 画面から指が離れた時
                        touch_solo = false;
                        //touch0_position = new Vector2(0, 0);
                        longtone = false;
                        touch0_switch = false;
                        break;
                    case TouchPhase.Canceled:
                        // システムがタッチの追跡をキャンセルした時
                        touch_solo = false;
                        //touch0_position = new Vector2(0, 0);
                        longtone = false;
                        touch0_switch = false;
                        break;
                }
                switch (touch1.phase)
                {
                    case TouchPhase.Began:
                        // 画面に指が触れた時
                        touch_duo = true;
                        touch1_position = touch1.position;
                        touch_now1 = true;
                        touch1_switch = true;
                        break;
                    case TouchPhase.Moved:
                        // 画面上で指が動いたとき
                        touch_duo = true;
                        touch1_position = touch1.position;
                        touch1_switch = true;
                        break;
                    case TouchPhase.Stationary:
                        // 指が画面に触れているが動いてはいない時
                        touch_duo = true;
                        touch1_position = touch1.position;
                        touch1_switch = true;
                        break;
                    case TouchPhase.Ended:
                        // 画面から指が離れた時
                        touch_duo = false;
                        //touch1_position = new Vector2(0, 0);
                        longtone = false;
                        touch1_switch = false;
                        pre_touch0_position = touch1_position;
                        break;
                    case TouchPhase.Canceled:
                        // システムがタッチの追跡をキャンセルした時
                        touch_duo = false;
                        //touch1_position = new Vector2(0, 0);
                        longtone = false;
                        touch1_switch = false;
                        pre_touch0_position = touch1_position;
                        break;
                }
                back = false;
                break;

            case 3:
                var touch0_1 = Input.GetTouch(0);
                var touch1_1 = Input.GetTouch(1);
                var touch2 = Input.GetTouch(2);
                switch (touch0_1.phase)
                {
                    case TouchPhase.Began:
                        // 画面に指が触れた時
                        touch0_position = touch0_1.position;
                        touch0_switch = true;
                        break;
                    case TouchPhase.Moved:
                        // 画面上で指が動いたとき
                        touch0_position = touch0_1.position;
                        touch0_switch = true;
                        break;
                    case TouchPhase.Stationary:
                        // 指が画面に触れているが動いてはいない時
                        touch0_position = touch0_1.position;
                        touch0_switch = true;
                        break;
                    case TouchPhase.Ended:
                        // 画面から指が離れた時
                        touch0_switch = false;
                        break;
                    case TouchPhase.Canceled:
                        // システムがタッチの追跡をキャンセルした時
                        touch0_switch = false;
                        break;
                }
                switch (touch1_1.phase)
                {
                    case TouchPhase.Began:
                        // 画面に指が触れた時
                        touch1_position = touch1_1.position;
                        touch1_switch = true;
                        break;
                    case TouchPhase.Moved:
                        // 画面上で指が動いたとき
                        touch1_position = touch1_1.position;
                        touch1_switch = true;
                        break;
                    case TouchPhase.Stationary:
                        // 指が画面に触れているが動いてはいない時
                        touch1_position = touch1_1.position;
                        touch1_switch = true;
                        break;
                    case TouchPhase.Ended:
                        // 画面から指が離れた時
                        touch1_switch = false;
                        break;
                    case TouchPhase.Canceled:
                        // システムがタッチの追跡をキャンセルした時
                        touch1_switch = false;
                        break;
                }
                switch (touch2.phase)
                {
                    case TouchPhase.Began:
                        // 画面に指が触れた時
                        touch2_position = touch2.position;
                        back = true;
                        touch_now2 = true;
                        touch2_switch = true;
                        break;
                    case TouchPhase.Moved:
                        // 画面上で指が動いたとき
                        touch2_position = touch2.position;
                        back = true;
                        touch2_switch = true;
                        break;
                    case TouchPhase.Stationary:
                        // 指が画面に触れているが動いてはいない時
                        touch2_position = touch2.position;
                        back = true;
                        touch2_switch = true;
                        break;
                    case TouchPhase.Ended:
                        // 画面から指が離れた時
                        back = false;
                        touch2_switch = false;
                        rotate = true;
                        break;
                    case TouchPhase.Canceled:
                        // システムがタッチの追跡をキャンセルした時
                        back = false;
                        touch2_switch = false;
                        break;
                }

                break;
        }

        if(touch_solo == true)
        {
            pos_move_speed = 2.5f;
        }
        else if(touch_solo == false && touch_duo == false)
        {
            pos_move_speed = 5;
        }

        touch0_start = pre_touch0_position;
        touch0_end = touch0_position;
        pre_touch0_position = Vector2.Lerp(touch0_start, touch0_end, pos_move_speed * Time.deltaTime);

        

        touch0_vec3 = new Vector3(touch0_position.x, touch0_position.y, 0);
        touch1_vec3 = new Vector3(touch1_position.x, touch1_position.y, 0);
        pre_touch0_vec3 = new Vector3(pre_touch0_position.x, pre_touch0_position.y, 0);
        touch2_vec3 = new Vector3(touch2_position.x, touch2_position.y, 0);

        W_touch0 = Camera.main.ScreenToWorldPoint(touch0_vec3);
        W_touch1 = Camera.main.ScreenToWorldPoint(touch1_vec3);
        W_pre_touch0 = Camera.main.ScreenToWorldPoint(pre_touch0_vec3);
        W_touch2 = Camera.main.ScreenToWorldPoint(touch2_vec3);

        W_touch0.z = 0;
        W_touch1.z = 0;
        W_pre_touch0.z = 0;
        W_touch2.z = 0;
        
        if(Setting_GM.swipe_mode == true)
        {
            if(longtone == false)
            {
                SwipeModeValue = Mathf.Atan2(W_touch0.x,W_touch0.y) * Mathf.Rad2Deg;
                SwipeToFreq = (SwipeModeValue/180 + 1)/2;
            }
            else
            {
                SwipeModeValue = Mathf.Atan2(W_touch0.x,W_touch0.y) * Mathf.Rad2Deg;
                SwipeToFreq = (SwipeModeValue/180 + 1)/2;
            }
        }


        /*
        if (swipe == true)
        {
            if (pre_touch0_position.x - touch0_position.x <= 0)
            {
                swipe_X_plus = true;
                swipe = false;
            }

            if (pre_touch0_position.x - touch0_position.x >= 0)
            {
                swipe_X_minus = true;
                swipe = false;
            }

            if (pre_touch0_position.y - touch0_position.y <= 0)
            {
                swipe_Y_plus = true;
                swipe = false;
            }

            if (pre_touch0_position.y - touch0_position.y >= 0)
            {
                swipe_Y_minus = true;
                swipe = false;
            }
        }
        */

        /*
        if (touch_duo == true)
        {
            duo_distans = Vector2.Distance(touch0_position, touch1_position);
            longtone_volume = duo_distans / Screen.height;
            if (longtone_volume >= 1)
            {
                longtone_volume = 1;
            }
        }
        else if (touch_duo == false)
        {
            if (longtone_volume > 0)
            {
                longtone_volume = longtone_volume - 0.05f;
            }
        }
        */

    }
}
