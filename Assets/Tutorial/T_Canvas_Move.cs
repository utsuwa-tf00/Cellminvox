using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class T_Canvas_Move : MonoBehaviour
{
    public float posX = 15;
    public float end_posX = 0;
    public bool posReset;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(posReset == true){
            posX = 15;
            this.gameObject.transform.position = new Vector3(15, 0, 0);
        }
        else
        {
            posX = Mathf.Lerp(posX, end_posX, 0.05f);
            this.gameObject.transform.position = new Vector3(posX, 0, 0);
        }
        
    }
}
