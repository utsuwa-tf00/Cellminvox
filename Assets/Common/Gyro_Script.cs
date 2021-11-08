using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gyro_Script : MonoBehaviour
{
    private Gyroscope gyro_value;
    public float gyro_value_x;
    public float gyro_value_y;

    // Start is called before the first frame update
    void Start()
    {
        Input.gyro.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        gyro_value = Input.gyro;
        gyro_value_x = (gyro_value.attitude.y + 1) / 2;
        gyro_value_y = (-gyro_value.attitude.x + 1) / 2;
    }
}
