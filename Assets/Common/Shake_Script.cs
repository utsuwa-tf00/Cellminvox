using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shake_Script : MonoBehaviour
{
    private Vector3 Acceleration;
    private Vector3 preAcceleration;
    private float DotProduct;

    private int time;
    private bool timekeeper;

    public bool shake = false;

    // Start is called before the first frame update
    void Start()
    {
        Input.gyro.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        preAcceleration = Acceleration;
        Acceleration = Input.acceleration;
        DotProduct = Vector3.Dot(Acceleration, preAcceleration);

        if (DotProduct < 0 && time == 0)
        {
            timekeeper = true;
            shake = true;
        }

        if (timekeeper == true)
        {
            time++;
            if (time == 20)
            {
                time = 0;
                timekeeper = false;
            }
        }


    }
}
