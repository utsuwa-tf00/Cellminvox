Shader "Unlit/back"
{
    Properties
    {
        _SquareNum ("SquareNum", int) = 10
        _Brightness ("Brightness", Range(0.0, 1.0)) = 0.5
        _Volume("Volume",Range(0.0, 1.0))= 0.0
        _MoveSpeed("MoveSpeed",float)= 10
        _PlayState("PlayState",Int)= 0
        _R("R", Range(0.0, 1.0)) = 0.0
        _G("G", Range(0.0, 1.0)) = 0.0
        _B("B", Range(0.0, 1.0)) = 0.0
        _Light("Light", float) = 0.0
        _Color("Color", Color) = (1,1,1,1)

        _Range("Range", Range(0.0, 5.0)) = 0.0
    }
    SubShader
    {
        Tags { "RenderType"="Opaque" }
        LOD 100

        Pass
        {
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag

            #include "UnityCG.cginc"

            int _SquareNum;
            float _Brightness;
            float _Volume;
            float _MoveSpeed;
            int _PlayState;
            float4 _Color;
            float _R;
            float _G;
            float _B;
            float _Light;
            float _Range;

            struct appdata
            {
                float4 vertex : POSITION;
                float2 uv : TEXCOORD0;
            };

            struct v2f
            {
                float2 uv : TEXCOORD0;
                float4 vertex : SV_POSITION;
            };

            float2 random2(float2 st)
            {
                st = float2(dot(st, float2(127.1, 311.7)),
                            dot(st, float2(269.5, 183.3)));
                return -1.0 + 2.0 * frac(sin(st) * 43758.5453123);
            }

            v2f vert (appdata v)
            {
                v2f o;
                o.vertex = UnityObjectToClipPos(v.vertex);
                o.uv = v.uv;
                return o;
            }

            fixed4 frag (v2f i) : SV_Target
            {
                _Color.r = _R;
                _Color.g = _G;
                _Color.b = _B;

                float2 st = i.uv;
                st *= _SquareNum; //格子状の１辺のマス目数

                float2 ist = floor(st);//整数
                float2 fst = frac(st);//小数点以下

                float d = 5;
                float2 p_Min;
                
                if(_PlayState == 0){
                    //セルラーノイズ
                    //自身含む周囲のマスを探索
                    for (int y = -1; y <= 1; y++)
                    for (int x = -1; x <= 1; x++)
                    {
                        //マスの起点(0,0)
                        float2 neighbor = float2(x, y);

                        //マスの起点を基準にした白点のxy座標
                        float2 p = 0.5 + (0.5 * sin(_Time.y  + (6.2831 * random2(ist + neighbor))*(_MoveSpeed*_Volume))*_Volume);

                        //白点と処理対象のピクセルとの距離ベクトル
                        float2 diff = neighbor + p - fst;
                        float dist = length(diff);

                        //白点との距離が短くなれば更新
                        d = min(d, dist);
                    }

                    d = d*(25*_Volume);
                    d = abs(sin(d - _Time.y * 10));

                    if(d > 0.7)
                    {
                        return _Color;
                    }
                    else
                    {
                        return _Light;
                    }

                    //白点から最も短い距離を色に反映
                    //return (_Volume-d * _Volume)/2 + _Color;
                    //return _Volume-d * _Volume + _Color;
                }
                else if(_PlayState == 1)
                {
                    //ボロノイ図
                    for (int y = -1; y <= 1; y++)
                    for (int x = -1; x <= 1; x++)
                    {
                        float2 neighbor = float2(x, y);

                        float2 p = 0.5 + (0.5 * sin(_Time.y  + (6.2831 * random2(ist + neighbor))*(_MoveSpeed*_Volume))*_Volume);

                        float2 diff = neighbor + p - fst;
                        float dist = length(diff);

                        if(d > dist){
                            d = dist;
                            p_Min = p;
                        }

                    }
                    p_Min = (p_Min -0.5)*2;

                    return fixed4(_Color.x+p_Min.x,_Color.y+p_Min.x,_Color.z+p_Min.x,1);
                    //return fixed4(p_Min.x,p_Min.x,p_Min.x,1);
                }
                else if(_PlayState == 2){
                    //メタボール
                    for (int y = -1; y <= 1; y++)
                    for (int x = -1; x <= 1; x++)
                    {
                        float2 neighbor = float2(x, y);

                        float2 p = 0.5 + (0.5 * sin(_Time.y  + (6.2831 * random2(ist + neighbor))*(_MoveSpeed*_Volume))*_Volume);

                        float2 diff = neighbor + p - fst;
                        float dist = length(diff);

                        d = min(d, d*dist);
                    }
                    
                    if(d < 0.7)
                    {
                        //return _Volume/1.5 + _Color;
                        return _Volume + _Color;
                    }
                    else if(d >= 0.7 && d < 0.9)
                    {
                        //return _Volume/3 + _Color;
                        return _Volume/2 + _Color;
                    }
                    else
                    {
                        //return _Color;
                        return _Color;
                    }
                }
                else
                {
                    //自身含む周囲のマスを探索
                    for (int y = -1; y <= 1; y++)
                    for (int x = -1; x <= 1; x++)
                    {
                        //マスの起点(0,0)
                        float2 neighbor = float2(x, y);

                        //マスの起点を基準にした白点のxy座標
                        float2 p = 0.5 + (0.5 * sin(_Time.y  + (6.2831 * random2(ist + neighbor))*(_MoveSpeed*_Volume))*_Volume);

                        //白点と処理対象のピクセルとの距離ベクトル
                        float2 diff = neighbor + p - fst;
                        float dist = length(diff);

                        //白点との距離が短くなれば更新
                        d = min(d, dist);
                    }

                    //白点から最も短い距離を色に反映
                    if(d < 1-_Volume/2 && d >= _Volume/5){
                        return _Color;
                    }
                    else
                    {
                        //return _Color;
                        return 0.9;
                    }
                    //return (_Volume-d * _Volume)/2 + _Color;
                }
                
                
            }
            ENDCG
        }
    }
}
