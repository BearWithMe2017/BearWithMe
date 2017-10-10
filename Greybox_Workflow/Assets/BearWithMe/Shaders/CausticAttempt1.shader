// Shader created with Shader Forge v1.38 
// Shader Forge (c) Neat Corporation / Joachim Holmer - http://www.acegikmo.com/shaderforge/
// Note: Manually altering this data may prevent you from opening it in Shader Forge
/*SF_DATA;ver:1.38;sub:START;pass:START;ps:flbk:,iptp:0,cusa:False,bamd:0,cgin:,lico:1,lgpr:1,limd:3,spmd:1,trmd:0,grmd:0,uamb:True,mssp:True,bkdf:True,hqlp:False,rprd:True,enco:False,rmgx:True,imps:True,rpth:0,vtps:0,hqsc:True,nrmq:1,nrsp:0,vomd:0,spxs:False,tesm:0,olmd:1,culm:0,bsrc:0,bdst:1,dpts:2,wrdp:True,dith:0,atcv:False,rfrpo:True,rfrpn:Refraction,coma:15,ufog:True,aust:True,igpj:False,qofs:0,qpre:1,rntp:1,fgom:False,fgoc:False,fgod:False,fgor:False,fgmd:0,fgcr:0.5,fgcg:0.5,fgcb:0.5,fgca:1,fgde:0.01,fgrn:0,fgrf:300,stcl:False,atwp:False,stva:128,stmr:255,stmw:255,stcp:6,stps:0,stfa:0,stfz:0,ofsf:0,ofsu:0,f2p0:False,fnsp:False,fnfb:False,fsmp:False;n:type:ShaderForge.SFN_Final,id:2865,x:32848,y:32680,varname:node_2865,prsc:2|emission-8858-OUT;n:type:ShaderForge.SFN_TexCoord,id:6377,x:31588,y:32638,varname:node_6377,prsc:2,uv:0,uaff:False;n:type:ShaderForge.SFN_Multiply,id:3024,x:31797,y:32731,varname:node_3024,prsc:2|A-6377-UVOUT,B-4250-OUT;n:type:ShaderForge.SFN_Tex2d,id:4010,x:32039,y:32545,ptovrint:False,ptlb:node_4010,ptin:_node_4010,varname:node_4010,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:9d2605fe68cae0d49baf98938113a189,ntxv:0,isnm:False|UVIN-1588-UVOUT;n:type:ShaderForge.SFN_Add,id:1261,x:32372,y:32478,varname:node_1261,prsc:2|A-1511-OUT,B-3024-OUT;n:type:ShaderForge.SFN_Tex2d,id:4767,x:32568,y:32478,varname:node_4767,prsc:2,tex:20e61306ab6ec8e47a05d63f56321578,ntxv:0,isnm:False|UVIN-1261-OUT,TEX-3629-TEX;n:type:ShaderForge.SFN_Panner,id:1588,x:31797,y:32574,varname:node_1588,prsc:2,spu:0.05,spv:0.05|UVIN-6377-UVOUT;n:type:ShaderForge.SFN_RemapRange,id:1511,x:32197,y:32350,varname:node_1511,prsc:2,frmn:0,frmx:1,tomn:0,tomx:0.01|IN-4010-G;n:type:ShaderForge.SFN_Slider,id:4041,x:31950,y:32888,ptovrint:False,ptlb:Thickness,ptin:_Thickness,varname:node_4041,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0.9223601,max:1;n:type:ShaderForge.SFN_OneMinus,id:1430,x:32215,y:32683,varname:node_1430,prsc:2|IN-4041-OUT;n:type:ShaderForge.SFN_Multiply,id:9054,x:32597,y:32667,varname:node_9054,prsc:2|A-9551-OUT,B-7831-OUT;n:type:ShaderForge.SFN_Slider,id:7831,x:32268,y:32875,ptovrint:False,ptlb:Opacity,ptin:_Opacity,varname:node_7831,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0.794503,max:1;n:type:ShaderForge.SFN_Multiply,id:8858,x:32665,y:32872,varname:node_8858,prsc:2|A-9054-OUT,B-8475-A,C-9544-OUT;n:type:ShaderForge.SFN_VertexColor,id:8475,x:32401,y:32982,varname:node_8475,prsc:2;n:type:ShaderForge.SFN_Tex2dAsset,id:3629,x:32372,y:32298,ptovrint:False,ptlb:Caustic,ptin:_Caustic,varname:node_3629,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:20e61306ab6ec8e47a05d63f56321578,ntxv:3,isnm:False;n:type:ShaderForge.SFN_Subtract,id:9551,x:32789,y:32495,varname:node_9551,prsc:2|A-4767-RGB,B-1430-OUT;n:type:ShaderForge.SFN_Vector1,id:9544,x:32587,y:33022,varname:node_9544,prsc:2,v1:2;n:type:ShaderForge.SFN_Vector1,id:4250,x:31527,y:32881,varname:node_4250,prsc:2,v1:1;proporder:4010-4041-7831-3629;pass:END;sub:END;*/

