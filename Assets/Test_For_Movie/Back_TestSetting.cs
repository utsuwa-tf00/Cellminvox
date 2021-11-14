using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Back_TestSetting : MonoBehaviour
{
    private Touch_Script TS;
    private Shake_Script SS;

    // Start is called before the first frame update
    void Start()
    {
        TS = GameObject.Find("Cellmin1").gameObject.GetComponent<Touch_Script>();
        SS = GameObject.Find("Cellmin1").gameObject.GetComponent<Shake_Script>();
    }

    // Update is called once per frame
    void Update()
    {
        if (SS.shake == true)
        {
            if(TS.back == true)
            {
                SceneManager.LoadScene("Test_Setting");
            }
            else
            {
                SS.shake = false;
            }
        }
    }
}
