// Shader created with Shader Forge v1.38 
// Shader Forge (c) Neat Corporation / Joachim Holmer - http://www.acegikmo.com/shaderforge/
// Note: Manually altering this data may prevent you from opening it in Shader Forge
/*SF_DATA;ver:1.38;sub:START;pass:START;ps:flbk:,iptp:0,cusa:False,bamd:0,cgin:,lico:1,lgpr:1,limd:0,spmd:1,trmd:0,grmd:0,uamb:True,mssp:True,bkdf:False,hqlp:False,rprd:False,enco:False,rmgx:True,imps:True,rpth:0,vtps:0,hqsc:True,nrmq:1,nrsp:0,vomd:0,spxs:False,tesm:0,olmd:1,culm:0,bsrc:0,bdst:1,dpts:2,wrdp:True,dith:0,atcv:False,rfrpo:True,rfrpn:Refraction,coma:15,ufog:True,aust:True,igpj:False,qofs:0,qpre:1,rntp:1,fgom:False,fgoc:False,fgod:False,fgor:False,fgmd:0,fgcr:0.5,fgcg:0.5,fgcb:0.5,fgca:1,fgde:0.01,fgrn:0,fgrf:300,stcl:False,atwp:False,stva:128,stmr:255,stmw:255,stcp:6,stps:0,stfa:0,stfz:0,ofsf:0,ofsu:0,f2p0:False,fnsp:False,fnfb:False,fsmp:False;n:type:ShaderForge.SFN_Final,id:7526,x:36636,y:32729,varname:node_7526,prsc:2|emission-4353-OUT,custl-4697-OUT,olwid-152-OUT,olcol-391-RGB;n:type:ShaderForge.SFN_Tex2d,id:9278,x:33951,y:31696,ptovrint:False,ptlb:NA,ptin:_NA,varname:node_9278,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,ntxv:0,isnm:False;n:type:ShaderForge.SFN_Color,id:910,x:33933,y:31927,ptovrint:False,ptlb:Object Tint,ptin:_ObjectTint,varname:node_910,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0.5,c2:0.5,c3:0.5,c4:1;n:type:ShaderForge.SFN_Multiply,id:7007,x:34261,y:31754,varname:node_7007,prsc:2|A-9278-RGB,B-910-RGB;n:type:ShaderForge.SFN_Multiply,id:4353,x:34506,y:31623,varname:node_4353,prsc:2|A-7007-OUT,B-8322-RGB;n:type:ShaderForge.SFN_AmbientLight,id:8322,x:34292,y:31911,varname:node_8322,prsc:2;n:type:ShaderForge.SFN_Multiply,id:1955,x:31268,y:33005,varname:node_1955,prsc:2|A-398-OUT,B-8630-OUT,C-156-OUT;n:type:ShaderForge.SFN_Posterize,id:4651,x:32660,y:33327,varname:node_4651,prsc:2|IN-8198-OUT,STPS-1987-OUT;n:type:ShaderForge.SFN_LightVector,id:7404,x:30632,y:32876,varname:node_7404,prsc:2;n:type:ShaderForge.SFN_NormalVector,id:796,x:30647,y:33103,prsc:2,pt:True;n:type:ShaderForge.SFN_Dot,id:398,x:30890,y:32993,varname:node_398,prsc:2,dt:1|A-7404-OUT,B-796-OUT;n:type:ShaderForge.SFN_LightColor,id:5177,x:30682,y:33305,varname:node_5177,prsc:2;n:type:ShaderForge.SFN_Desaturate,id:8630,x:30977,y:33213,varname:node_8630,prsc:2|COL-5177-RGB,DES-9957-OUT;n:type:ShaderForge.SFN_LightAttenuation,id:156,x:31040,y:33424,varname:node_156,prsc:2;n:type:ShaderForge.SFN_ValueProperty,id:9957,x:30757,y:33538,ptovrint:False,ptlb:Saturation,ptin:_Saturation,varname:node_9957,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:1;n:type:ShaderForge.SFN_ValueProperty,id:1987,x:32321,y:33341,ptovrint:False,ptlb:Steps,ptin:_Steps,varname:_Saturation_copy,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:4;n:type:ShaderForge.SFN_Multiply,id:9773,x:32799,y:33089,varname:node_9773,prsc:2|A-5197-OUT,B-1863-RGB;n:type:ShaderForge.SFN_LightColor,id:1863,x:31100,y:32739,varname:node_1863,prsc:2;n:type:ShaderForge.SFN_Tex2d,id:8645,x:31065,y:32482,ptovrint:False,ptlb:node_8645,ptin:_node_8645,varname:node_8645,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,ntxv:0,isnm:False;n:type:ShaderForge.SFN_Blend,id:1836,x:36539,y:35875,varname:node_1836,prsc:2,blmd:10,clmp:True|SRC-7702-OUT,DST-1418-OUT;n:type:ShaderForge.SFN_Lerp,id:7702,x:36330,y:35757,varname:node_7702,prsc:2|A-5510-RGB,B-6891-OUT,T-7114-OUT;n:type:ShaderForge.SFN_Multiply,id:1418,x:36330,y:36031,varname:node_1418,prsc:2|A-4867-OUT,B-2240-OUT,C-3744-RGB;n:type:ShaderForge.SFN_Blend,id:2240,x:35976,y:36160,varname:node_2240,prsc:2,blmd:10,clmp:True|SRC-5510-RGB,DST-9411-OUT;n:type:ShaderForge.SFN_AmbientLight,id:3744,x:35976,y:36320,varname:node_3744,prsc:2;n:type:ShaderForge.SFN_LightAttenuation,id:4867,x:35430,y:36033,varname:node_4867,prsc:2;n:type:ShaderForge.SFN_Vector4,id:6891,x:36148,y:35788,varname:node_6891,prsc:2,v1:0.5,v2:0.5,v3:0.5,v4:1;n:type:ShaderForge.SFN_OneMinus,id:6842,x:35755,y:35868,varname:node_6842,prsc:2|IN-4867-OUT;n:type:ShaderForge.SFN_OneMinus,id:7114,x:36099,y:35868,varname:node_7114,prsc:2|IN-5740-OUT;n:type:ShaderForge.SFN_Multiply,id:5740,x:35919,y:35868,varname:node_5740,prsc:2|A-6842-OUT,B-5948-OUT;n:type:ShaderForge.SFN_ValueProperty,id:5948,x:35755,y:36007,ptovrint:False,ptlb:node_5948,ptin:_node_5948,varname:node_5948,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:10;n:type:ShaderForge.SFN_Color,id:5510,x:35391,y:35678,ptovrint:False,ptlb:ShadowColour,ptin:_ShadowColour,varname:node_5510,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0.2,c2:0.2,c3:0.2,c4:0.2;n:type:ShaderForge.SFN_Color,id:8679,x:31181,y:32260,ptovrint:False,ptlb:ObjectColour,ptin:_ObjectColour,varname:node_8679,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:1,c2:1,c3:1,c4:1;n:type:ShaderForge.SFN_Multiply,id:4336,x:31385,y:32484,varname:node_4336,prsc:2|A-8679-RGB,B-8645-RGB;n:type:ShaderForge.SFN_Multiply,id:9411,x:35448,y:35104,varname:node_9411,prsc:2|B-1713-OUT;n:type:ShaderForge.SFN_ValueProperty,id:1713,x:35375,y:35350,ptovrint:False,ptlb:node_1713,ptin:_node_1713,varname:node_1713,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:1;n:type:ShaderForge.SFN_Multiply,id:6153,x:33349,y:34142,varname:node_6153,prsc:2|A-4651-OUT,B-4651-OUT;n:type:ShaderForge.SFN_Multiply,id:5197,x:31574,y:32606,varname:node_5197,prsc:2|A-4336-OUT,B-1863-RGB;n:type:ShaderForge.SFN_Multiply,id:7248,x:33531,y:34142,varname:node_7248,prsc:2|A-6153-OUT,B-6153-OUT;n:type:ShaderForge.SFN_Subtract,id:2099,x:33920,y:34002,varname:node_2099,prsc:2|A-4651-OUT;n:type:ShaderForge.SFN_Blend,id:911,x:34122,y:33984,varname:node_911,prsc:2,blmd:6,clmp:True|SRC-9773-OUT,DST-2099-OUT;n:type:ShaderForge.SFN_Subtract,id:1078,x:31783,y:33246,varname:node_1078,prsc:2|A-1955-OUT,B-993-OUT;n:type:ShaderForge.SFN_Vector1,id:993,x:31443,y:33552,varname:node_993,prsc:2,v1:0.3;n:type:ShaderForge.SFN_Multiply,id:8420,x:31957,y:33746,varname:node_8420,prsc:2|A-1078-OUT,B-4793-OUT;n:type:ShaderForge.SFN_Vector1,id:4793,x:31653,y:33886,varname:node_4793,prsc:2,v1:2;n:type:ShaderForge.SFN_Clamp,id:8198,x:32259,y:33520,varname:node_8198,prsc:2|IN-2167-OUT,MIN-8147-OUT,MAX-287-OUT;n:type:ShaderForge.SFN_Vector1,id:8147,x:32039,y:33957,varname:node_8147,prsc:2,v1:0;n:type:ShaderForge.SFN_Vector1,id:287,x:32039,y:34031,varname:node_287,prsc:2,v1:1;n:type:ShaderForge.SFN_Add,id:2167,x:31783,y:33391,varname:node_2167,prsc:2|A-1955-OUT,B-993-OUT;n:type:ShaderForge.SFN_Multiply,id:2195,x:31444,y:30911,varname:node_2195,prsc:2|A-7638-OUT,B-1505-RGB,C-9140-OUT;n:type:ShaderForge.SFN_LightVector,id:4624,x:30788,y:30662,varname:node_4624,prsc:2;n:type:ShaderForge.SFN_NormalVector,id:8565,x:30803,y:30889,prsc:2,pt:True;n:type:ShaderForge.SFN_Dot,id:7638,x:31046,y:30779,varname:node_7638,prsc:2,dt:1|A-4624-OUT,B-8565-OUT;n:type:ShaderForge.SFN_LightAttenuation,id:9140,x:31217,y:31331,varname:node_9140,prsc:2;n:type:ShaderForge.SFN_Subtract,id:4993,x:31660,y:30769,varname:node_4993,prsc:2|A-2195-OUT,B-4243-OUT;n:type:ShaderForge.SFN_Vector1,id:4243,x:31346,y:30725,varname:node_4243,prsc:2,v1:0.45;n:type:ShaderForge.SFN_Color,id:1505,x:30803,y:31168,ptovrint:False,ptlb:node_1505,ptin:_node_1505,varname:node_1505,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:1,c2:0,c3:0,c4:1;n:type:ShaderForge.SFN_Multiply,id:6291,x:33179,y:32984,varname:node_6291,prsc:2|A-9773-OUT,B-4651-OUT;n:type:ShaderForge.SFN_Step,id:3746,x:31721,y:31023,varname:node_3746,prsc:2|A-7522-OUT,B-4993-OUT;n:type:ShaderForge.SFN_ChannelBlend,id:4697,x:34228,y:32732,varname:node_4697,prsc:2,chbt:1|M-3746-OUT,R-4814-RGB,G-4814-RGB,B-4814-RGB,BTM-6291-OUT;n:type:ShaderForge.SFN_Color,id:4814,x:34204,y:32540,ptovrint:False,ptlb:Gloss Colour,ptin:_GlossColour,varname:node_4814,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:1,c2:1,c3:1,c4:1;n:type:ShaderForge.SFN_Slider,id:4502,x:31458,y:31431,ptovrint:False,ptlb:Gloss Level,ptin:_GlossLevel,varname:node_4502,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:1,max:1;n:type:ShaderForge.SFN_OneMinus,id:7522,x:31627,y:31198,varname:node_7522,prsc:2|IN-4502-OUT;n:type:ShaderForge.SFN_Color,id:391,x:38201,y:33517,ptovrint:False,ptlb:OutLineColur,ptin:_OutLineColur,varname:node_391,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:1,c2:0,c3:1,c4:1;n:type:ShaderForge.SFN_Slider,id:152,x:38078,y:33715,ptovrint:False,ptlb:OutLineWidth,ptin:_OutLineWidth,varname:node_152,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0,max:10;proporder:9278-910-1987-9957-8645-5948-5510-8679-1713-1505-4814-4502-152-391;pass:END;sub:END;*/

