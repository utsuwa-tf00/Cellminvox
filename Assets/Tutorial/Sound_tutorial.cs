using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound_tutorial : MonoBehaviour
{
    private Volume VV;
    private Frequency FV;
    private PlayState_tutorial PV;

    private string PlayState;
    private float freq;
    private float increment;
    //private float phase;
    private float time;
    //private float SampleRate = 44100;
    private float SampleRate = 48000;
    private float vol;


    void SineWave(float[] data, int channels)
    {
        increment = freq * 4 * Mathf.PI / SampleRate;
        for (var i = 0; i < data.Length; i = i + channels)
        {
            time = time + increment;
            data[i] = Mathf.Sin(time);
            if (channels == 2) data[i + 1] = data[i];
            if (time > 2 * Mathf.PI) time = 0;
        }
    }

    void SquareWave(float[] data, int channels)
    {
        increment = freq * 4 * Mathf.PI / SampleRate;
        for (var i = 0; i < data.Length; i = i + channels)
        {
            time = time + increment;
            if (time > -Mathf.PI && time <= 0) data[i] = -1;
            if (time > 0 && time <= Mathf.PI) data[i] = 1;
            if (channels == 2) data[i + 1] = data[i];
            if (time > 2 * Mathf.PI) time = 0;
        }
    }

    void TriangleWave(float[] data, int channels)
    {
        increment = freq * 4 * Mathf.PI / SampleRate;
        for (var i = 0; i < data.Length; i = i + channels)
        {
            time = time + increment;
            if (time > -Mathf.PI && time <= -Mathf.PI / 2) data[i] = -2 * (time + Mathf.PI);
            if (time > -Mathf.PI / 2 && time <= Mathf.PI / 2) data[i] = 2 * time;
            if (time > Mathf.PI / 2 && time <= Mathf.PI) data[i] = -2 * (time - Mathf.PI);
            if (channels == 2) data[i + 1] = data[i];
            if (time > 2 * Mathf.PI) time = 0;
        }
    }

    void SawtoothWave(float[] data, int channels)
    {
        increment = freq * 4 * Mathf.PI / SampleRate;
        for (var i = 0; i < data.Length; i = i + channels)
        {
            time = time + increment;
            data[i] = (float)(0.5 * ((time + Mathf.PI) % (Mathf.PI * 2)) / Mathf.PI - 1.0);
            if (channels == 2) data[i + 1] = data[i];
            if (time > 2 * Mathf.PI) time = 0;
        }
    }

    void OnAudioFilterRead(float[] data, int channels)
    {
        switch (PlayState)
        {
            case "sin":
                SineWave(data, channels);
                break;
            case "square":
                SquareWave(data, channels);
                break;
            case "triangle":
                TriangleWave(data, channels);
                break;
            case "saw":
                SawtoothWave(data, channels);
                break;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        VV = GetComponent<Volume>();
        FV = GetComponent<Frequency>();
        PV = GetComponent<PlayState_tutorial>();
    }

    // Update is called once per frame
    void Update()
    {
        vol = VV.volume;
        freq = FV.freq;
        GetComponent<AudioSource>().volume = vol;
        PlayState = PV.wave_name;
    }
}
