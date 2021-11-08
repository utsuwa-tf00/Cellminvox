Shader "ShaderSketches/test"
{
    Properties
    {
        _Radius("Radius", Float) = 0
        _Weight("Weight",Float)=0.1
        _Color1("Color",Color)= (0,0,0,1)
        _MainTex ("Texture", 2D) = "white" {}
        _Alpha("Alpha",Range(0.0, 1.0)) = 0
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
            fixed4 _Color1;
            float _Alpha;

            float4 frag(v2f_img i) : SV_Target
            {
                float d = distance(float2(0.5,0.5),i.uv);
                //float a = abs(sin(_Time.y*3))*0.5;
                
                if(_Radius-_Weight < d && d < _Radius)
                {
                    return _Color1;
                }
                else
                {
                    return fixed4(1,1,1,_Alpha);
                }
            }
            
            ENDCG
        }
    }
}