Shader "Custom/CelShader" {
    Properties {
        _NA ("NA", 2D) = "white" {}
        _ObjectTint ("Object Tint", Color) = (0.5,0.5,0.5,1)
        _Steps ("Steps", Float ) = 4
        _Saturation ("Saturation", Float ) = 1
        _node_8645 ("node_8645", 2D) = "white" {}
        _node_5948 ("node_5948", Float ) = 10
        _ShadowColour ("ShadowColour", Color) = (0.2,0.2,0.2,0.2)
        _ObjectColour ("ObjectColour", Color) = (1,1,1,1)
        _node_1713 ("node_1713", Float ) = 1
        _node_1505 ("node_1505", Color) = (1,0,0,1)
        _GlossColour ("Gloss Colour", Color) = (1,1,1,1)
        _GlossLevel ("Gloss Level", Range(0, 1)) = 1
        _OutLineWidth ("OutLineWidth", Range(0, 10)) = 0
        _OutLineColur ("OutLineColur", Color) = (1,0,1,1)
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
            uniform sampler2D _NA; uniform float4 _NA_ST;
            uniform float4 _ObjectTint;
            uniform float _Saturation;
            uniform float _Steps;
            uniform sampler2D _node_8645; uniform float4 _node_8645_ST;
            uniform float4 _ObjectColour;
            uniform float4 _node_1505;
            uniform float4 _GlossColour;
            uniform float _GlossLevel;
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
                float3 normalDirection = i.normalDir;
                float3 lightDirection = normalize(_WorldSpaceLightPos0.xyz);
                float3 lightColor = _LightColor0.rgb;
////// Lighting:
                float attenuation = LIGHT_ATTENUATION(i);
////// Emissive:
                float4 _NA_var = tex2D(_NA,TRANSFORM_TEX(i.uv0, _NA));
                float3 emissive = ((_NA_var.rgb*_ObjectTint.rgb)*UNITY_LIGHTMODEL_AMBIENT.rgb);
                float3 node_3746 = step((1.0 - _GlossLevel),((max(0,dot(lightDirection,normalDirection))*_node_1505.rgb*attenuation)-0.45));
                float4 _node_8645_var = tex2D(_node_8645,TRANSFORM_TEX(i.uv0, _node_8645));
                float3 node_9773 = (((_ObjectColour.rgb*_node_8645_var.rgb)*_LightColor0.rgb)*_LightColor0.rgb);
                float node_1955 = (max(0,dot(lightDirection,normalDirection))*lerp(_LightColor0.rgb,dot(_LightColor0.rgb,float3(0.3,0.59,0.11)),_Saturation)*attenuation);
                float node_993 = 0.3;
                float node_4651 = floor(clamp((node_1955+node_993),0.0,1.0) * _Steps) / (_Steps - 1);
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
            uniform sampler2D _NA; uniform float4 _NA_ST;
            uniform float4 _ObjectTint;
            uniform float _Saturation;
            uniform float _Steps;
            uniform sampler2D _node_8645; uniform float4 _node_8645_ST;
            uniform float4 _ObjectColour;
            uniform float4 _node_1505;
            uniform float4 _GlossColour;
            uniform float _GlossLevel;
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
                float3 normalDirection = i.normalDir;
                float3 lightDirection = normalize(lerp(_WorldSpaceLightPos0.xyz, _WorldSpaceLightPos0.xyz - i.posWorld.xyz,_WorldSpaceLightPos0.w));
                float3 lightColor = _LightColor0.rgb;
////// Lighting:
                float attenuation = LIGHT_ATTENUATION(i);
                float3 node_3746 = step((1.0 - _GlossLevel),((max(0,dot(lightDirection,normalDirection))*_node_1505.rgb*attenuation)-0.45));
                float4 _node_8645_var = tex2D(_node_8645,TRANSFORM_TEX(i.uv0, _node_8645));
                float3 node_9773 = (((_ObjectColour.rgb*_node_8645_var.rgb)*_LightColor0.rgb)*_LightColor0.rgb);
                float node_1955 = (max(0,dot(lightDirection,normalDirection))*lerp(_LightColor0.rgb,dot(_LightColor0.rgb,float3(0.3,0.59,0.11)),_Saturation)*attenuation);
                float node_993 = 0.3;
                float node_4651 = floor(clamp((node_1955+node_993),0.0,1.0) * _Steps) / (_Steps - 1);
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
