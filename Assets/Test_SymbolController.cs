using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_SymbolController : MonoBehaviour
{
    private PlayState PS;

    public GameObject sin;
    public GameObject square;
    public GameObject triangle;
    public GameObject saw;

    // Start is called before the first frame update
    void Start()
    {
        PS = GameObject.Find("Cellmin1").gameObject.GetComponent<PlayState>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Button_Symbol.Symbol == true)
        {
            if (PS.wave_name == "sin")
            {
                sin.SetActive(true);
                square.SetActive(false);
                triangle.SetActive(false);
                saw.SetActive(false);
            }
            else if (PS.wave_name == "square")
            {
                sin.SetActive(false);
                square.SetActive(true);
                triangle.SetActive(false);
                saw.SetActive(false);
            }
            else if (PS.wave_name == "triangle")
            {
                sin.SetActive(false);
                square.SetActive(false);
                triangle.SetActive(true);
                saw.SetActive(false);
            }
            else if (PS.wave_name == "saw")
            {
                sin.SetActive(false);
                square.SetActive(false);
                triangle.SetActive(false);
                saw.SetActive(true);
            }
        }
        else
        {
            sin.SetActive(false);
            square.SetActive(false);
            triangle.SetActive(false);
            saw.SetActive(false);
        }
    }
}
