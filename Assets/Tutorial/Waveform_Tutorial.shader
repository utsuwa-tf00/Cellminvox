Shader "Unlit/Waveform_Tutorial"
{
    Properties
    {
        _posX("Posx", Float) = 0.0
        _posY("Posy", Float) = 0.0
        _MainTex ("Texture", 2D) = "white" {}
        _Col("Col", Float) = 0.9
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
            float _Col;
            
            float4 frag(v2f_img i) : SV_Target
            {
                //float posx = _posX;
                float y = (i.uv.y - _posY)*50;
                float x= -sin(y)/y/5 + _posX;
                //x = x+0.5;
                if(i.uv.x < x || i.uv.x < _posX - 0.2f)
                {
                    return fixed4(0,0,0,0);
                }
                else
                {
                    return fixed4(_Col,_Col,_Col,1);
                }
            }

            ENDCG
        }
    }
}