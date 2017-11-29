// Shader created with Shader Forge v1.38 
// Shader Forge (c) Neat Corporation / Joachim Holmer - http://www.acegikmo.com/shaderforge/
// Note: Manually altering this data may prevent you from opening it in Shader Forge
/*SF_DATA;ver:1.38;sub:START;pass:START;ps:flbk:,iptp:0,cusa:False,bamd:0,cgin:,lico:1,lgpr:1,limd:0,spmd:1,trmd:0,grmd:0,uamb:True,mssp:True,bkdf:False,hqlp:False,rprd:False,enco:False,rmgx:True,imps:True,rpth:0,vtps:0,hqsc:True,nrmq:1,nrsp:0,vomd:0,spxs:False,tesm:0,olmd:1,culm:0,bsrc:0,bdst:1,dpts:2,wrdp:True,dith:0,atcv:False,rfrpo:True,rfrpn:Refraction,coma:15,ufog:True,aust:True,igpj:False,qofs:0,qpre:1,rntp:1,fgom:False,fgoc:False,fgod:False,fgor:False,fgmd:0,fgcr:0.5,fgcg:0.5,fgcb:0.5,fgca:1,fgde:0.01,fgrn:0,fgrf:300,stcl:False,atwp:False,stva:128,stmr:255,stmw:255,stcp:6,stps:0,stfa:0,stfz:0,ofsf:0,ofsu:0,f2p0:False,fnsp:False,fnfb:False,fsmp:False;n:type:ShaderForge.SFN_Final,id:7526,x:36636,y:32729,varname:node_7526,prsc:2|emission-4353-OUT,custl-4697-OUT,olwid-152-OUT,olcol-391-RGB;n:type:ShaderForge.SFN_Color,id:910,x:33933,y:31927,ptovrint:False,ptlb:Object Tint,ptin:_ObjectTint,varname:node_910,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0.5,c2:0.5,c3:0.5,c4:1;n:type:ShaderForge.SFN_Multiply,id:7007,x:34261,y:31754,varname:node_7007,prsc:2|A-4529-OUT,B-910-RGB;n:type:ShaderForge.SFN_Multiply,id:4353,x:34506,y:31623,varname:node_4353,prsc:2|A-7007-OUT,B-8322-RGB;n:type:ShaderForge.SFN_AmbientLight,id:8322,x:34326,y:31921,varname:node_8322,prsc:2;n:type:ShaderForge.SFN_Multiply,id:1955,x:31268,y:33005,varname:node_1955,prsc:2|A-398-OUT,B-8630-OUT,C-156-OUT;n:type:ShaderForge.SFN_Posterize,id:4651,x:32660,y:33327,varname:node_4651,prsc:2|IN-8198-OUT,STPS-1987-OUT;n:type:ShaderForge.SFN_LightVector,id:7404,x:30632,y:32876,varname:node_7404,prsc:2;n:type:ShaderForge.SFN_NormalVector,id:796,x:30647,y:33103,prsc:2,pt:True;n:type:ShaderForge.SFN_Dot,id:398,x:30890,y:32993,varname:node_398,prsc:2,dt:1|A-7404-OUT,B-796-OUT;n:type:ShaderForge.SFN_LightColor,id:5177,x:30682,y:33305,varname:node_5177,prsc:2;n:type:ShaderForge.SFN_Desaturate,id:8630,x:30977,y:33213,varname:node_8630,prsc:2|COL-5177-RGB,DES-5809-OUT;n:type:ShaderForge.SFN_LightAttenuation,id:156,x:31040,y:33424,varname:node_156,prsc:2;n:type:ShaderForge.SFN_ValueProperty,id:1987,x:32321,y:33341,ptovrint:False,ptlb:Steps,ptin:_Steps,varname:_Saturation_copy,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:4;n:type:ShaderForge.SFN_Multiply,id:9773,x:32799,y:33089,varname:node_9773,prsc:2|A-5197-OUT,B-1863-RGB;n:type:ShaderForge.SFN_LightColor,id:1863,x:31229,y:32490,varname:node_1863,prsc:2;n:type:ShaderForge.SFN_Tex2d,id:8645,x:31194,y:32233,ptovrint:False,ptlb:ColourMap,ptin:_ColourMap,varname:node_8645,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,ntxv:0,isnm:False;n:type:ShaderForge.SFN_Color,id:8679,x:31310,y:32011,ptovrint:False,ptlb:ObjectColour,ptin:_ObjectColour,varname:node_8679,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:1,c2:1,c3:1,c4:1;n:type:ShaderForge.SFN_Multiply,id:4336,x:31514,y:32235,varname:node_4336,prsc:2|A-8679-RGB,B-8645-RGB;n:type:ShaderForge.SFN_Multiply,id:6153,x:33349,y:34142,varname:node_6153,prsc:2|A-4651-OUT,B-4651-OUT;n:type:ShaderForge.SFN_Multiply,id:5197,x:31703,y:32357,varname:node_5197,prsc:2|A-4336-OUT,B-1863-RGB;n:type:ShaderForge.SFN_Multiply,id:7248,x:33531,y:34142,varname:node_7248,prsc:2|A-6153-OUT,B-6153-OUT;n:type:ShaderForge.SFN_Subtract,id:2099,x:33920,y:34002,varname:node_2099,prsc:2|A-4651-OUT;n:type:ShaderForge.SFN_Blend,id:911,x:34122,y:33984,varname:node_911,prsc:2,blmd:6,clmp:True|SRC-9773-OUT,DST-2099-OUT;n:type:ShaderForge.SFN_Vector1,id:993,x:31443,y:33552,varname:node_993,prsc:2,v1:0.3;n:type:ShaderForge.SFN_Clamp,id:8198,x:32259,y:33520,varname:node_8198,prsc:2|IN-7966-OUT,MIN-8147-OUT,MAX-287-OUT;n:type:ShaderForge.SFN_Vector1,id:8147,x:32039,y:33957,varname:node_8147,prsc:2,v1:0;n:type:ShaderForge.SFN_Vector1,id:287,x:32039,y:34031,varname:node_287,prsc:2,v1:1;n:type:ShaderForge.SFN_Add,id:2167,x:31783,y:33391,varname:node_2167,prsc:2|A-1955-OUT,B-993-OUT;n:type:ShaderForge.SFN_Multiply,id:2195,x:31444,y:30911,varname:node_2195,prsc:2|A-7638-OUT,B-9873-OUT,C-9140-OUT;n:type:ShaderForge.SFN_LightVector,id:4624,x:30468,y:30569,varname:node_4624,prsc:2;n:type:ShaderForge.SFN_NormalVector,id:8565,x:30803,y:30889,prsc:2,pt:True;n:type:ShaderForge.SFN_Dot,id:7638,x:31046,y:30779,varname:node_7638,prsc:2,dt:1|A-8062-OUT,B-8565-OUT;n:type:ShaderForge.SFN_LightAttenuation,id:9140,x:31217,y:31331,varname:node_9140,prsc:2;n:type:ShaderForge.SFN_Subtract,id:4993,x:31660,y:30769,varname:node_4993,prsc:2|A-2195-OUT,B-4243-OUT;n:type:ShaderForge.SFN_Vector1,id:4243,x:31346,y:30725,varname:node_4243,prsc:2,v1:0.45;n:type:ShaderForge.SFN_Multiply,id:6291,x:33179,y:32984,varname:node_6291,prsc:2|A-9773-OUT,B-4651-OUT;n:type:ShaderForge.SFN_Step,id:3746,x:31721,y:31023,varname:node_3746,prsc:2|A-7522-OUT,B-4993-OUT;n:type:ShaderForge.SFN_ChannelBlend,id:4697,x:34228,y:32732,varname:node_4697,prsc:2,chbt:1|M-3746-OUT,R-4814-RGB,G-4814-RGB,B-4814-RGB,BTM-6291-OUT;n:type:ShaderForge.SFN_Color,id:4814,x:34204,y:32540,ptovrint:False,ptlb:Gloss Colour,ptin:_GlossColour,varname:node_4814,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:1,c2:1,c3:1,c4:1;n:type:ShaderForge.SFN_Slider,id:4502,x:30299,y:31029,ptovrint:False,ptlb:Gloss Level,ptin:_GlossLevel,varname:node_4502,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0.2406528,max:1;n:type:ShaderForge.SFN_OneMinus,id:7522,x:31627,y:31198,varname:node_7522,prsc:2|IN-4502-OUT;n:type:ShaderForge.SFN_Color,id:391,x:38201,y:33517,ptovrint:False,ptlb:OutLineColur,ptin:_OutLineColur,varname:node_391,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:1,c2:0,c3:1,c4:1;n:type:ShaderForge.SFN_Slider,id:152,x:38078,y:33715,ptovrint:False,ptlb:OutLineWidth,ptin:_OutLineWidth,varname:node_152,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0,max:10;n:type:ShaderForge.SFN_Slider,id:8493,x:31079,y:33789,ptovrint:False,ptlb:Fake SSS,ptin:_FakeSSS,varname:node_8493,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0,max:5;n:type:ShaderForge.SFN_Add,id:8027,x:31990,y:33504,varname:node_8027,prsc:2|A-2167-OUT,B-8493-OUT;n:type:ShaderForge.SFN_Divide,id:7966,x:32039,y:33680,varname:node_7966,prsc:2|A-8027-OUT,B-4167-OUT;n:type:ShaderForge.SFN_Add,id:4167,x:31848,y:33861,varname:node_4167,prsc:2|A-4999-OUT,B-3079-OUT;n:type:ShaderForge.SFN_Vector1,id:3079,x:31699,y:33954,varname:node_3079,prsc:2,v1:1;n:type:ShaderForge.SFN_Multiply,id:4999,x:31527,y:33944,varname:node_4999,prsc:2|A-8493-OUT,B-1942-OUT;n:type:ShaderForge.SFN_Vector1,id:1942,x:31303,y:34054,varname:node_1942,prsc:2,v1:1.2;n:type:ShaderForge.SFN_Add,id:8062,x:30751,y:30529,varname:node_8062,prsc:2|A-4624-OUT,B-2625-OUT;n:type:ShaderForge.SFN_Fresnel,id:222,x:30826,y:30262,varname:node_222,prsc:2;n:type:ShaderForge.SFN_Multiply,id:2625,x:31160,y:30258,varname:node_2625,prsc:2|A-222-OUT,B-7808-OUT;n:type:ShaderForge.SFN_Divide,id:7808,x:31068,y:30475,varname:node_7808,prsc:2|A-4502-OUT,B-962-OUT;n:type:ShaderForge.SFN_Vector1,id:962,x:31111,y:30673,varname:node_962,prsc:2,v1:2;n:type:ShaderForge.SFN_Vector1,id:5809,x:30777,y:33484,varname:node_5809,prsc:2,v1:1;n:type:ShaderForge.SFN_Vector3,id:4529,x:34052,y:31653,varname:node_4529,prsc:2,v1:1,v2:1,v3:1;n:type:ShaderForge.SFN_Vector3,id:9873,x:31174,y:30945,varname:node_9873,prsc:2,v1:1,v2:0,v3:0;proporder:8645-8679-910-1987-4814-4502-152-391-8493;pass:END;sub:END;*/

