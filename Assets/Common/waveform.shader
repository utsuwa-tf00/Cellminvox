Shader "Unlit/waveform"
{
    Properties
    {
        _posX("Posx", Float) = 0.0
        _posY("Posy", Float) = 0.0
        _MainTex ("Texture", 2D) = "white" {}
        _Color1("Color1",Color)= (0.9,0.9,0.9,0)
        _Color0("Color0",Color)= (0,0,0,1)
    }
    SubShader
    {
        Tags { "RenderType" = "Transparent" "Queue"="Transparent" }
        Blend SrcAlpha OneMinusSrcAlpha

        Pass
        {
            CGPROGRAM
            #pragma vertex vert_img
            #pragma fragment frag

            #include "UnityCG.cginc"

            float _posX;
            float _posY;
            float4 _Color1;
            float4 _Color0;
            
            float4 frag(v2f_img i) : SV_Target
            {
                //float posx = _posX;
                float y = (i.uv.y - _posY)*50;
                float x= -sin(y)/y/5 + _posX;
                //x = x+0.5;
                if(i.uv.x < x || i.uv.x < _posX - 0.2f)
                {
                    return _Color1;
                }
                else
                {
                    return _Color0;
                }
            }

            ENDCG
        }
    }
}
