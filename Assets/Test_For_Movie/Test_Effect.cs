using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_Effect : MonoBehaviour
{
    public Material RadialBlur;
    public Material mosaic;
    public Material ChromaticAberration;
    public Material Nausea;

    public GameObject Cellmin2;
    private Volume CV2;
    private PlayState2 PS2;
    private bool multiphonic;
    private string wave;

    private float width;
    private float height;
    private float ratio;
    public float sprite = 10;

    void Start() 
    {
        PS2 = Cellmin2.GetComponent<PlayState2>();
        CV2 = Cellmin2.GetComponent<Volume>();
        
    }

    void RadialBlurUpdate()
    {
        RadialBlur.SetFloat("_Strength",CV2.volume);
    }

    void MosaicUpdate()
    {
        width = Screen.width;
        height = Screen.height;

        ratio = height/width;

        sprite = 50 - 50*CV2.volume;

        mosaic.SetFloat("_Width",sprite);
        mosaic.SetFloat("_Height",sprite*ratio);
    }

    void ChromaticAberrationUpdate()
    {
        ChromaticAberration.SetFloat("_Size",0.5f*CV2.volume);
    }

    void NauseaUpdate()
    {
        Nausea.SetFloat("_Amp",0.1f*CV2.volume);
        //Nausea.SetFloat("_T",1 - 0.75f*CV2.volume);
    }

    void Update() 
    {
        multiphonic = Setting_GM.double_tone;
        wave = PS2.wave_name;

        RadialBlurUpdate();
        MosaicUpdate();
        ChromaticAberrationUpdate();
        NauseaUpdate();
    }

    void OnRenderImage(RenderTexture src, RenderTexture dest)
    {
        if(wave == "sin")
        {
            Graphics.Blit(src, dest,RadialBlur);
        }
        else if(wave == "square")
        {
            Graphics.Blit(src, dest, mosaic);
        }
        else if(wave == "triangle")
        {
            Graphics.Blit(src, dest, ChromaticAberration);
        }
        else if(wave == "saw")
        {
            Graphics.Blit(src, dest, Nausea);
        }
    }
}
