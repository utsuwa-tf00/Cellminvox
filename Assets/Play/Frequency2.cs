using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Frequency2 : MonoBehaviour
{
    private Gyro_Script GS;
    private int sound_number;

    public string sound_name;
    public bool semitone;
    public float color_count;
    public int dot_count;

    private int Max_freq_number;
    private int Min_freq_number;
    public int range;
    private int pitch;

    private float Max_freq;
    private float Min_freq;

    public bool auto_pich;

    public float freq;
    private float freq_number;
    private float freq_range;
    private float freq_number_range;

    private float dec;
    private int intege;


    // Start is called before the first frame update
    void Start()
    {
        GS = GetComponent<Gyro_Script>();
        range = Setting_GM.range_setting2;
        pitch = Setting_GM.pitch;
        auto_pich = Setting_GM.auto_pich;
    }

    // Update is called once per frame
    void Update()
    {
        if (auto_pich == false)
        {
            Min_freq_number = ((range - 1) * 12 - 8) + pitch;
            Max_freq_number = ((range + 1) * 12 - 8) + pitch;
            freq_range = Max_freq - Min_freq;
            freq = GS.gyro_value_y * freq_range + Min_freq / 2;

            //周波数ライブラリ_最低周波数取得
            switch (Min_freq_number)
            {
                /*
                default:
                    freq = 0.000f;
                    break;
                */
                case 1:
                    Min_freq = 27.500f;
                    break;

                case 2:
                    Min_freq = 29.135f;
                    break;

                case 3:
                    Min_freq = 30.868f;
                    break;

                case 4:
                    Min_freq = 32.703f;
                    break;

                case 5:
                    Min_freq = 34.648f;
                    break;

                case 6:
                    Min_freq = 36.708f;
                    break;

                case 7:
                    Min_freq = 38.891f;
                    break;

                case 8:
                    Min_freq = 41.203f;
                    break;

                case 9:
                    Min_freq = 43.654f;
                    break;

                case 10:
                    Min_freq = 46.249f;
                    break;

                case 11:
                    Min_freq = 48.999f;
                    break;

                case 12:
                    Min_freq = 51.913f;
                    break;

                case 13:
                    Min_freq = 55.000f;
                    break;

                case 14:
                    Min_freq = 58.270f;
                    break;

                case 15:
                    Min_freq = 61.735f;
                    break;

                case 16:
                    Min_freq = 65.406f;
                    break;

                case 17:
                    Min_freq = 69.296f;
                    break;

                case 18:
                    Min_freq = 73.416f;
                    break;

                case 19:
                    Min_freq = 77.782f;
                    break;

                case 20:
                    Min_freq = 82.407f;
                    break;

                case 21:
                    Min_freq = 87.307f;
                    break;

                case 22:
                    Min_freq = 92.499f;
                    break;

                case 23:
                    Min_freq = 97.999f;
                    break;

                case 24:
                    Min_freq = 103.826f;
                    break;

                case 25:
                    Min_freq = 110.000f;
                    break;

                case 26:
                    Min_freq = 116.541f;
                    break;

                case 27:
                    Min_freq = 123.471f;
                    break;

                case 28:
                    Min_freq = 130.813f;
                    break;

                case 29:
                    Min_freq = 138.591f;
                    break;

                case 30:
                    Min_freq = 146.832f;
                    break;

                case 31:
                    Min_freq = 155.563f;
                    break;

                case 32:
                    Min_freq = 164.814f;
                    break;

                case 33:
                    Min_freq = 174.614f;
                    break;

                case 34:
                    Min_freq = 184.997f;
                    break;

                case 35:
                    Min_freq = 195.998f;
                    break;

                case 36:
                    Min_freq = 207.652f;
                    break;

                case 37:
                    Min_freq = 220.000f;
                    break;

                case 38:
                    Min_freq = 233.082f;
                    break;

                case 39:
                    Min_freq = 246.942f;
                    break;

                case 40:
                    Min_freq = 261.626f;
                    break;

                case 41:
                    Min_freq = 277.183f;
                    break;

                case 42:
                    Min_freq = 293.665f;
                    break;

                case 43:
                    Min_freq = 311.127f;
                    break;

                case 44:
                    Min_freq = 329.628f;
                    break;

                case 45:
                    Min_freq = 349.228f;
                    break;

                case 46:
                    Min_freq = 369.994f;
                    break;

                case 47:
                    Min_freq = 391.995f;
                    break;

                case 48:
                    Min_freq = 415.305f;
                    break;

                case 49:
                    Min_freq = 440.000f;
                    break;

                case 50:
                    Min_freq = 466.164f;
                    break;

                case 51:
                    Min_freq = 493.883f;
                    break;

                case 52:
                    Min_freq = 523.251f;
                    break;

                case 53:
                    Min_freq = 554.365f;
                    break;

                case 54:
                    Min_freq = 587.330f;
                    break;

                case 55:
                    Min_freq = 622.254f;
                    break;

                case 56:
                    Min_freq = 659.255f;
                    break;

                case 57:
                    Min_freq = 698.456f;
                    break;

                case 58:
                    Min_freq = 739.989f;
                    break;

                case 59:
                    Min_freq = 783.991f;
                    break;

                case 60:
                    Min_freq = 830.609f;
                    break;

                case 61:
                    Min_freq = 880.000f;
                    break;

                case 62:
                    Min_freq = 932.328f;
                    break;

                case 63:
                    Min_freq = 987.767f;
                    break;

                case 64:
                    Min_freq = 1046.502f;
                    break;

                case 65:
                    Min_freq = 1108.731f;
                    break;

                case 66:
                    Min_freq = 1174.659f;
                    break;

                case 67:
                    Min_freq = 1244.508f;
                    break;

                case 68:
                    Min_freq = 1318.510f;
                    break;

                case 69:
                    Min_freq = 1396.913f;
                    break;

                case 70:
                    Min_freq = 1479.978f;
                    break;

                case 71:
                    Min_freq = 1567.982f;
                    break;

                case 72:
                    Min_freq = 1661.219f;
                    break;

                case 73:
                    Min_freq = 1760.000f;
                    break;

                case 74:
                    Min_freq = 1864.655f;
                    break;

                case 75:
                    Min_freq = 1975.533f;
                    break;

                case 76:
                    Min_freq = 2093.005f;
                    break;

                case 77:
                    Min_freq = 2217.461f;
                    break;

                case 78:
                    Min_freq = 2349.318f;
                    break;

                case 79:
                    Min_freq = 2489.016f;
                    break;

                case 80:
                    Min_freq = 2637.020f;
                    break;

                case 81:
                    Min_freq = 2793.826f;
                    break;

                case 82:
                    Min_freq = 2959.955f;
                    break;

                case 83:
                    Min_freq = 3135.963f;
                    break;

                case 84:
                    Min_freq = 3322.438f;
                    break;

                case 85:
                    Min_freq = 3520.000f;
                    break;

                case 86:
                    Min_freq = 3729.310f;
                    break;

                case 87:
                    Min_freq = 3951.066f;
                    break;

                case 88:
                    Min_freq = 4186.009f;
                    break;

            }

            //周波数ライブラリ_最高周波数取得
            switch (Max_freq_number)
            {
                /*
                default:
                    freq = 0.000f;
                    break;
                */
                case 1:
                    Max_freq = 27.500f;
                    break;

                case 2:
                    Max_freq = 29.135f;
                    break;

                case 3:
                    Max_freq = 30.868f;
                    break;

                case 4:
                    Max_freq = 32.703f;
                    break;

                case 5:
                    Max_freq = 34.648f;
                    break;

                case 6:
                    Max_freq = 36.708f;
                    break;

                case 7:
                    Max_freq = 38.891f;
                    break;

                case 8:
                    Max_freq = 41.203f;
                    break;

                case 9:
                    Max_freq = 43.654f;
                    break;

                case 10:
                    Max_freq = 46.249f;
                    break;

                case 11:
                    Max_freq = 48.999f;
                    break;

                case 12:
                    Max_freq = 51.913f;
                    break;

                case 13:
                    Max_freq = 55.000f;
                    break;

                case 14:
                    Max_freq = 58.270f;
                    break;

                case 15:
                    Max_freq = 61.735f;
                    break;

                case 16:
                    Max_freq = 65.406f;
                    break;

                case 17:
                    Max_freq = 69.296f;
                    break;

                case 18:
                    Max_freq = 73.416f;
                    break;

                case 19:
                    Max_freq = 77.782f;
                    break;

                case 20:
                    Max_freq = 82.407f;
                    break;

                case 21:
                    Max_freq = 87.307f;
                    break;

                case 22:
                    Max_freq = 92.499f;
                    break;

                case 23:
                    Max_freq = 97.999f;
                    break;

                case 24:
                    Max_freq = 103.826f;
                    break;

                case 25:
                    Max_freq = 110.000f;
                    break;

                case 26:
                    Max_freq = 116.541f;
                    break;

                case 27:
                    Max_freq = 123.471f;
                    break;

                case 28:
                    Max_freq = 130.813f;
                    break;

                case 29:
                    Max_freq = 138.591f;
                    break;

                case 30:
                    Max_freq = 146.832f;
                    break;

                case 31:
                    Max_freq = 155.563f;
                    break;

                case 32:
                    Max_freq = 164.814f;
                    break;

                case 33:
                    Max_freq = 174.614f;
                    break;

                case 34:
                    Max_freq = 184.997f;
                    break;

                case 35:
                    Max_freq = 195.998f;
                    break;

                case 36:
                    Max_freq = 207.652f;
                    break;

                case 37:
                    Max_freq = 220.000f;
                    break;

                case 38:
                    Max_freq = 233.082f;
                    break;

                case 39:
                    Max_freq = 246.942f;
                    break;

                case 40:
                    Max_freq = 261.626f;
                    break;

                case 41:
                    Max_freq = 277.183f;
                    break;

                case 42:
                    Max_freq = 293.665f;
                    break;

                case 43:
                    Max_freq = 311.127f;
                    break;

                case 44:
                    Max_freq = 329.628f;
                    break;

                case 45:
                    Max_freq = 349.228f;
                    break;

                case 46:
                    Max_freq = 369.994f;
                    break;

                case 47:
                    Max_freq = 391.995f;
                    break;

                case 48:
                    Max_freq = 415.305f;
                    break;

                case 49:
                    Max_freq = 440.000f;
                    break;

                case 50:
                    Max_freq = 466.164f;
                    break;

                case 51:
                    Max_freq = 493.883f;
                    break;

                case 52:
                    Max_freq = 523.251f;
                    break;

                case 53:
                    Max_freq = 554.365f;
                    break;

                case 54:
                    Max_freq = 587.330f;
                    break;

                case 55:
                    Max_freq = 622.254f;
                    break;

                case 56:
                    Max_freq = 659.255f;
                    break;

                case 57:
                    Max_freq = 698.456f;
                    break;

                case 58:
                    Max_freq = 739.989f;
                    break;

                case 59:
                    Max_freq = 783.991f;
                    break;

                case 60:
                    Max_freq = 830.609f;
                    break;

                case 61:
                    Max_freq = 880.000f;
                    break;

                case 62:
                    Max_freq = 932.328f;
                    break;

                case 63:
                    Max_freq = 987.767f;
                    break;

                case 64:
                    Max_freq = 1046.502f;
                    break;

                case 65:
                    Max_freq = 1108.731f;
                    break;

                case 66:
                    Max_freq = 1174.659f;
                    break;

                case 67:
                    Max_freq = 1244.508f;
                    break;

                case 68:
                    Max_freq = 1318.510f;
                    break;

                case 69:
                    Max_freq = 1396.913f;
                    break;

                case 70:
                    Max_freq = 1479.978f;
                    break;

                case 71:
                    Max_freq = 1567.982f;
                    break;

                case 72:
                    Max_freq = 1661.219f;
                    break;

                case 73:
                    Max_freq = 1760.000f;
                    break;

                case 74:
                    Max_freq = 1864.655f;
                    break;

                case 75:
                    Max_freq = 1975.533f;
                    break;

                case 76:
                    Max_freq = 2093.005f;
                    break;

                case 77:
                    Max_freq = 2217.461f;
                    break;

                case 78:
                    Max_freq = 2349.318f;
                    break;

                case 79:
                    Max_freq = 2489.016f;
                    break;

                case 80:
                    Max_freq = 2637.020f;
                    break;

                case 81:
                    Max_freq = 2793.826f;
                    break;

                case 82:
                    Max_freq = 2959.955f;
                    break;

                case 83:
                    Max_freq = 3135.963f;
                    break;

                case 84:
                    Max_freq = 3322.438f;
                    break;

                case 85:
                    Max_freq = 3520.000f;
                    break;

                case 86:
                    Max_freq = 3729.310f;
                    break;

                case 87:
                    Max_freq = 3951.066f;
                    break;

                case 88:
                    Max_freq = 4186.009f;
                    break;

            }
        }


        if (auto_pich == true)
        {
            Min_freq_number = ((range - 1) * 12 - 8) + pitch;
            Max_freq_number = ((range + 1) * 12 - 8) + pitch;
            freq_number_range = Max_freq_number - Min_freq_number;
            freq_number = GS.gyro_value_y * freq_number_range + Min_freq_number;


            dec = freq_number - Mathf.FloorToInt(freq_number);
            intege = Mathf.FloorToInt(dec * 10);
            if (intege >= 5)
            {
                sound_number = Mathf.CeilToInt(freq_number);
            }
            else
            {
                sound_number = Mathf.FloorToInt(freq_number);
            }

            //周波数ライブラリ
            switch (sound_number)
            {
                /*
                default:
                    freq = 0.000f;
                    break;
                */
                case 1:
                    freq = 27.500f;
                    sound_name = "A0";
                    semitone = false;
                    color_count = 5;
                    dot_count = 0;
                    break;

                case 2:
                    freq = 29.135f;
                    sound_name = "A#0";
                    semitone = true;
                    color_count = 5;
                    dot_count = 0;
                    break;

                case 3:
                    freq = 30.868f;
                    sound_name = "B0";
                    semitone = false;
                    color_count = 6;
                    dot_count = 0;
                    break;

                case 4:
                    freq = 32.703f;
                    sound_name = "C1";
                    semitone = false;
                    color_count = 0;
                    dot_count = 1;
                    break;

                case 5:
                    freq = 34.648f;
                    sound_name = "C#1";
                    semitone = true;
                    color_count = 0;
                    dot_count = 1;
                    break;

                case 6:
                    freq = 36.708f;
                    sound_name = "D1";
                    semitone = false;
                    color_count = 1;
                    dot_count = 1;
                    break;

                case 7:
                    freq = 38.891f;
                    sound_name = "D#1";
                    semitone = true;
                    color_count = 1;
                    dot_count = 1;
                    break;

                case 8:
                    freq = 41.203f;
                    sound_name = "E1";
                    semitone = false;
                    color_count = 2;
                    dot_count = 1;
                    break;

                case 9:
                    freq = 43.654f;
                    sound_name = "F1";
                    semitone = false;
                    color_count = 3;
                    dot_count = 1;
                    break;

                case 10:
                    freq = 46.249f;
                    sound_name = "F#1";
                    semitone = true;
                    color_count = 3;
                    dot_count = 1;
                    break;

                case 11:
                    freq = 48.999f;
                    sound_name = "G1";
                    semitone = false;
                    color_count = 4;
                    dot_count = 1;
                    break;

                case 12:
                    freq = 51.913f;
                    sound_name = "G#1";
                    semitone = true;
                    color_count = 4;
                    dot_count = 1;
                    break;

                case 13:
                    freq = 55.000f;
                    sound_name = "A1";
                    semitone = false;
                    color_count = 5;
                    dot_count = 1;
                    break;

                case 14:
                    freq = 58.270f;
                    sound_name = "A#1";
                    semitone = true;
                    color_count = 5;
                    dot_count = 1;
                    break;

                case 15:
                    freq = 61.735f;
                    sound_name = "B1";
                    semitone = false;
                    color_count = 6;
                    dot_count = 1;
                    break;

                case 16:
                    freq = 65.406f;
                    sound_name = "C2";
                    semitone = false;
                    color_count = 0;
                    dot_count = 2;
                    break;

                case 17:
                    freq = 69.296f;
                    sound_name = "C#2";
                    semitone = true;
                    color_count = 0;
                    dot_count = 2;
                    break;

                case 18:
                    freq = 73.416f;
                    sound_name = "D2";
                    semitone = false;
                    color_count = 1;
                    dot_count = 2;
                    break;

                case 19:
                    freq = 77.782f;
                    sound_name = "D#2";
                    semitone = true;
                    color_count = 1;
                    dot_count = 2;
                    break;

                case 20:
                    freq = 82.407f;
                    sound_name = "E2";
                    semitone = false;
                    color_count = 2;
                    dot_count = 2;
                    break;

                case 21:
                    freq = 87.307f;
                    sound_name = "F2";
                    semitone = false;
                    color_count = 3;
                    dot_count = 2;
                    break;

                case 22:
                    freq = 92.499f;
                    sound_name = "F#2";
                    semitone = true;
                    color_count = 3;
                    dot_count = 2;
                    break;

                case 23:
                    freq = 97.999f;
                    sound_name = "G2";
                    semitone = false;
                    color_count = 4;
                    dot_count = 2;
                    break;

                case 24:
                    freq = 103.826f;
                    sound_name = "G#2";
                    semitone = true;
                    color_count = 4;
                    dot_count = 2;
                    break;

                case 25:
                    freq = 110.000f;
                    sound_name = "A2";
                    semitone = false;
                    color_count = 5;
                    dot_count = 2;
                    break;

                case 26:
                    freq = 116.541f;
                    sound_name = "A#2";
                    semitone = true;
                    color_count = 5;
                    dot_count = 2;
                    break;

                case 27:
                    freq = 123.471f;
                    sound_name = "B2";
                    semitone = false;
                    color_count = 6;
                    dot_count = 2;
                    break;

                case 28:
                    freq = 130.813f;
                    sound_name = "C3";
                    semitone = false;
                    color_count = 0;
                    dot_count = 3;
                    break;

                case 29:
                    freq = 138.591f;
                    sound_name = "C#3";
                    semitone = true;
                    color_count = 0;
                    dot_count = 3;
                    break;

                case 30:
                    freq = 146.832f;
                    sound_name = "D3";
                    semitone = false;
                    color_count = 1;
                    dot_count = 3;
                    break;

                case 31:
                    freq = 155.563f;
                    sound_name = "D#3";
                    semitone = true;
                    color_count = 1;
                    dot_count = 3;
                    break;

                case 32:
                    freq = 164.814f;
                    sound_name = "E3";
                    semitone = false;
                    color_count = 2;
                    dot_count = 3;
                    break;

                case 33:
                    freq = 174.614f;
                    sound_name = "F3";
                    semitone = false;
                    color_count = 3;
                    dot_count = 3;
                    break;

                case 34:
                    freq = 184.997f;
                    sound_name = "F#3";
                    semitone = true;
                    color_count = 3;
                    dot_count = 3;
                    break;

                case 35:
                    freq = 195.998f;
                    sound_name = "G3";
                    semitone = false;
                    color_count = 4;
                    dot_count = 3;
                    break;

                case 36:
                    freq = 207.652f;
                    sound_name = "G#3";
                    semitone = true;
                    color_count = 4;
                    dot_count = 3;
                    break;

                case 37:
                    freq = 220.000f;
                    sound_name = "A3";
                    semitone = false;
                    color_count = 5;
                    dot_count = 3;
                    break;

                case 38:
                    freq = 233.082f;
                    sound_name = "A#3";
                    semitone = true;
                    color_count = 5;
                    dot_count = 3;
                    break;

                case 39:
                    freq = 246.942f;
                    sound_name = "B3";
                    semitone = false;
                    color_count = 6;
                    dot_count = 3;
                    break;

                case 40:
                    freq = 261.626f;
                    sound_name = "C4";
                    semitone = false;
                    color_count = 0;
                    dot_count = 4;
                    break;

                case 41:
                    freq = 277.183f;
                    sound_name = "C#4";
                    semitone = true;
                    color_count = 0;
                    dot_count = 4;
                    break;

                case 42:
                    freq = 293.665f;
                    sound_name = "D4";
                    semitone = false;
                    color_count = 1;
                    dot_count = 4;
                    break;

                case 43:
                    freq = 311.127f;
                    sound_name = "D#4";
                    semitone = true;
                    color_count = 1;
                    dot_count = 4;
                    break;

                case 44:
                    freq = 329.628f;
                    sound_name = "E4";
                    semitone = false;
                    color_count = 2;
                    dot_count = 4;
                    break;

                case 45:
                    freq = 349.228f;
                    sound_name = "F4";
                    semitone = false;
                    color_count = 3;
                    dot_count = 4;
                    break;

                case 46:
                    freq = 369.994f;
                    sound_name = "F#4";
                    semitone = true;
                    color_count = 3;
                    dot_count = 4;
                    break;

                case 47:
                    freq = 391.995f;
                    sound_name = "G4";
                    semitone = false;
                    color_count = 4;
                    dot_count = 4;
                    break;

                case 48:
                    freq = 415.305f;
                    sound_name = "G#4";
                    semitone = true;
                    color_count = 4;
                    dot_count = 4;
                    break;

                case 49:
                    freq = 440.000f;
                    sound_name = "A4";
                    semitone = false;
                    color_count = 5;
                    dot_count = 4;
                    break;

                case 50:
                    freq = 466.164f;
                    sound_name = "A#4";
                    semitone = true;
                    color_count = 5;
                    dot_count = 4;
                    break;

                case 51:
                    freq = 493.883f;
                    sound_name = "B4";
                    semitone = false;
                    color_count = 6;
                    dot_count = 4;
                    break;

                case 52:
                    freq = 523.251f;
                    sound_name = "C5";
                    semitone = false;
                    color_count = 0;
                    dot_count = 5;
                    break;

                case 53:
                    freq = 554.365f;
                    sound_name = "C#5";
                    semitone = true;
                    color_count = 0;
                    dot_count = 5;
                    break;

                case 54:
                    freq = 587.330f;
                    sound_name = "D5";
                    semitone = false;
                    color_count = 1;
                    dot_count = 5;
                    break;

                case 55:
                    freq = 622.254f;
                    sound_name = "D#5";
                    semitone = true;
                    color_count = 1;
                    dot_count = 5;
                    break;

                case 56:
                    freq = 659.255f;
                    sound_name = "E5";
                    semitone = false;
                    color_count = 2;
                    dot_count = 5;
                    break;

                case 57:
                    freq = 698.456f;
                    sound_name = "F5";
                    semitone = false;
                    color_count = 3;
                    dot_count = 5;
                    break;

                case 58:
                    freq = 739.989f;
                    sound_name = "F#5";
                    semitone = true;
                    color_count = 3;
                    dot_count = 5;
                    break;

                case 59:
                    freq = 783.991f;
                    sound_name = "G5";
                    semitone = false;
                    color_count = 4;
                    dot_count = 5;
                    break;

                case 60:
                    freq = 830.609f;
                    sound_name = "G#5";
                    semitone = true;
                    color_count = 4;
                    dot_count = 5;
                    break;

                case 61:
                    freq = 880.000f;
                    sound_name = "A5";
                    semitone = false;
                    color_count = 5;
                    dot_count = 5;
                    break;

                case 62:
                    freq = 932.328f;
                    sound_name = "A#5";
                    semitone = true;
                    color_count = 5;
                    dot_count = 5;
                    break;

                case 63:
                    freq = 987.767f;
                    sound_name = "B5";
                    semitone = false;
                    color_count = 6;
                    dot_count = 5;
                    break;

                case 64:
                    freq = 1046.502f;
                    sound_name = "C6";
                    semitone = false;
                    color_count = 0;
                    dot_count = 6;
                    break;

                case 65:
                    freq = 1108.731f;
                    sound_name = "C#6";
                    semitone = true;
                    color_count = 0;
                    dot_count = 6;
                    break;

                case 66:
                    freq = 1174.659f;
                    sound_name = "D6";
                    semitone = false;
                    color_count = 1;
                    dot_count = 6;
                    break;

                case 67:
                    freq = 1244.508f;
                    sound_name = "D#6";
                    semitone = true;
                    color_count = 1;
                    dot_count = 6;
                    break;

                case 68:
                    freq = 1318.510f;
                    sound_name = "E6";
                    semitone = false;
                    color_count = 2;
                    dot_count = 6;
                    break;

                case 69:
                    freq = 1396.913f;
                    sound_name = "F6";
                    semitone = false;
                    color_count = 3;
                    dot_count = 6;
                    break;

                case 70:
                    freq = 1479.978f;
                    sound_name = "F#6";
                    semitone = true;
                    color_count = 3;
                    dot_count = 6;
                    break;

                case 71:
                    freq = 1567.982f;
                    sound_name = "G6";
                    semitone = false;
                    color_count = 4;
                    dot_count = 6;
                    break;

                case 72:
                    freq = 1661.219f;
                    sound_name = "G#6";
                    semitone = true;
                    color_count = 4;
                    dot_count = 6;
                    break;

                case 73:
                    freq = 1760.000f;
                    sound_name = "A6";
                    semitone = false;
                    color_count = 5;
                    dot_count = 6;
                    break;

                case 74:
                    freq = 1864.655f;
                    sound_name = "A#6";
                    semitone = true;
                    color_count = 5;
                    dot_count = 6;
                    break;

                case 75:
                    freq = 1975.533f;
                    sound_name = "B6";
                    semitone = false;
                    color_count = 6;
                    dot_count = 6;
                    break;

                case 76:
                    freq = 2093.005f;
                    sound_name = "C7";
                    semitone = false;
                    color_count = 0;
                    dot_count = 7;
                    break;

                case 77:
                    freq = 2217.461f;
                    sound_name = "C#7";
                    semitone = true;
                    color_count = 0;
                    dot_count = 7;
                    break;

                case 78:
                    freq = 2349.318f;
                    sound_name = "D7";
                    semitone = false;
                    color_count = 1;
                    dot_count = 7;
                    break;

                case 79:
                    freq = 2489.016f;
                    sound_name = "D#7";
                    semitone = true;
                    color_count = 1;
                    dot_count = 7;
                    break;

                case 80:
                    freq = 2637.020f;
                    sound_name = "E7";
                    semitone = false;
                    color_count = 2;
                    dot_count = 7;
                    break;

                case 81:
                    freq = 2793.826f;
                    sound_name = "F7";
                    semitone = false;
                    color_count = 3;
                    dot_count = 7;
                    break;

                case 82:
                    freq = 2959.955f;
                    sound_name = "F#7";
                    semitone = true;
                    color_count = 3;
                    dot_count = 7;
                    break;

                case 83:
                    freq = 3135.963f;
                    sound_name = "G7";
                    semitone = false;
                    color_count = 4;
                    dot_count = 7;
                    break;

                case 84:
                    freq = 3322.438f;
                    sound_name = "G#7";
                    semitone = true;
                    color_count = 4;
                    dot_count = 7;
                    break;

                case 85:
                    freq = 3520.000f;
                    sound_name = "A7";
                    semitone = false;
                    color_count = 5;
                    dot_count = 7;
                    break;

                case 86:
                    freq = 3729.310f;
                    sound_name = "A#7";
                    semitone = true;
                    color_count = 5;
                    dot_count = 7;
                    break;

                case 87:
                    freq = 3951.066f;
                    sound_name = "B7";
                    semitone = false;
                    color_count = 6;
                    dot_count = 7;
                    break;

                case 88:
                    freq = 4186.009f;
                    sound_name = "C8";
                    semitone = false;
                    color_count = 0;
                    dot_count = 8;
                    break;

            }


        }

    }
}
