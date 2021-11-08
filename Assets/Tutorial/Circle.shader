Shader "Unlit/Circle"
{
    Properties
    {
        _Radius("Radius", Float) = 0
        _Weight("Weight",Float)=0.1
        _Col("Col",Float) = 0.5
        _MainTex ("Texture", 2D) = "white" {}
    }


    SubShader
    {
        Pass
        {
            Tags { "RenderType" = "Transparent" "Queue"="Transparent" }
            Blend SrcAlpha OneMinusSrcAlpha

            CGPROGRAM
            
            #pragma vertex vert_img
            #pragma fragment frag
            #include "UnityCG.cginc"

            float _Radius;
            float _Weight;
            float _Col;

            float4 frag(v2f_img i) : SV_Target
            {
                float d = distance(float2(0.5,0.5),i.uv);
                //float a = abs(sin(_Time.y*3))*0.5;
                
                if(_Radius-_Weight < d && d < _Radius)
                {
                    return fixed4(_Col,_Col,_Col,1);
                }
                else
                {
                    return fixed4(0,0,0,0);
                }
            }
            
            ENDCG
        }
    }
}