using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cellmin2_Manager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Setting_GM.double_tone == false)
        {
            gameObject.SetActive(false);
        }
        else if (Setting_GM.double_tone == true)
        {
            gameObject.SetActive(true);
        }
    }
}