Shader "Custom/CelShader" {
    Properties {
        _ColourMap ("ColourMap", 2D) = "white" {}
        _ObjectColour ("ObjectColour", Color) = (1,1,1,1)
        _ObjectTint ("Object Tint", Color) = (0.5,0.5,0.5,1)
        _Steps ("Steps", Float ) = 4
        _GlossColour ("Gloss Colour", Color) = (1,1,1,1)
        _GlossLevel ("Gloss Level", Range(0, 1)) = 0.2406528
        _OutLineWidth ("OutLineWidth", Range(0, 10)) = 0
        _OutLineColur ("OutLineColur", Color) = (1,0,1,1)
        _FakeSSS ("Fake SSS", Range(0, 5)) = 0
    }
    SubShader {
        Tags {
            "RenderType"="Opaque"
        }
        LOD 200
        Pass {
            Name "Outline"
            Tags {
            }
            Cull Front
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #include "UnityCG.cginc"
            #pragma fragmentoption ARB_precision_hint_fastest
            #pragma multi_compile_shadowcaster
            #pragma multi_compile_fog
            #pragma only_renderers d3d9 d3d11 glcore gles 
            #pragma target 3.0
            uniform float4 _OutLineColur;
            uniform float _OutLineWidth;
            struct VertexInput {
                float4 vertex : POSITION;
                float3 normal : NORMAL;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                UNITY_FOG_COORDS(0)
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.pos = UnityObjectToClipPos( float4(v.vertex.xyz + v.normal*_OutLineWidth,1) );
                UNITY_TRANSFER_FOG(o,o.pos);
                return o;
            }
            float4 frag(VertexOutput i) : COLOR {
                return fixed4(_OutLineColur.rgb,0);
            }
            ENDCG
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
            #include "UnityCG.cginc"
            #include "AutoLight.cginc"
            #include "Lighting.cginc"
            #pragma multi_compile_fwdbase_fullshadows
            #pragma multi_compile_fog
            #pragma only_renderers d3d9 d3d11 glcore gles 
            #pragma target 3.0
            uniform float4 _ObjectTint;
            uniform float _Steps;
            uniform sampler2D _ColourMap; uniform float4 _ColourMap_ST;
            uniform float4 _ObjectColour;
            uniform float4 _GlossColour;
            uniform float _GlossLevel;
            uniform float _FakeSSS;
            struct VertexInput {
                float4 vertex : POSITION;
                float3 normal : NORMAL;
                float2 texcoord0 : TEXCOORD0;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float2 uv0 : TEXCOORD0;
                float4 posWorld : TEXCOORD1;
                float3 normalDir : TEXCOORD2;
                LIGHTING_COORDS(3,4)
                UNITY_FOG_COORDS(5)
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                o.normalDir = UnityObjectToWorldNormal(v.normal);
                o.posWorld = mul(unity_ObjectToWorld, v.vertex);
                float3 lightColor = _LightColor0.rgb;
                o.pos = UnityObjectToClipPos( v.vertex );
                UNITY_TRANSFER_FOG(o,o.pos);
                TRANSFER_VERTEX_TO_FRAGMENT(o)
                return o;
            }
            float4 frag(VertexOutput i) : COLOR {
                i.normalDir = normalize(i.normalDir);
                float3 viewDirection = normalize(_WorldSpaceCameraPos.xyz - i.posWorld.xyz);
                float3 normalDirection = i.normalDir;
                float3 lightDirection = normalize(_WorldSpaceLightPos0.xyz);
                float3 lightColor = _LightColor0.rgb;
////// Lighting:
                float attenuation = LIGHT_ATTENUATION(i);
////// Emissive:
                float3 emissive = ((float3(1,1,1)*_ObjectTint.rgb)*UNITY_LIGHTMODEL_AMBIENT.rgb);
                float3 node_3746 = step((1.0 - _GlossLevel),((max(0,dot((lightDirection+((1.0-max(0,dot(normalDirection, viewDirection)))*(_GlossLevel/2.0))),normalDirection))*float3(1,0,0)*attenuation)-0.45));
                float4 _ColourMap_var = tex2D(_ColourMap,TRANSFORM_TEX(i.uv0, _ColourMap));
                float3 node_9773 = (((_ObjectColour.rgb*_ColourMap_var.rgb)*_LightColor0.rgb)*_LightColor0.rgb);
                float node_4651 = floor(clamp(((((max(0,dot(lightDirection,normalDirection))*lerp(_LightColor0.rgb,dot(_LightColor0.rgb,float3(0.3,0.59,0.11)),1.0)*attenuation)+0.3)+_FakeSSS)/((_FakeSSS*1.2)+1.0)),0.0,1.0) * _Steps) / (_Steps - 1);
                float3 finalColor = emissive + (lerp( lerp( lerp( (node_9773*node_4651), _GlossColour.rgb, node_3746.r ), _GlossColour.rgb, node_3746.g ), _GlossColour.rgb, node_3746.b ));
                fixed4 finalRGBA = fixed4(finalColor,1);
                UNITY_APPLY_FOG(i.fogCoord, finalRGBA);
                return finalRGBA;
            }
            ENDCG
        }
        Pass {
            Name "FORWARD_DELTA"
            Tags {
                "LightMode"="ForwardAdd"
            }
            Blend One One
            
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #define UNITY_PASS_FORWARDADD
            #include "UnityCG.cginc"
            #include "AutoLight.cginc"
            #include "Lighting.cginc"
            #pragma multi_compile_fwdadd_fullshadows
            #pragma multi_compile_fog
            #pragma only_renderers d3d9 d3d11 glcore gles 
            #pragma target 3.0
            uniform float4 _ObjectTint;
            uniform float _Steps;
            uniform sampler2D _ColourMap; uniform float4 _ColourMap_ST;
            uniform float4 _ObjectColour;
            uniform float4 _GlossColour;
            uniform float _GlossLevel;
            uniform float _FakeSSS;
            struct VertexInput {
                float4 vertex : POSITION;
                float3 normal : NORMAL;
                float2 texcoord0 : TEXCOORD0;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float2 uv0 : TEXCOORD0;
                float4 posWorld : TEXCOORD1;
                float3 normalDir : TEXCOORD2;
                LIGHTING_COORDS(3,4)
                UNITY_FOG_COORDS(5)
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                o.normalDir = UnityObjectToWorldNormal(v.normal);
                o.posWorld = mul(unity_ObjectToWorld, v.vertex);
                float3 lightColor = _LightColor0.rgb;
                o.pos = UnityObjectToClipPos( v.vertex );
                UNITY_TRANSFER_FOG(o,o.pos);
                TRANSFER_VERTEX_TO_FRAGMENT(o)
                return o;
            }
            float4 frag(VertexOutput i) : COLOR {
                i.normalDir = normalize(i.normalDir);
                float3 viewDirection = normalize(_WorldSpaceCameraPos.xyz - i.posWorld.xyz);
                float3 normalDirection = i.normalDir;
                float3 lightDirection = normalize(lerp(_WorldSpaceLightPos0.xyz, _WorldSpaceLightPos0.xyz - i.posWorld.xyz,_WorldSpaceLightPos0.w));
                float3 lightColor = _LightColor0.rgb;
////// Lighting:
                float attenuation = LIGHT_ATTENUATION(i);
                float3 node_3746 = step((1.0 - _GlossLevel),((max(0,dot((lightDirection+((1.0-max(0,dot(normalDirection, viewDirection)))*(_GlossLevel/2.0))),normalDirection))*float3(1,0,0)*attenuation)-0.45));
                float4 _ColourMap_var = tex2D(_ColourMap,TRANSFORM_TEX(i.uv0, _ColourMap));
                float3 node_9773 = (((_ObjectColour.rgb*_ColourMap_var.rgb)*_LightColor0.rgb)*_LightColor0.rgb);
                float node_4651 = floor(clamp(((((max(0,dot(lightDirection,normalDirection))*lerp(_LightColor0.rgb,dot(_LightColor0.rgb,float3(0.3,0.59,0.11)),1.0)*attenuation)+0.3)+_FakeSSS)/((_FakeSSS*1.2)+1.0)),0.0,1.0) * _Steps) / (_Steps - 1);
                float3 finalColor = (lerp( lerp( lerp( (node_9773*node_4651), _GlossColour.rgb, node_3746.r ), _GlossColour.rgb, node_3746.g ), _GlossColour.rgb, node_3746.b ));
                fixed4 finalRGBA = fixed4(finalColor * 1,0);
                UNITY_APPLY_FOG(i.fogCoord, finalRGBA);
                return finalRGBA;
            }
            ENDCG
        }
    }
    FallBack "Diffuse"
    CustomEditor "ShaderForgeMaterialInspector"
}
