// Shader created with Shader Forge v1.38 
// Shader Forge (c) Neat Corporation / Joachim Holmer - http://www.acegikmo.com/shaderforge/
// Note: Manually altering this data may prevent you from opening it in Shader Forge
/*SF_DATA;ver:1.38;sub:START;pass:START;ps:flbk:,iptp:0,cusa:False,bamd:0,cgin:,lico:1,lgpr:1,limd:0,spmd:1,trmd:0,grmd:0,uamb:True,mssp:True,bkdf:False,hqlp:False,rprd:False,enco:False,rmgx:True,imps:True,rpth:0,vtps:0,hqsc:True,nrmq:1,nrsp:0,vomd:0,spxs:False,tesm:0,olmd:1,culm:0,bsrc:0,bdst:0,dpts:2,wrdp:False,dith:0,atcv:False,rfrpo:True,rfrpn:Refraction,coma:15,ufog:False,aust:True,igpj:True,qofs:0,qpre:3,rntp:2,fgom:False,fgoc:False,fgod:False,fgor:False,fgmd:0,fgcr:0.5,fgcg:0.5,fgcb:0.5,fgca:1,fgde:0.01,fgrn:0,fgrf:300,stcl:False,atwp:False,stva:128,stmr:255,stmw:255,stcp:6,stps:0,stfa:0,stfz:0,ofsf:0,ofsu:0,f2p0:False,fnsp:False,fnfb:False,fsmp:False;n:type:ShaderForge.SFN_Final,id:3138,x:34010,y:32253,varname:node_3138,prsc:2|emission-8036-OUT;n:type:ShaderForge.SFN_Tex2dAsset,id:5809,x:30660,y:31825,ptovrint:False,ptlb:Caustic,ptin:_Caustic,varname:_node_5809,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,ntxv:0,isnm:False;n:type:ShaderForge.SFN_TexCoord,id:6145,x:30660,y:31996,varname:node_6145,prsc:2,uv:0,uaff:False;n:type:ShaderForge.SFN_Time,id:3952,x:30225,y:32200,varname:node_3952,prsc:2;n:type:ShaderForge.SFN_Sin,id:1620,x:30671,y:32168,varname:node_1620,prsc:2|IN-4219-OUT;n:type:ShaderForge.SFN_Multiply,id:4219,x:30476,y:32145,varname:node_4219,prsc:2|A-9322-OUT,B-3952-TSL;n:type:ShaderForge.SFN_Vector1,id:9322,x:30225,y:32100,cmnt:Speed,varname:node_9322,prsc:2,v1:20;n:type:ShaderForge.SFN_Tex2d,id:3691,x:30671,y:31622,ptovrint:False,ptlb:Noise,ptin:_Noise,varname:node_3691,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,ntxv:0,isnm:False;n:type:ShaderForge.SFN_Slider,id:612,x:32822,y:32705,ptovrint:False,ptlb:Thikness,ptin:_Thikness,varname:node_612,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0.8313457,max:1;n:type:ShaderForge.SFN_Slider,id:1085,x:33170,y:32688,ptovrint:False,ptlb:Opacity,ptin:_Opacity,varname:node_1085,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0.4013406,max:1;n:type:ShaderForge.SFN_Subtract,id:8418,x:33123,y:32408,varname:node_8418,prsc:2|A-4805-RGB,B-332-OUT;n:type:ShaderForge.SFN_Multiply,id:5873,x:33396,y:32442,varname:node_5873,prsc:2|A-8418-OUT,B-1085-OUT;n:type:ShaderForge.SFN_OneMinus,id:332,x:32958,y:32498,varname:node_332,prsc:2|IN-612-OUT;n:type:ShaderForge.SFN_Tex2d,id:4805,x:32154,y:32096,varname:node_4805,prsc:2,ntxv:0,isnm:False|UVIN-3942-OUT,TEX-5809-TEX;n:type:ShaderForge.SFN_Multiply,id:5086,x:31343,y:32218,varname:node_5086,prsc:2|A-3691-G,B-2676-OUT;n:type:ShaderForge.SFN_RemapRange,id:5944,x:31578,y:32345,varname:node_5944,prsc:2,frmn:0,frmx:1,tomn:0,tomx:-0.3|IN-5086-OUT;n:type:ShaderForge.SFN_Add,id:3942,x:31904,y:32452,varname:node_3942,prsc:2|A-5944-OUT,B-3208-OUT;n:type:ShaderForge.SFN_Multiply,id:3208,x:31640,y:32548,varname:node_3208,prsc:2|A-6145-UVOUT,B-6305-OUT;n:type:ShaderForge.SFN_Vector1,id:6305,x:31391,y:32627,varname:node_6305,prsc:2,v1:0.5;n:type:ShaderForge.SFN_Multiply,id:8036,x:33816,y:32484,varname:node_8036,prsc:2|A-5873-OUT,B-187-A;n:type:ShaderForge.SFN_VertexColor,id:187,x:33617,y:32642,varname:node_187,prsc:2;n:type:ShaderForge.SFN_Divide,id:2676,x:30894,y:32194,varname:node_2676,prsc:2|A-1620-OUT,B-8568-OUT;n:type:ShaderForge.SFN_Vector1,id:8568,x:30595,y:32390,varname:node_8568,prsc:2,v1:4;proporder:5809-3691-612-1085;pass:END;sub:END;*/

Shader "Shader Forge/waterCaustics_01" {
    Properties {
        _Caustic ("Caustic", 2D) = "white" {}
        _Noise ("Noise", 2D) = "white" {}
        _Thikness ("Thikness", Range(0, 1)) = 0.8313457
        _Opacity ("Opacity", Range(0, 1)) = 0.4013406
    }
    SubShader {
        Tags {
            "IgnoreProjector"="True"
            "Queue"="Transparent"
            "RenderType"="Transparent"
        }
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
            #pragma only_renderers d3d9 d3d11 glcore gles n3ds wiiu 
            #pragma target 3.0
            uniform sampler2D _Caustic; uniform float4 _Caustic_ST;
            uniform sampler2D _Noise; uniform float4 _Noise_ST;
            uniform float _Thikness;
            uniform float _Opacity;
            struct VertexInput {
                float4 vertex : POSITION;
                float2 texcoord0 : TEXCOORD0;
                float4 vertexColor : COLOR;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float2 uv0 : TEXCOORD0;
                float4 vertexColor : COLOR;
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                o.vertexColor = v.vertexColor;
                o.pos = UnityObjectToClipPos( v.vertex );
                return o;
            }
            float4 frag(VertexOutput i) : COLOR {
////// Lighting:
////// Emissive:
                float4 _Noise_var = tex2D(_Noise,TRANSFORM_TEX(i.uv0, _Noise));
                float4 node_3952 = _Time;
                float2 node_3942 = (((_Noise_var.g*(sin((20.0*node_3952.r))/4.0))*-0.3+0.0)+(i.uv0*0.5));
                float4 node_4805 = tex2D(_Caustic,TRANSFORM_TEX(node_3942, _Caustic));
                float3 emissive = (((node_4805.rgb-(1.0 - _Thikness))*_Opacity)*i.vertexColor.a);
                float3 finalColor = emissive;
                return fixed4(finalColor,1);
            }
            ENDCG
        }
    }
    FallBack "Diffuse"
    CustomEditor "ShaderForgeMaterialInspector"
}
