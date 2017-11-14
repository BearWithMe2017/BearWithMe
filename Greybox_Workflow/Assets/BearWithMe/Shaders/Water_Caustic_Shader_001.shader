// Shader created with Shader Forge v1.38 
// Shader Forge (c) Neat Corporation / Joachim Holmer - http://www.acegikmo.com/shaderforge/
// Note: Manually altering this data may prevent you from opening it in Shader Forge
/*SF_DATA;ver:1.38;sub:START;pass:START;ps:flbk:,iptp:0,cusa:False,bamd:0,cgin:,lico:1,lgpr:1,limd:1,spmd:1,trmd:0,grmd:0,uamb:True,mssp:True,bkdf:False,hqlp:False,rprd:False,enco:False,rmgx:True,imps:True,rpth:0,vtps:0,hqsc:True,nrmq:1,nrsp:0,vomd:0,spxs:False,tesm:0,olmd:1,culm:0,bsrc:0,bdst:0,dpts:2,wrdp:False,dith:0,atcv:False,rfrpo:True,rfrpn:Refraction,coma:15,ufog:True,aust:True,igpj:True,qofs:0,qpre:3,rntp:2,fgom:False,fgoc:False,fgod:False,fgor:False,fgmd:0,fgcr:0.5,fgcg:0.5,fgcb:0.5,fgca:1,fgde:0.01,fgrn:0,fgrf:300,stcl:False,atwp:False,stva:128,stmr:255,stmw:255,stcp:6,stps:0,stfa:0,stfz:0,ofsf:0,ofsu:0,f2p0:False,fnsp:False,fnfb:False,fsmp:False;n:type:ShaderForge.SFN_Final,id:4906,x:35544,y:32731,varname:node_4906,prsc:2|emission-7418-OUT;n:type:ShaderForge.SFN_ValueProperty,id:3302,x:34036,y:33186,ptovrint:False,ptlb:Opacity,ptin:_Opacity,varname:node_3302,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0.8;n:type:ShaderForge.SFN_Tex2d,id:9734,x:34412,y:32858,ptovrint:False,ptlb:Texture noise,ptin:_Texturenoise,varname:node_9734,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:1f786a15e19d8fe44a7e72faa3e2cdb7,ntxv:0,isnm:False|UVIN-9706-UVOUT;n:type:ShaderForge.SFN_Slider,id:6381,x:34349,y:33263,ptovrint:False,ptlb:Thiccness,ptin:_Thiccness,varname:node_6381,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:-1,cur:1,max:1;n:type:ShaderForge.SFN_Multiply,id:7382,x:34349,y:33078,varname:node_7382,prsc:2|A-147-UVOUT,B-3302-OUT;n:type:ShaderForge.SFN_Panner,id:9706,x:34212,y:32866,varname:node_9706,prsc:2,spu:0.05,spv:0.005|UVIN-147-UVOUT;n:type:ShaderForge.SFN_TexCoord,id:147,x:34003,y:32866,varname:node_147,prsc:2,uv:0,uaff:False;n:type:ShaderForge.SFN_RemapRange,id:9487,x:34613,y:32858,varname:node_9487,prsc:2,frmn:0,frmx:1,tomn:0,tomx:0.1|IN-9734-G;n:type:ShaderForge.SFN_OneMinus,id:5857,x:34806,y:33047,varname:node_5857,prsc:2|IN-6381-OUT;n:type:ShaderForge.SFN_Tex2dAsset,id:5150,x:34991,y:32654,ptovrint:False,ptlb:texture,ptin:_texture,varname:node_5150,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:58e6a95c93824d24f861b236cf5e5e6f,ntxv:0,isnm:False;n:type:ShaderForge.SFN_Tex2d,id:2910,x:35011,y:32858,varname:node_2910,prsc:2,tex:58e6a95c93824d24f861b236cf5e5e6f,ntxv:0,isnm:False|UVIN-742-OUT,TEX-5150-TEX;n:type:ShaderForge.SFN_Subtract,id:9945,x:35246,y:32824,varname:node_9945,prsc:2|A-2910-RGB,B-5857-OUT;n:type:ShaderForge.SFN_Multiply,id:1604,x:35200,y:33021,varname:node_1604,prsc:2|A-9945-OUT,B-5402-OUT;n:type:ShaderForge.SFN_Slider,id:5402,x:34476,y:33384,ptovrint:False,ptlb:opacity,ptin:_opacity,varname:node_5402,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:1,max:1;n:type:ShaderForge.SFN_Multiply,id:7418,x:35300,y:33218,varname:node_7418,prsc:2|A-1604-OUT,B-8731-A;n:type:ShaderForge.SFN_VertexColor,id:8731,x:34952,y:33372,varname:node_8731,prsc:2;n:type:ShaderForge.SFN_Add,id:742,x:34820,y:32858,varname:node_742,prsc:2|A-9487-OUT,B-7382-OUT;proporder:3302-9734-6381-5402-5150;pass:END;sub:END;*/

Shader "Custom/hi" {
    Properties {
        _Opacity ("Opacity", Float ) = 0.8
        _Texturenoise ("Texture noise", 2D) = "white" {}
        _Thiccness ("Thiccness", Range(-1, 1)) = 1
        _opacity ("opacity", Range(0, 1)) = 1
        _texture ("texture", 2D) = "white" {}
    }
    SubShader {
        Tags {
            "IgnoreProjector"="True"
            "Queue"="Transparent"
            "RenderType"="Transparent"
        }
        LOD 200
        Pass {
            Name "FORWARD"
            Tags {
                "LightMode"="ForwardBase"
            }
            Blend One One
            ZWrite Off
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #define UNITY_PASS_FORWARDBASE
            #include "UnityCG.cginc"
            #pragma multi_compile_fwdbase
            #pragma multi_compile_fog
            #pragma only_renderers d3d9 d3d11 glcore gles 
            #pragma target 3.0
            uniform float _Opacity;
            uniform sampler2D _Texturenoise; uniform float4 _Texturenoise_ST;
            uniform float _Thiccness;
            uniform sampler2D _texture; uniform float4 _texture_ST;
            uniform float _opacity;
            struct VertexInput {
                float4 vertex : POSITION;
                float2 texcoord0 : TEXCOORD0;
                float4 vertexColor : COLOR;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float2 uv0 : TEXCOORD0;
                float4 vertexColor : COLOR;
                UNITY_FOG_COORDS(1)
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                o.vertexColor = v.vertexColor;
                o.pos = UnityObjectToClipPos( v.vertex );
                UNITY_TRANSFER_FOG(o,o.pos);
                return o;
            }
            float4 frag(VertexOutput i) : COLOR {
////// Lighting:
////// Emissive:
                float4 node_7027 = _Time;
                float2 node_9706 = (i.uv0+node_7027.g*float2(0.05,0.005));
                float4 _Texturenoise_var = tex2D(_Texturenoise,TRANSFORM_TEX(node_9706, _Texturenoise));
                float2 node_742 = ((_Texturenoise_var.g*0.1+0.0)+(i.uv0*_Opacity));
                float4 node_2910 = tex2D(_texture,TRANSFORM_TEX(node_742, _texture));
                float3 emissive = (((node_2910.rgb-(1.0 - _Thiccness))*_opacity)*i.vertexColor.a);
                float3 finalColor = emissive;
                fixed4 finalRGBA = fixed4(finalColor,1);
                UNITY_APPLY_FOG(i.fogCoord, finalRGBA);
                return finalRGBA;
            }
            ENDCG
        }
    }
    FallBack "Diffuse"
    CustomEditor "ShaderForgeMaterialInspector"
}