Shader "Shader Forge/CausticAttempt1" {
    Properties {
        _node_4010 ("node_4010", 2D) = "white" {}
        _Thickness ("Thickness", Range(0, 1)) = 0.9223601
        _Opacity ("Opacity", Range(0, 1)) = 0.794503
        _Caustic ("Caustic", 2D) = "bump" {}
    }
    SubShader {
        Tags {
            "RenderType"="Opaque"
        }
        Pass {
            Name "FORWARD"
            Tags {
                "LightMode"="ForwardBase"
            }
            
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #define UNITY_PASS_FORWARDBASE
            #define _GLOSSYENV 1
            #include "UnityCG.cginc"
            #include "UnityPBSLighting.cginc"
            #include "UnityStandardBRDF.cginc"
            #pragma multi_compile_fwdbase_fullshadows
            #pragma multi_compile_fog
            #pragma only_renderers d3d9 d3d11 glcore gles 
            #pragma target 3.0
            uniform sampler2D _node_4010; uniform float4 _node_4010_ST;
            uniform float _Thickness;
            uniform float _Opacity;
            uniform sampler2D _Caustic; uniform float4 _Caustic_ST;
            struct VertexInput {
                float4 vertex : POSITION;
                float3 normal : NORMAL;
                float2 texcoord0 : TEXCOORD0;
                float4 vertexColor : COLOR;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float2 uv0 : TEXCOORD0;
                float4 posWorld : TEXCOORD1;
                float3 normalDir : TEXCOORD2;
                float4 vertexColor : COLOR;
                UNITY_FOG_COORDS(3)
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                o.vertexColor = v.vertexColor;
                o.normalDir = UnityObjectToWorldNormal(v.normal);
                o.posWorld = mul(unity_ObjectToWorld, v.vertex);
                o.pos = UnityObjectToClipPos( v.vertex );
                UNITY_TRANSFER_FOG(o,o.pos);
                return o;
            }
            float4 frag(VertexOutput i) : COLOR {
                i.normalDir = normalize(i.normalDir);
                float3 viewDirection = normalize(_WorldSpaceCameraPos.xyz - i.posWorld.xyz);
                float3 normalDirection = i.normalDir;
                float3 viewReflectDirection = reflect( -viewDirection, normalDirection );
////// Lighting:
////// Emissive:
                float4 node_1366 = _Time;
                float2 node_1588 = (i.uv0+node_1366.g*float2(0.05,0.05));
                float4 _node_4010_var = tex2D(_node_4010,TRANSFORM_TEX(node_1588, _node_4010));
                float2 node_1261 = ((_node_4010_var.g*0.01+0.0)+(i.uv0*1.0));
                float4 node_4767 = tex2D(_Caustic,TRANSFORM_TEX(node_1261, _Caustic));
                float node_1430 = (1.0 - _Thickness);
                float3 emissive = (((node_4767.rgb-node_1430)*_Opacity)*i.vertexColor.a*2.0);
                float3 finalColor = emissive;
                fixed4 finalRGBA = fixed4(finalColor,1);
                UNITY_APPLY_FOG(i.fogCoord, finalRGBA);
                return finalRGBA;
            }
            ENDCG
        }
        Pass {
            Name "Meta"
            Tags {
                "LightMode"="Meta"
            }
            Cull Off
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #define UNITY_PASS_META 1
            #define _GLOSSYENV 1
            #include "UnityCG.cginc"
            #include "UnityPBSLighting.cginc"
            #include "UnityStandardBRDF.cginc"
            #include "UnityMetaPass.cginc"
            #pragma fragmentoption ARB_precision_hint_fastest
            #pragma multi_compile_shadowcaster
            #pragma multi_compile_fog
            #pragma only_renderers d3d9 d3d11 glcore gles 
            #pragma target 3.0
            uniform sampler2D _node_4010; uniform float4 _node_4010_ST;
            uniform float _Thickness;
            uniform float _Opacity;
            uniform sampler2D _Caustic; uniform float4 _Caustic_ST;
            struct VertexInput {
                float4 vertex : POSITION;
                float2 texcoord0 : TEXCOORD0;
                float2 texcoord1 : TEXCOORD1;
                float2 texcoord2 : TEXCOORD2;
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
                o.pos = UnityMetaVertexPosition(v.vertex, v.texcoord1.xy, v.texcoord2.xy, unity_LightmapST, unity_DynamicLightmapST );
                return o;
            }
            float4 frag(VertexOutput i) : SV_Target {
                UnityMetaInput o;
                UNITY_INITIALIZE_OUTPUT( UnityMetaInput, o );
                
                float4 node_459 = _Time;
                float2 node_1588 = (i.uv0+node_459.g*float2(0.05,0.05));
                float4 _node_4010_var = tex2D(_node_4010,TRANSFORM_TEX(node_1588, _node_4010));
                float2 node_1261 = ((_node_4010_var.g*0.01+0.0)+(i.uv0*1.0));
                float4 node_4767 = tex2D(_Caustic,TRANSFORM_TEX(node_1261, _Caustic));
                float node_1430 = (1.0 - _Thickness);
                o.Emission = (((node_4767.rgb-node_1430)*_Opacity)*i.vertexColor.a*2.0);
                
                float3 diffColor = float3(0,0,0);
                float specularMonochrome;
                float3 specColor;
                diffColor = DiffuseAndSpecularFromMetallic( diffColor, 0, specColor, specularMonochrome );
                o.Albedo = diffColor;
                
                return UnityMetaFragment( o );
            }
            ENDCG
        }
    }
    FallBack "Diffuse"
    CustomEditor "ShaderForgeMaterialInspector"
}
