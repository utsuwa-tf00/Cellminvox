Shader "Unlit/Panel"
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
                UNITY_FOG_COORDS(1)
                float4 vertex : SV_POSITION;
            };

            sampler2D _MainTex;
            float4 _MainTex_ST;

            v2f vert (appdata v)
            {
                v2f o;
                o.vertex = UnityObjectToClipPos(v.vertex);
                o.uv = TRANSFORM_TEX(v.uv, _MainTex);
                UNITY_TRANSFER_FOG(o,o.vertex);
                return o;
            }

            fixed4 frag (v2f i) : SV_Target
            {
                _Color.r = _R;
                _Color.g = _G;
                _Color.b = _B;

                return _Color;
            }
            ENDCG
        }
    }
}
