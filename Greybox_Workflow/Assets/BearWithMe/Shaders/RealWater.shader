// Upgrade NOTE: replaced '_Object2World' with 'unity_ObjectToWorld'

// Shader created with Shader Forge v1.38 
// Shader Forge (c) Neat Corporation / Joachim Holmer - http://www.acegikmo.com/shaderforge/
// Note: Manually altering this data may prevent you from opening it in Shader Forge
/*SF_DATA;ver:1.38;sub:START;pass:START;ps:flbk:,iptp:0,cusa:False,bamd:0,cgin:,lico:1,lgpr:1,limd:3,spmd:1,trmd:0,grmd:0,uamb:True,mssp:True,bkdf:False,hqlp:False,rprd:False,enco:False,rmgx:True,imps:True,rpth:0,vtps:0,hqsc:True,nrmq:1,nrsp:0,vomd:0,spxs:False,tesm:0,olmd:1,culm:0,bsrc:3,bdst:7,dpts:2,wrdp:False,dith:0,atcv:False,rfrpo:True,rfrpn:Refraction,coma:15,ufog:True,aust:True,igpj:True,qofs:0,qpre:3,rntp:2,fgom:False,fgoc:False,fgod:False,fgor:False,fgmd:0,fgcr:0.5,fgcg:0.5,fgcb:0.5,fgca:1,fgde:0.01,fgrn:0,fgrf:300,stcl:False,atwp:False,stva:128,stmr:255,stmw:255,stcp:6,stps:0,stfa:0,stfz:0,ofsf:0,ofsu:0,f2p0:False,fnsp:False,fnfb:False,fsmp:False;n:type:ShaderForge.SFN_Final,id:3666,x:36927,y:31706,varname:node_3666,prsc:2|diff-7583-OUT,spec-8170-OUT,gloss-63-OUT,normal-257-OUT,amspl-2257-OUT,spcocc-5872-OUT,alpha-9070-OUT,refract-1308-OUT,disp-659-OUT,tess-3209-OUT;n:type:ShaderForge.SFN_ValueProperty,id:8552,x:25259,y:31831,ptovrint:False,ptlb:Sway frequency,ptin:_Swayfrequency,varname:node_8552,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:1;n:type:ShaderForge.SFN_Tau,id:1253,x:25274,y:31938,varname:node_1253,prsc:2;n:type:ShaderForge.SFN_Time,id:799,x:25252,y:32061,varname:node_799,prsc:2;n:type:ShaderForge.SFN_Multiply,id:9641,x:25535,y:32048,varname:node_9641,prsc:2|A-8552-OUT,B-1253-OUT;n:type:ShaderForge.SFN_Sin,id:1916,x:25716,y:32061,varname:node_1916,prsc:2|IN-9641-OUT;n:type:ShaderForge.SFN_Multiply,id:8933,x:25936,y:32040,varname:node_8933,prsc:2|A-9176-OUT,B-1916-OUT;n:type:ShaderForge.SFN_Slider,id:9176,x:25475,y:31938,ptovrint:False,ptlb:Sway Intensity,ptin:_SwayIntensity,varname:node_9176,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0.5,max:1;n:type:ShaderForge.SFN_Add,id:4709,x:26135,y:32061,varname:node_4709,prsc:2|A-8933-OUT,B-799-T;n:type:ShaderForge.SFN_Slider,id:1223,x:26108,y:33363,ptovrint:False,ptlb:Flow Movement Horizontal,ptin:_FlowMovementHorizontal,varname:node_1223,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0,max:1;n:type:ShaderForge.SFN_Slider,id:2323,x:26108,y:33519,ptovrint:False,ptlb:Flow Movement Vertical,ptin:_FlowMovementVertical,varname:node_2323,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0,max:1;n:type:ShaderForge.SFN_Vector1,id:9430,x:25629,y:33617,varname:node_9430,prsc:2,v1:1;n:type:ShaderForge.SFN_ObjectScale,id:8699,x:25310,y:33792,varname:node_8699,prsc:2,rcp:False;n:type:ShaderForge.SFN_Append,id:3172,x:25588,y:33804,varname:node_3172,prsc:2|A-8699-X,B-8699-Z;n:type:ShaderForge.SFN_SwitchProperty,id:6831,x:26222,y:33786,ptovrint:False,ptlb:Flow with object,ptin:_Flowwithobject,varname:node_6831,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,on:False|A-9430-OUT,B-3172-OUT;n:type:ShaderForge.SFN_TexCoord,id:9727,x:26340,y:33606,varname:node_9727,prsc:2,uv:0,uaff:False;n:type:ShaderForge.SFN_Multiply,id:2828,x:26601,y:33606,varname:node_2828,prsc:2|A-9727-UVOUT,B-6831-OUT;n:type:ShaderForge.SFN_Multiply,id:146,x:26601,y:33460,varname:node_146,prsc:2|A-4709-OUT,B-2323-OUT;n:type:ShaderForge.SFN_Multiply,id:321,x:26847,y:33460,varname:node_321,prsc:2|A-4709-OUT,B-1223-OUT;n:type:ShaderForge.SFN_Panner,id:1487,x:26847,y:33606,varname:node_1487,prsc:2,spu:1,spv:1|UVIN-2828-OUT,DIST-146-OUT;n:type:ShaderForge.SFN_Panner,id:8667,x:27085,y:33606,varname:node_8667,prsc:2,spu:1,spv:1|UVIN-1487-UVOUT,DIST-321-OUT;n:type:ShaderForge.SFN_Tex2d,id:2541,x:27310,y:33606,ptovrint:False,ptlb:FlowMap,ptin:_FlowMap,varname:node_2541,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:7aaeb55bd61f2d14ba3bbe9b2e227940,ntxv:0,isnm:False|UVIN-8667-UVOUT;n:type:ShaderForge.SFN_ComponentMask,id:7209,x:27750,y:33603,varname:node_7209,prsc:2,cc1:0,cc2:1,cc3:-1,cc4:-1|IN-2541-RGB;n:type:ShaderForge.SFN_RemapRange,id:6655,x:28011,y:33605,varname:node_6655,prsc:2,frmn:0,frmx:1,tomn:-1,tomx:1|IN-7209-OUT;n:type:ShaderForge.SFN_Multiply,id:3089,x:28247,y:33605,varname:node_3089,prsc:2|A-6655-OUT,B-4551-OUT,C-2084-OUT;n:type:ShaderForge.SFN_ValueProperty,id:4551,x:28011,y:33815,ptovrint:False,ptlb:Flow Power,ptin:_FlowPower,varname:node_4551,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0.5;n:type:ShaderForge.SFN_Vector1,id:2084,x:28011,y:33886,varname:node_2084,prsc:2,v1:1;n:type:ShaderForge.SFN_Multiply,id:2820,x:28852,y:33605,varname:node_2820,prsc:2|A-3089-OUT,B-9024-OUT;n:type:ShaderForge.SFN_Multiply,id:3950,x:28852,y:33736,varname:node_3950,prsc:2|A-3089-OUT,B-1382-OUT;n:type:ShaderForge.SFN_Frac,id:1382,x:28399,y:33736,varname:node_1382,prsc:2|IN-7201-OUT;n:type:ShaderForge.SFN_Add,id:7201,x:27904,y:34059,varname:node_7201,prsc:2|A-9504-OUT,B-3213-OUT;n:type:ShaderForge.SFN_Multiply,id:9504,x:27667,y:33977,varname:node_9504,prsc:2|A-4709-OUT,B-5092-OUT;n:type:ShaderForge.SFN_Vector1,id:3213,x:27667,y:34174,varname:node_3213,prsc:2,v1:0.5;n:type:ShaderForge.SFN_ValueProperty,id:5092,x:27445,y:33914,ptovrint:False,ptlb:Flow Speed,ptin:_FlowSpeed,varname:node_5092,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:1;n:type:ShaderForge.SFN_Frac,id:9024,x:28399,y:33864,varname:node_9024,prsc:2|IN-9504-OUT;n:type:ShaderForge.SFN_Vector1,id:3633,x:28399,y:34016,varname:node_3633,prsc:2,v1:0.5;n:type:ShaderForge.SFN_Subtract,id:2110,x:28852,y:33903,varname:node_2110,prsc:2|A-3633-OUT,B-9024-OUT;n:type:ShaderForge.SFN_Add,id:9667,x:29116,y:33737,varname:node_9667,prsc:2|A-8235-OUT,B-3950-OUT;n:type:ShaderForge.SFN_Multiply,id:8235,x:28830,y:33439,varname:node_8235,prsc:2|A-4206-OUT,B-5750-UVOUT;n:type:ShaderForge.SFN_Divide,id:9899,x:29116,y:33904,varname:node_9899,prsc:2|A-2110-OUT,B-3633-OUT;n:type:ShaderForge.SFN_Abs,id:857,x:29328,y:33904,varname:node_857,prsc:2|IN-9899-OUT;n:type:ShaderForge.SFN_Lerp,id:5766,x:29553,y:33674,varname:node_5766,prsc:2|A-9543-OUT,B-9667-OUT,T-857-OUT;n:type:ShaderForge.SFN_TexCoord,id:5750,x:28598,y:33439,varname:node_5750,prsc:2,uv:0,uaff:False;n:type:ShaderForge.SFN_Append,id:4206,x:28575,y:33068,varname:node_4206,prsc:2|A-9457-X,B-9457-Z;n:type:ShaderForge.SFN_ObjectScale,id:9457,x:28350,y:33036,varname:node_9457,prsc:2,rcp:False;n:type:ShaderForge.SFN_Add,id:9543,x:29113,y:33469,varname:node_9543,prsc:2|A-8235-OUT,B-2820-OUT;n:type:ShaderForge.SFN_Multiply,id:602,x:30578,y:33147,varname:node_602,prsc:2|A-5766-OUT,B-9679-OUT;n:type:ShaderForge.SFN_ValueProperty,id:9679,x:30016,y:33056,ptovrint:False,ptlb:Normal Tiling Differ,ptin:_NormalTilingDiffer,varname:node_9679,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:1.4;n:type:ShaderForge.SFN_FragmentPosition,id:4695,x:28429,y:31704,varname:node_4695,prsc:2;n:type:ShaderForge.SFN_Relay,id:8004,x:28775,y:32003,varname:node_8004,prsc:2|IN-4709-OUT;n:type:ShaderForge.SFN_Normalize,id:92,x:28716,y:31822,varname:node_92,prsc:2|IN-4695-XYZ;n:type:ShaderForge.SFN_ComponentMask,id:1622,x:28871,y:31601,varname:node_1622,prsc:2,cc1:0,cc2:2,cc3:-1,cc4:-1|IN-4695-XYZ;n:type:ShaderForge.SFN_Add,id:5912,x:29336,y:31972,varname:node_5912,prsc:2|A-8004-OUT,B-323-OUT;n:type:ShaderForge.SFN_Vector1,id:323,x:29072,y:32048,varname:node_323,prsc:2,v1:4;n:type:ShaderForge.SFN_Add,id:9270,x:29357,y:31663,varname:node_9270,prsc:2|A-8004-OUT,B-6428-OUT;n:type:ShaderForge.SFN_Vector1,id:6428,x:29186,y:31772,varname:node_6428,prsc:2,v1:2;n:type:ShaderForge.SFN_Code,id:5900,x:29763,y:31376,varname:node_5900,prsc:2,code:ZgBsAG8AYQB0ACAAcABoAGEAcwBlAEMAbwBuAHQAIAA9ACAAUwBwAGUAZQBkACAAKgAgAFcAYQB2AGUAbABlAG4AZwB0AGgAOwAKAGYAbABvAGEAdAAgAHgAVgBhAGwAIAA9ACAAUwB0AGUAZQBwAG4AZQBzAHMAIAAqACAAQQBtAHAAbABpAHQAdQBkAGUAIAAqACAARABpAHIAZQBjAHQAaQBvAG4AVgBlAGMALgB4ACAAKgAgAGMAbwBzACgAVwBhAHYAZQBsAGUAbgBnAHQAaAAgACoAIABEAG8AdABQAHIAbwBkACAAKwAgAFQAaQBtAGUAIAAqACAAcABoAGEAcwBlAEMAbwBuAHQAKQA7AAoAZgBsAG8AYQB0ACAAeQBWAGEAbAAgAD0AIABBAG0AcABsAGkAdAB1AGQAZQAgACoAIABzAGkAbgAoAFcAYQB2AGUAbABlAG4AZwB0AGgAIAAqACAARABvAHQAUAByAG8AZAAgACsAIABUAGkAbQBlACAAKgAgAHAAaABhAHMAZQBDAG8AbgBzAHQAKQA7AAoAZgBsAG8AYQB0ACAAegBWAGEAbAAgAD0AIABTAHQAZQBlAHAAbgBlAHMAcwAgACoAIABBAG0AcABsAGkAdAB1AGQAZQAgACoAIABEAGkAcgBlAGMAdABpAG8AbgBWAGUAYwAuAHkAIAAqACAAYwBvAHMAKABXAGEAdgBlAGwAZQBuAGcAdABoACAAKgAgAEQAbwB0AFAAcgBvAGQAIAArACAAcABoAGEAcwBlAEMAbwBuAHMAdAApADsACgByAGUAdAB1AHIAbgAgAGYAbABvAGEAdAAzACgAeABWAGEAbAAsACAAeQBWAGEAbAAsACAAegBWAGEAbAApADsA,output:2,fname:Gerstner2,width:913,height:323,input:0,input:0,input:0,input:0,input:0,input:0,input_1_label:Steepness,input_2_label:Amplitude,input_3_label:Wavelength,input_4_label:Speed,input_5_label:Time,input_6_label:DotProd|A-6726-OUT,B-7148-OUT,C-4239-OUT,D-3465-OUT,E-9270-OUT,F-3119-OUT;n:type:ShaderForge.SFN_Code,id:1573,x:29766,y:31852,varname:node_1573,prsc:2,code:ZgBsAG8AYQB0ACAAcABoAGEAcwBlAEMAbwBuAHQAIAA9ACAAUwBwAGUAZQBkACAAKgAgAFcAYQB2AGUAbABlAG4AZwB0AGgAOwAKAGYAbABvAGEAdAAgAHgAVgBhAGwAIAA9ACAAUwB0AGUAZQBwAG4AZQBzAHMAIAAqACAAQQBtAHAAbABpAHQAdQBkAGUAIAAqACAARABpAHIAZQBjAHQAaQBvAG4AVgBlAGMALgB4ACAAKgAgAGMAbwBzACgAVwBhAHYAZQBsAGUAbgBnAHQAaAAgACoAIABEAG8AdABQAHIAbwBkACAAKwAgAFQAaQBtAGUAIAAqACAAcABoAGEAcwBlAEMAbwBuAHQAKQA7AAoAZgBsAG8AYQB0ACAAeQBWAGEAbAAgAD0AIABBAG0AcABsAGkAdAB1AGQAZQAgACoAIABzAGkAbgAoAFcAYQB2AGUAbABlAG4AZwB0AGgAIAAqACAARABvAHQAUAByAG8AZAAgACsAIABUAGkAbQBlACAAKgAgAHAAaABhAHMAZQBDAG8AbgBzAHQAKQA7AAoAZgBsAG8AYQB0ACAAegBWAGEAbAAgAD0AIABTAHQAZQBlAHAAbgBlAHMAcwAgACoAIABBAG0AcABsAGkAdAB1AGQAZQAgACoAIABEAGkAcgBlAGMAdABpAG8AbgBWAGUAYwAuAHkAIAAqACAAYwBvAHMAKABXAGEAdgBlAGwAZQBuAGcAdABoACAAKgAgAEQAbwB0AFAAcgBvAGQAIAArACAAcABoAGEAcwBlAEMAbwBuAHMAdAApADsACgByAGUAdAB1AHIAbgAgAGYAbABvAGEAdAAzACgAeABWAGEAbAAsACAAeQBWAGEAbAAsACAAegBWAGEAbAApADsA,output:2,fname:Gerstner3,width:917,height:350,input:0,input:0,input:0,input:0,input:0,input:0,input_1_label:Steepness,input_2_label:Amplitude,input_3_label:Wavelength,input_4_label:Speed,input_5_label:Time,input_6_label:DotProd|A-6726-OUT,B-7148-OUT,C-4239-OUT,D-3465-OUT,E-5912-OUT,F-8056-OUT;n:type:ShaderForge.SFN_Code,id:4864,x:29761,y:30900,varname:node_4864,prsc:2,code:ZgBsAG8AYQB0ACAAcABoAGEAcwBlAEMAbwBuAHQAIAA9ACAAUwBwAGUAZQBkACAAKgAgAFcAYQB2AGUAbABlAG4AZwB0AGgAOwAKAGYAbABvAGEAdAAgAHgAVgBhAGwAIAA9ACAAUwB0AGUAZQBwAG4AZQBzAHMAIAAqACAAQQBtAHAAbABpAHQAdQBkAGUAIAAqACAARABpAHIAZQBjAHQAaQBvAG4AVgBlAGMALgB4ACAAKgAgAGMAbwBzACgAVwBhAHYAZQBsAGUAbgBnAHQAaAAgACoAIABEAG8AdABQAHIAbwBkACAAKwAgAFQAaQBtAGUAIAAqACAAcABoAGEAcwBlAEMAbwBuAHQAKQA7AAoAZgBsAG8AYQB0ACAAeQBWAGEAbAAgAD0AIABBAG0AcABsAGkAdAB1AGQAZQAgACoAIABzAGkAbgAoAFcAYQB2AGUAbABlAG4AZwB0AGgAIAAqACAARABvAHQAUAByAG8AZAAgACsAIABUAGkAbQBlACAAKgAgAHAAaABhAHMAZQBDAG8AbgBzAHQAKQA7AAoAZgBsAG8AYQB0ACAAegBWAGEAbAAgAD0AIABTAHQAZQBlAHAAbgBlAHMAcwAgACoAIABBAG0AcABsAGkAdAB1AGQAZQAgACoAIABEAGkAcgBlAGMAdABpAG8AbgBWAGUAYwAuAHkAIAAqACAAYwBvAHMAKABXAGEAdgBlAGwAZQBuAGcAdABoACAAKgAgAEQAbwB0AFAAcgBvAGQAIAArACAAcABoAGEAcwBlAEMAbwBuAHMAdAApADsACgByAGUAdAB1AHIAbgAgAGYAbABvAGEAdAAzACgAeABWAGEAbAAsACAAeQBWAGEAbAAsACAAegBWAGEAbAApADsA,output:2,fname:Gerstner1,width:917,height:350,input:0,input:0,input:0,input:0,input:0,input:0,input_1_label:Steepness,input_2_label:Amplitude,input_3_label:Wavelength,input_4_label:Speed,input_5_label:Time,input_6_label:DotProd|A-6726-OUT,B-7148-OUT,C-4239-OUT,D-3465-OUT,E-8004-OUT,F-2859-OUT;n:type:ShaderForge.SFN_Slider,id:2916,x:28599,y:31413,ptovrint:False,ptlb:Wave 3 Z - Direction,ptin:_Wave3ZDirection,varname:node_2916,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:-1,cur:0,max:1;n:type:ShaderForge.SFN_Slider,id:5179,x:28599,y:31282,ptovrint:False,ptlb:Wave 3 X - Direction,ptin:_Wave3XDirection,varname:node_5179,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:-1,cur:0,max:1;n:type:ShaderForge.SFN_Slider,id:919,x:28599,y:31160,ptovrint:False,ptlb:Wave 3 X - Direction_copy,ptin:_Wave3XDirection_copy,varname:_Wave3XDirection_copy,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:-1,cur:0,max:1;n:type:ShaderForge.SFN_Slider,id:472,x:28599,y:31036,ptovrint:False,ptlb:Wave 2 - ,ptin:_Wave2,varname:_Wave3XDirection_copy_copy,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:-1,cur:0,max:1;n:type:ShaderForge.SFN_Slider,id:5149,x:28599,y:30911,ptovrint:False,ptlb:Wave 1 Z - Direction,ptin:_Wave1ZDirection,varname:_Wave3XDirection_copy_copy_copy,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:-1,cur:0,max:1;n:type:ShaderForge.SFN_Slider,id:6202,x:28599,y:30788,ptovrint:False,ptlb:Wave 1 X - Direction,ptin:_Wave1XDirection,varname:_Wave3XDirection_copy_copy_copy_copy,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:-1,cur:0,max:1;n:type:ShaderForge.SFN_Append,id:7455,x:29005,y:30829,varname:node_7455,prsc:2|A-6202-OUT,B-5149-OUT;n:type:ShaderForge.SFN_Append,id:3721,x:29005,y:31084,varname:node_3721,prsc:2|A-472-OUT,B-919-OUT;n:type:ShaderForge.SFN_Append,id:8590,x:29005,y:31332,varname:node_8590,prsc:2|A-5179-OUT,B-2916-OUT;n:type:ShaderForge.SFN_ValueProperty,id:6726,x:29187,y:30632,ptovrint:False,ptlb:Wave Sharpness,ptin:_WaveSharpness,varname:node_6726,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:1;n:type:ShaderForge.SFN_ValueProperty,id:7148,x:29187,y:30734,ptovrint:False,ptlb:Wave Height,ptin:_WaveHeight,varname:node_7148,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:1;n:type:ShaderForge.SFN_ValueProperty,id:4239,x:29201,y:30986,ptovrint:False,ptlb:Wave Spread,ptin:_WaveSpread,varname:node_4239,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:1;n:type:ShaderForge.SFN_Dot,id:2859,x:29361,y:30816,varname:node_2859,prsc:2,dt:0|A-7455-OUT,B-1622-OUT;n:type:ShaderForge.SFN_Dot,id:3119,x:29364,y:31089,varname:node_3119,prsc:2,dt:0|A-3721-OUT,B-1622-OUT;n:type:ShaderForge.SFN_ValueProperty,id:3465,x:29187,y:31245,ptovrint:False,ptlb:Wave Speed,ptin:_WaveSpeed,varname:node_3465,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:1;n:type:ShaderForge.SFN_Dot,id:8056,x:29364,y:31339,varname:node_8056,prsc:2,dt:0|A-8590-OUT,B-1622-OUT;n:type:ShaderForge.SFN_Relay,id:451,x:30719,y:32693,varname:node_451,prsc:2|IN-8004-OUT;n:type:ShaderForge.SFN_Relay,id:8902,x:30678,y:30571,varname:node_8902,prsc:2|IN-7148-OUT;n:type:ShaderForge.SFN_Time,id:5161,x:28763,y:30171,varname:node_5161,prsc:2;n:type:ShaderForge.SFN_Multiply,id:526,x:29116,y:30201,varname:node_526,prsc:2|A-5161-T,B-1918-OUT;n:type:ShaderForge.SFN_Slider,id:1918,x:28763,y:30352,ptovrint:False,ptlb:Foam Time Speed,ptin:_FoamTimeSpeed,varname:node_1918,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0,max:1;n:type:ShaderForge.SFN_Sin,id:6547,x:29319,y:30201,varname:node_6547,prsc:2|IN-526-OUT;n:type:ShaderForge.SFN_Multiply,id:5913,x:29537,y:30285,varname:node_5913,prsc:2|A-6547-OUT,B-1080-OUT;n:type:ShaderForge.SFN_ValueProperty,id:1080,x:29325,y:30408,ptovrint:False,ptlb:Foam Horizontal Speed,ptin:_FoamHorizontalSpeed,varname:node_1080,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0;n:type:ShaderForge.SFN_Panner,id:2681,x:29774,y:30285,varname:node_2681,prsc:2,spu:1,spv:1|UVIN-602-OUT,DIST-5913-OUT;n:type:ShaderForge.SFN_Panner,id:1844,x:29998,y:30285,varname:node_1844,prsc:2,spu:1,spv:1|UVIN-2681-UVOUT,DIST-2170-OUT;n:type:ShaderForge.SFN_Tex2d,id:7039,x:30275,y:30283,ptovrint:False,ptlb:Foam,ptin:_Foam,varname:node_7039,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,ntxv:0,isnm:False|UVIN-1844-UVOUT;n:type:ShaderForge.SFN_Multiply,id:2170,x:29774,y:30078,varname:node_2170,prsc:2|A-2724-OUT,B-6547-OUT;n:type:ShaderForge.SFN_ValueProperty,id:2724,x:29379,y:29981,ptovrint:False,ptlb:Foam Vertical speed,ptin:_FoamVerticalspeed,varname:node_2724,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0;n:type:ShaderForge.SFN_Multiply,id:7808,x:30606,y:29812,varname:node_7808,prsc:2|A-605-OUT,B-7039-RGB;n:type:ShaderForge.SFN_OneMinus,id:605,x:30249,y:29237,varname:node_605,prsc:2|IN-7463-OUT;n:type:ShaderForge.SFN_Clamp01,id:7463,x:29888,y:29432,varname:node_7463,prsc:2|IN-1083-OUT;n:type:ShaderForge.SFN_Power,id:1083,x:29638,y:29432,varname:node_1083,prsc:2|VAL-2502-OUT,EXP-5827-OUT;n:type:ShaderForge.SFN_ValueProperty,id:5827,x:29354,y:29442,ptovrint:False,ptlb:Foam Falloff,ptin:_FoamFalloff,varname:node_5827,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0;n:type:ShaderForge.SFN_Multiply,id:2502,x:29357,y:29560,varname:node_2502,prsc:2|A-1419-OUT,B-3322-OUT;n:type:ShaderForge.SFN_Reciprocal,id:1419,x:29034,y:29410,varname:node_1419,prsc:2|IN-2886-OUT;n:type:ShaderForge.SFN_DepthBlend,id:3322,x:29034,y:29588,varname:node_3322,prsc:2|DIST-1946-OUT;n:type:ShaderForge.SFN_ValueProperty,id:1946,x:28825,y:29588,ptovrint:False,ptlb:Depth,ptin:_Depth,varname:node_1946,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0;n:type:ShaderForge.SFN_Slider,id:2886,x:28638,y:29398,ptovrint:False,ptlb:Foam Spread,ptin:_FoamSpread,varname:node_2886,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0,max:1;n:type:ShaderForge.SFN_Slider,id:8309,x:29279,y:29722,ptovrint:False,ptlb:Opacity Minimum,ptin:_OpacityMinimum,varname:node_8309,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0,max:1;n:type:ShaderForge.SFN_Clamp,id:340,x:29877,y:29720,varname:node_340,prsc:2|IN-3322-OUT,MIN-8309-OUT,MAX-1883-OUT;n:type:ShaderForge.SFN_Vector1,id:1883,x:29637,y:29859,varname:node_1883,prsc:2,v1:1;n:type:ShaderForge.SFN_Vector1,id:8051,x:30249,y:29122,varname:node_8051,prsc:2,v1:0.5;n:type:ShaderForge.SFN_Multiply,id:4382,x:30457,y:28989,varname:node_4382,prsc:2|A-500-OUT,B-8051-OUT,C-2644-OUT;n:type:ShaderForge.SFN_Add,id:2644,x:30249,y:28942,varname:node_2644,prsc:2|A-5775-X,B-5775-Z;n:type:ShaderForge.SFN_ValueProperty,id:500,x:30249,y:28873,ptovrint:False,ptlb:Edge-Line Width,ptin:_EdgeLineWidth,varname:node_500,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0;n:type:ShaderForge.SFN_ObjectScale,id:5775,x:30002,y:28932,varname:node_5775,prsc:2,rcp:True;n:type:ShaderForge.SFN_Add,id:3907,x:30682,y:28989,varname:node_3907,prsc:2|A-605-OUT,B-4382-OUT;n:type:ShaderForge.SFN_Power,id:4058,x:30922,y:28989,varname:node_4058,prsc:2|VAL-3907-OUT,EXP-6966-OUT;n:type:ShaderForge.SFN_ValueProperty,id:6966,x:30682,y:29188,ptovrint:False,ptlb:Foam Outline Fall,ptin:_FoamOutlineFall,varname:node_6966,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:1;n:type:ShaderForge.SFN_Add,id:5166,x:31537,y:29000,varname:node_5166,prsc:2|A-7808-OUT,B-4058-OUT;n:type:ShaderForge.SFN_Multiply,id:4741,x:31840,y:29087,varname:node_4741,prsc:2|A-5166-OUT,B-4587-OUT;n:type:ShaderForge.SFN_Slider,id:4587,x:31460,y:29213,ptovrint:False,ptlb:Foam Intensity,ptin:_FoamIntensity,varname:node_4587,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:1,max:2;n:type:ShaderForge.SFN_ComponentMask,id:9208,x:32139,y:29223,varname:node_9208,prsc:2,cc1:0,cc2:-1,cc3:-1,cc4:-1|IN-4741-OUT;n:type:ShaderForge.SFN_Add,id:4693,x:32446,y:29387,varname:node_4693,prsc:2|A-9208-OUT,B-340-OUT;n:type:ShaderForge.SFN_Relay,id:9070,x:32847,y:29452,varname:node_9070,prsc:2|IN-4693-OUT;n:type:ShaderForge.SFN_ValueProperty,id:7087,x:31688,y:33488,ptovrint:False,ptlb:Normal Scroll Speed,ptin:_NormalScrollSpeed,varname:node_7087,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0.2;n:type:ShaderForge.SFN_Multiply,id:1019,x:31901,y:33454,varname:node_1019,prsc:2|A-4709-OUT,B-7087-OUT;n:type:ShaderForge.SFN_Slider,id:5733,x:31813,y:33210,ptovrint:False,ptlb:Normal 1 Horizontal Speed,ptin:_Normal1HorizontalSpeed,varname:node_5733,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:-1,cur:0,max:1;n:type:ShaderForge.SFN_Slider,id:9252,x:31813,y:33340,ptovrint:False,ptlb:Normal 1 Vertical Speed,ptin:_Normal1VerticalSpeed,varname:node_9252,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:-1,cur:0,max:1;n:type:ShaderForge.SFN_Slider,id:7010,x:31822,y:33645,ptovrint:False,ptlb:Normal 2 Horizontal Speed,ptin:_Normal2HorizontalSpeed,varname:node_7010,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:-1,cur:0,max:1;n:type:ShaderForge.SFN_Slider,id:4098,x:31822,y:33784,ptovrint:False,ptlb:Normal 2 Vertical Speed,ptin:_Normal2VerticalSpeed,varname:node_4098,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:-1,cur:0,max:1;n:type:ShaderForge.SFN_Multiply,id:1042,x:32219,y:33174,varname:node_1042,prsc:2|A-1019-OUT,B-5733-OUT;n:type:ShaderForge.SFN_Multiply,id:2286,x:32219,y:33326,varname:node_2286,prsc:2|A-9252-OUT,B-1019-OUT;n:type:ShaderForge.SFN_Multiply,id:460,x:32211,y:33618,varname:node_460,prsc:2|A-1019-OUT,B-7010-OUT;n:type:ShaderForge.SFN_Multiply,id:393,x:32211,y:33763,varname:node_393,prsc:2|A-4098-OUT,B-1019-OUT;n:type:ShaderForge.SFN_Panner,id:6143,x:32501,y:33319,varname:node_6143,prsc:2,spu:1,spv:1|UVIN-602-OUT,DIST-2286-OUT;n:type:ShaderForge.SFN_Panner,id:3751,x:32745,y:33319,varname:node_3751,prsc:2,spu:1,spv:1|UVIN-6143-UVOUT,DIST-1042-OUT;n:type:ShaderForge.SFN_Panner,id:986,x:32491,y:33689,varname:node_986,prsc:2,spu:1,spv:0|UVIN-5766-OUT,DIST-393-OUT;n:type:ShaderForge.SFN_Panner,id:5414,x:32749,y:33698,varname:node_5414,prsc:2,spu:0,spv:1|UVIN-986-UVOUT,DIST-460-OUT;n:type:ShaderForge.SFN_Tex2dAsset,id:3257,x:32701,y:33498,ptovrint:False,ptlb:Normal Map,ptin:_NormalMap,varname:node_3257,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:e8a5cf6b34635cc49aedfdf40048f728,ntxv:3,isnm:True;n:type:ShaderForge.SFN_Tex2d,id:7637,x:33228,y:33357,varname:node_7637,prsc:2,tex:e8a5cf6b34635cc49aedfdf40048f728,ntxv:0,isnm:False|UVIN-3751-UVOUT,TEX-3257-TEX;n:type:ShaderForge.SFN_Tex2d,id:8301,x:33213,y:33652,varname:node_8301,prsc:2,tex:e8a5cf6b34635cc49aedfdf40048f728,ntxv:0,isnm:False|UVIN-5414-UVOUT,TEX-3257-TEX;n:type:ShaderForge.SFN_Blend,id:257,x:33541,y:33518,varname:node_257,prsc:2,blmd:5,clmp:True|SRC-7637-RGB,DST-8301-RGB;n:type:ShaderForge.SFN_ComponentMask,id:5872,x:33819,y:33350,varname:node_5872,prsc:2,cc1:2,cc2:-1,cc3:-1,cc4:-1|IN-257-OUT;n:type:ShaderForge.SFN_ComponentMask,id:5724,x:35258,y:33140,varname:node_5724,prsc:2,cc1:0,cc2:1,cc3:-1,cc4:-1|IN-257-OUT;n:type:ShaderForge.SFN_Slider,id:968,x:35164,y:33325,ptovrint:False,ptlb:Refraction Intensity,ptin:_RefractionIntensity,varname:node_968,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0,max:1;n:type:ShaderForge.SFN_Relay,id:3224,x:35288,y:33494,varname:node_3224,prsc:2|IN-3322-OUT;n:type:ShaderForge.SFN_Multiply,id:2643,x:35727,y:33133,varname:node_2643,prsc:2|A-5724-OUT,B-968-OUT,C-3224-OUT;n:type:ShaderForge.SFN_Relay,id:1308,x:36678,y:32005,varname:node_1308,prsc:2|IN-2643-OUT;n:type:ShaderForge.SFN_ValueProperty,id:2321,x:31015,y:29919,ptovrint:False,ptlb:recap Scroll Speed1,ptin:_recapScrollSpeed1,varname:node_2321,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0;n:type:ShaderForge.SFN_ValueProperty,id:8666,x:30928,y:30024,ptovrint:False,ptlb:recap Scroll Speed,ptin:_recapScrollSpeed,varname:node_8666,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0;n:type:ShaderForge.SFN_Append,id:7652,x:31256,y:29964,varname:node_7652,prsc:2|A-2321-OUT,B-8666-OUT;n:type:ShaderForge.SFN_Multiply,id:1500,x:31486,y:29974,varname:node_1500,prsc:2|A-7652-OUT,B-451-OUT;n:type:ShaderForge.SFN_Tex2dAsset,id:3958,x:31748,y:30278,ptovrint:False,ptlb:Whitecap,ptin:_Whitecap,varname:node_3958,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,ntxv:0,isnm:False;n:type:ShaderForge.SFN_TexCoord,id:5452,x:31313,y:30642,varname:node_5452,prsc:2,uv:0,uaff:False;n:type:ShaderForge.SFN_Add,id:3730,x:31932,y:30528,varname:node_3730,prsc:2|A-5452-UVOUT,B-1500-OUT;n:type:ShaderForge.SFN_FragmentPosition,id:637,x:30972,y:30927,varname:node_637,prsc:2;n:type:ShaderForge.SFN_ViewPosition,id:1167,x:30972,y:31104,varname:node_1167,prsc:2;n:type:ShaderForge.SFN_Distance,id:5113,x:31212,y:30985,varname:node_5113,prsc:2|A-637-XYZ,B-1167-XYZ;n:type:ShaderForge.SFN_Subtract,id:1716,x:31419,y:30985,varname:node_1716,prsc:2|A-5113-OUT,B-8594-OUT;n:type:ShaderForge.SFN_ValueProperty,id:8594,x:31220,y:31153,ptovrint:False,ptlb:Transition Distance,ptin:_TransitionDistance,varname:node_8594,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:100;n:type:ShaderForge.SFN_ValueProperty,id:3667,x:31432,y:31168,ptovrint:False,ptlb:Transition fa,ptin:_Transitionfa,varname:node_3667,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0;n:type:ShaderForge.SFN_Divide,id:8942,x:31644,y:30985,varname:node_8942,prsc:2|A-1716-OUT,B-3667-OUT;n:type:ShaderForge.SFN_Clamp01,id:7873,x:31927,y:30985,varname:node_7873,prsc:2|IN-8942-OUT;n:type:ShaderForge.SFN_Multiply,id:4174,x:32147,y:30712,varname:node_4174,prsc:2|A-3730-OUT,B-7665-OUT;n:type:ShaderForge.SFN_Vector1,id:7665,x:31837,y:30840,varname:node_7665,prsc:2,v1:0;n:type:ShaderForge.SFN_Tex2d,id:3340,x:32341,y:30290,varname:node_3340,prsc:2,ntxv:0,isnm:False|TEX-3958-TEX;n:type:ShaderForge.SFN_Tex2d,id:6980,x:32341,y:30505,varname:node_6980,prsc:2,ntxv:0,isnm:False|UVIN-4174-OUT,TEX-3958-TEX;n:type:ShaderForge.SFN_Lerp,id:2409,x:32675,y:30289,varname:node_2409,prsc:2|A-3340-RGB,B-6980-RGB,T-7873-OUT;n:type:ShaderForge.SFN_Lerp,id:8676,x:32669,y:30487,varname:node_8676,prsc:2|A-3340-A,B-6980-A,T-7873-OUT;n:type:ShaderForge.SFN_Color,id:2709,x:32522,y:29907,ptovrint:False,ptlb:Color,ptin:_Color,varname:node_2709,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0.5,c2:0.5,c3:0.5,c4:1;n:type:ShaderForge.SFN_Color,id:4748,x:32522,y:30077,ptovrint:False,ptlb:Lightened color,ptin:_Lightenedcolor,varname:node_4748,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0.5,c2:0.5,c3:0.5,c4:1;n:type:ShaderForge.SFN_Lerp,id:7446,x:32888,y:29993,varname:node_7446,prsc:2|A-2709-RGB,B-4748-RGB,T-4699-OUT;n:type:ShaderForge.SFN_ViewVector,id:957,x:32663,y:30715,varname:node_957,prsc:2;n:type:ShaderForge.SFN_NormalVector,id:6836,x:32663,y:30894,prsc:2,pt:False;n:type:ShaderForge.SFN_Dot,id:3410,x:32960,y:30807,varname:node_3410,prsc:2,dt:3|A-957-OUT,B-6836-OUT;n:type:ShaderForge.SFN_Multiply,id:4190,x:33110,y:30476,varname:node_4190,prsc:2|A-8676-OUT,B-1038-OUT;n:type:ShaderForge.SFN_Slider,id:5634,x:32768,y:31069,ptovrint:False,ptlb:Reflection Tint,ptin:_ReflectionTint,varname:node_5634,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0,max:1;n:type:ShaderForge.SFN_Multiply,id:9416,x:33253,y:30777,varname:node_9416,prsc:2|A-3410-OUT,B-5634-OUT;n:type:ShaderForge.SFN_Vector3,id:195,x:33253,y:30914,varname:node_195,prsc:2,v1:1,v2:1,v3:1;n:type:ShaderForge.SFN_Power,id:1038,x:32938,y:31213,varname:node_1038,prsc:2|VAL-4699-OUT,EXP-519-OUT;n:type:ShaderForge.SFN_Slider,id:519,x:32384,y:31230,ptovrint:False,ptlb:white cap power,ptin:_whitecappower,varname:node_519,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0.5,max:6;n:type:ShaderForge.SFN_Lerp,id:7145,x:33615,y:30752,varname:node_7145,prsc:2|A-7446-OUT,B-195-OUT,T-9416-OUT;n:type:ShaderForge.SFN_ScreenPos,id:6732,x:33615,y:30935,varname:node_6732,prsc:2,sctp:2;n:type:ShaderForge.SFN_Add,id:8780,x:34010,y:30941,varname:node_8780,prsc:2|A-6732-UVOUT,B-3329-OUT;n:type:ShaderForge.SFN_Tex2d,id:1817,x:34215,y:30941,ptovrint:False,ptlb:Reflection Text,ptin:_ReflectionText,varname:node_1817,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:338e46ae7380024438adef6a56590dce,ntxv:1,isnm:False|UVIN-8780-OUT;n:type:ShaderForge.SFN_Multiply,id:3329,x:33810,y:31166,varname:node_3329,prsc:2|A-6879-OUT,B-3291-OUT;n:type:ShaderForge.SFN_ComponentMask,id:6879,x:33595,y:31166,varname:node_6879,prsc:2,cc1:0,cc2:1,cc3:-1,cc4:-1|IN-6187-OUT;n:type:ShaderForge.SFN_Slider,id:3291,x:33406,y:31335,ptovrint:False,ptlb:Reflection Distortion Intensity,ptin:_ReflectionDistortionIntensity,varname:node_3291,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0,max:1;n:type:ShaderForge.SFN_Relay,id:6187,x:33869,y:32074,varname:node_6187,prsc:2|IN-257-OUT;n:type:ShaderForge.SFN_Multiply,id:4241,x:34445,y:30877,varname:node_4241,prsc:2|A-7145-OUT,B-1817-RGB;n:type:ShaderForge.SFN_Lerp,id:5536,x:34806,y:30773,varname:node_5536,prsc:2|A-4241-OUT,B-7446-OUT,T-1441-OUT;n:type:ShaderForge.SFN_Lerp,id:6858,x:35152,y:30649,varname:node_6858,prsc:2|A-5536-OUT,B-2409-OUT,T-8676-OUT;n:type:ShaderForge.SFN_Slider,id:4054,x:33679,y:30109,ptovrint:False,ptlb:Reflection Min,ptin:_ReflectionMin,varname:node_4054,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0.25,max:1;n:type:ShaderForge.SFN_Slider,id:4092,x:33679,y:30286,ptovrint:False,ptlb:Reflection Max,ptin:_ReflectionMax,varname:node_4092,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0.75,max:1;n:type:ShaderForge.SFN_OneMinus,id:9799,x:34267,y:30107,varname:node_9799,prsc:2|IN-4054-OUT;n:type:ShaderForge.SFN_OneMinus,id:9210,x:34271,y:30294,varname:node_9210,prsc:2|IN-4092-OUT;n:type:ShaderForge.SFN_Vector1,id:379,x:34539,y:30009,varname:node_379,prsc:2,v1:1;n:type:ShaderForge.SFN_Vector1,id:3376,x:34539,y:30082,varname:node_3376,prsc:2,v1:0;n:type:ShaderForge.SFN_RemapRangeAdvanced,id:1441,x:34890,y:30228,varname:node_1441,prsc:2|IN-3410-OUT,IMIN-3376-OUT,IMAX-379-OUT,OMIN-9210-OUT,OMAX-9799-OUT;n:type:ShaderForge.SFN_Relay,id:386,x:34837,y:30998,varname:node_386,prsc:2|IN-4190-OUT;n:type:ShaderForge.SFN_Vector1,id:8170,x:36678,y:31760,varname:node_8170,prsc:2,v1:0;n:type:ShaderForge.SFN_Clamp01,id:63,x:36470,y:31726,varname:node_63,prsc:2|IN-3527-OUT;n:type:ShaderForge.SFN_Subtract,id:3527,x:36243,y:31702,varname:node_3527,prsc:2|A-2556-OUT,B-386-OUT;n:type:ShaderForge.SFN_Slider,id:2556,x:35880,y:31685,ptovrint:False,ptlb:Gloss,ptin:_Gloss,varname:node_2556,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0.9,max:1;n:type:ShaderForge.SFN_Multiply,id:5052,x:31663,y:31507,varname:node_5052,prsc:2|A-9474-OUT,B-8542-OUT;n:type:ShaderForge.SFN_Relay,id:9474,x:31244,y:31505,varname:node_9474,prsc:2|IN-8902-OUT;n:type:ShaderForge.SFN_Vector1,id:8542,x:31195,y:31679,varname:node_8542,prsc:2,v1:0;n:type:ShaderForge.SFN_Negate,id:2422,x:31663,y:31749,varname:node_2422,prsc:2|IN-5052-OUT;n:type:ShaderForge.SFN_RemapRangeAdvanced,id:1532,x:32065,y:31682,varname:node_1532,prsc:2|IN-659-OUT,IMIN-2422-OUT,IMAX-5052-OUT,OMIN-6226-OUT,OMAX-6581-OUT;n:type:ShaderForge.SFN_Divide,id:659,x:31654,y:31958,varname:node_659,prsc:2|A-7894-OUT,B-4410-OUT;n:type:ShaderForge.SFN_Add,id:7894,x:31304,y:31899,varname:node_7894,prsc:2|A-4864-OUT,B-5900-OUT,C-1573-OUT;n:type:ShaderForge.SFN_Vector1,id:4410,x:31383,y:32108,varname:node_4410,prsc:2,v1:0;n:type:ShaderForge.SFN_Vector1,id:6226,x:31842,y:31793,varname:node_6226,prsc:2,v1:0;n:type:ShaderForge.SFN_Vector1,id:6581,x:31842,y:31856,varname:node_6581,prsc:2,v1:0;n:type:ShaderForge.SFN_ComponentMask,id:4699,x:32367,y:31578,varname:node_4699,prsc:2,cc1:1,cc2:-1,cc3:-1,cc4:-1|IN-1532-OUT;n:type:ShaderForge.SFN_Vector1,id:8450,x:32257,y:32025,varname:node_8450,prsc:2,v1:0;n:type:ShaderForge.SFN_Vector1,id:2951,x:32257,y:32111,varname:node_2951,prsc:2,v1:1;n:type:ShaderForge.SFN_ValueProperty,id:7631,x:32257,y:32210,ptovrint:False,ptlb:Tesselation min,ptin:_Tesselationmin,varname:node_7631,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:2;n:type:ShaderForge.SFN_ValueProperty,id:6666,x:32257,y:32297,ptovrint:False,ptlb:Tesselation max,ptin:_Tesselationmax,varname:node_6666,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:5;n:type:ShaderForge.SFN_Distance,id:5241,x:32257,y:32390,varname:node_5241,prsc:2|A-5627-XYZ,B-3829-XYZ;n:type:ShaderForge.SFN_ValueProperty,id:7996,x:32257,y:32559,ptovrint:False,ptlb:Tesselation amp,ptin:_Tesselationamp,varname:node_7996,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:2;n:type:ShaderForge.SFN_ValueProperty,id:9379,x:32257,y:32646,ptovrint:False,ptlb:Tesselation Curve,ptin:_TesselationCurve,varname:node_9379,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:50;n:type:ShaderForge.SFN_FragmentPosition,id:5627,x:32011,y:32390,varname:node_5627,prsc:2;n:type:ShaderForge.SFN_ViewPosition,id:3829,x:32021,y:32559,varname:node_3829,prsc:2;n:type:ShaderForge.SFN_RemapRangeAdvanced,id:999,x:32931,y:32088,varname:node_999,prsc:2|IN-4699-OUT,IMIN-8450-OUT,IMAX-2951-OUT,OMIN-7631-OUT,OMAX-6666-OUT;n:type:ShaderForge.SFN_If,id:3209,x:33257,y:32359,varname:node_3209,prsc:2|A-5241-OUT,B-9379-OUT,GT-7996-OUT,EQ-7996-OUT,LT-999-OUT;n:type:ShaderForge.SFN_Add,id:7583,x:35551,y:30568,varname:node_7583,prsc:2|A-6858-OUT,B-4741-OUT;n:type:ShaderForge.SFN_ValueProperty,id:2257,x:36701,y:31864,ptovrint:False,ptlb:node_2257,ptin:_node_2257,varname:node_2257,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:1;proporder:8552-9176-1223-2323-6831-2541-4551-5092-9679-1918-1080-7039-2724-5827-1946-2886-8309-500-6966-4587-7087-5733-9252-7010-4098-3257-968-2321-8666-3958-8594-3667-519-2556-2916-5179-919-472-5149-6202-6726-7148-4239-3465-7631-6666-7996-9379-2709-4748-5634-1817-3291-4054-4092-2257;pass:END;sub:END;*/

Shader "Custom/RealWater" {
    Properties {
        _Swayfrequency ("Sway frequency", Float ) = 1
        _SwayIntensity ("Sway Intensity", Range(0, 1)) = 0.5
        _FlowMovementHorizontal ("Flow Movement Horizontal", Range(0, 1)) = 0
        _FlowMovementVertical ("Flow Movement Vertical", Range(0, 1)) = 0
        [MaterialToggle] _Flowwithobject ("Flow with object", Float ) = 1
        _FlowMap ("FlowMap", 2D) = "white" {}
        _FlowPower ("Flow Power", Float ) = 0.5
        _FlowSpeed ("Flow Speed", Float ) = 1
        _NormalTilingDiffer ("Normal Tiling Differ", Float ) = 1.4
        _FoamTimeSpeed ("Foam Time Speed", Range(0, 1)) = 0
        _FoamHorizontalSpeed ("Foam Horizontal Speed", Float ) = 0
        _Foam ("Foam", 2D) = "white" {}
        _FoamVerticalspeed ("Foam Vertical speed", Float ) = 0
        _FoamFalloff ("Foam Falloff", Float ) = 0
        _Depth ("Depth", Float ) = 0
        _FoamSpread ("Foam Spread", Range(0, 1)) = 0
        _OpacityMinimum ("Opacity Minimum", Range(0, 1)) = 0
        _EdgeLineWidth ("Edge-Line Width", Float ) = 0
        _FoamOutlineFall ("Foam Outline Fall", Float ) = 1
        _FoamIntensity ("Foam Intensity", Range(0, 2)) = 1
        _NormalScrollSpeed ("Normal Scroll Speed", Float ) = 0.2
        _Normal1HorizontalSpeed ("Normal 1 Horizontal Speed", Range(-1, 1)) = 0
        _Normal1VerticalSpeed ("Normal 1 Vertical Speed", Range(-1, 1)) = 0
        _Normal2HorizontalSpeed ("Normal 2 Horizontal Speed", Range(-1, 1)) = 0
        _Normal2VerticalSpeed ("Normal 2 Vertical Speed", Range(-1, 1)) = 0
        _NormalMap ("Normal Map", 2D) = "bump" {}
        _RefractionIntensity ("Refraction Intensity", Range(0, 1)) = 0
        _recapScrollSpeed1 ("recap Scroll Speed1", Float ) = 0
        _recapScrollSpeed ("recap Scroll Speed", Float ) = 0
        _Whitecap ("Whitecap", 2D) = "white" {}
        _TransitionDistance ("Transition Distance", Float ) = 100
        _Transitionfa ("Transition fa", Float ) = 0
        _whitecappower ("white cap power", Range(0, 6)) = 0.5
        _Gloss ("Gloss", Range(0, 1)) = 0.9
        _Wave3ZDirection ("Wave 3 Z - Direction", Range(-1, 1)) = 0
        _Wave3XDirection ("Wave 3 X - Direction", Range(-1, 1)) = 0
        _Wave3XDirection_copy ("Wave 3 X - Direction_copy", Range(-1, 1)) = 0
        _Wave2 ("Wave 2 - ", Range(-1, 1)) = 0
        _Wave1ZDirection ("Wave 1 Z - Direction", Range(-1, 1)) = 0
        _Wave1XDirection ("Wave 1 X - Direction", Range(-1, 1)) = 0
        _WaveSharpness ("Wave Sharpness", Float ) = 1
        _WaveHeight ("Wave Height", Float ) = 1
        _WaveSpread ("Wave Spread", Float ) = 1
        _WaveSpeed ("Wave Speed", Float ) = 1
        _Tesselationmin ("Tesselation min", Float ) = 2
        _Tesselationmax ("Tesselation max", Float ) = 5
        _Tesselationamp ("Tesselation amp", Float ) = 2
        _TesselationCurve ("Tesselation Curve", Float ) = 50
        _Color ("Color", Color) = (0.5,0.5,0.5,1)
        _Lightenedcolor ("Lightened color", Color) = (0.5,0.5,0.5,1)
        _ReflectionTint ("Reflection Tint", Range(0, 1)) = 0
        _ReflectionText ("Reflection Text", 2D) = "gray" {}
        _ReflectionDistortionIntensity ("Reflection Distortion Intensity", Range(0, 1)) = 0
        _ReflectionMin ("Reflection Min", Range(0, 1)) = 0.25
        _ReflectionMax ("Reflection Max", Range(0, 1)) = 0.75
        _node_2257 ("node_2257", Float ) = 1
        [HideInInspector]_Cutoff ("Alpha cutoff", Range(0,1)) = 0.5
    }
    SubShader {
        Tags {
            "IgnoreProjector"="True"
            "Queue"="Transparent"
            "RenderType"="Transparent"
        }
        LOD 200
        GrabPass{ }
        Pass {
            Name "FORWARD"
            Tags {
                "LightMode"="ForwardBase"
            }
            Blend SrcAlpha OneMinusSrcAlpha
            ZWrite Off
            
            CGPROGRAM
            #pragma hull hull
            #pragma domain domain
            #pragma vertex tessvert
            #pragma fragment frag
            #define UNITY_PASS_FORWARDBASE
            #include "UnityCG.cginc"
            #include "Tessellation.cginc"
            #include "UnityPBSLighting.cginc"
            #include "UnityStandardBRDF.cginc"
            #pragma multi_compile_fwdbase
            #pragma multi_compile_fog
            #pragma only_renderers d3d9 d3d11 glcore gles 
            #pragma target 5.0
            uniform sampler2D _GrabTexture;
            uniform sampler2D _CameraDepthTexture;
            uniform float _Swayfrequency;
            uniform float _SwayIntensity;
            uniform float _FlowMovementHorizontal;
            uniform float _FlowMovementVertical;
            uniform fixed _Flowwithobject;
            uniform sampler2D _FlowMap; uniform float4 _FlowMap_ST;
            uniform float _FlowPower;
            uniform float _FlowSpeed;
            uniform float _NormalTilingDiffer;
            float3 Gerstner2( float Steepness , float Amplitude , float Wavelength , float Speed , float Time , float DotProd ){
            float phaseCont = Speed * Wavelength;
            float xVal = Steepness * Amplitude * DirectionVec.x * cos(Wavelength * DotProd + Time * phaseCont);
            float yVal = Amplitude * sin(Wavelength * DotProd + Time * phaseConst);
            float zVal = Steepness * Amplitude * DirectionVec.y * cos(Wavelength * DotProd + phaseConst);
            return float3(xVal, yVal, zVal);
            }
            
            float3 Gerstner3( float Steepness , float Amplitude , float Wavelength , float Speed , float Time , float DotProd ){
            float phaseCont = Speed * Wavelength;
            float xVal = Steepness * Amplitude * DirectionVec.x * cos(Wavelength * DotProd + Time * phaseCont);
            float yVal = Amplitude * sin(Wavelength * DotProd + Time * phaseConst);
            float zVal = Steepness * Amplitude * DirectionVec.y * cos(Wavelength * DotProd + phaseConst);
            return float3(xVal, yVal, zVal);
            }
            
            float3 Gerstner1( float Steepness , float Amplitude , float Wavelength , float Speed , float Time , float DotProd ){
            float phaseCont = Speed * Wavelength;
            float xVal = Steepness * Amplitude * DirectionVec.x * cos(Wavelength * DotProd + Time * phaseCont);
            float yVal = Amplitude * sin(Wavelength * DotProd + Time * phaseConst);
            float zVal = Steepness * Amplitude * DirectionVec.y * cos(Wavelength * DotProd + phaseConst);
            return float3(xVal, yVal, zVal);
            }
            
            uniform float _Wave3ZDirection;
            uniform float _Wave3XDirection;
            uniform float _Wave3XDirection_copy;
            uniform float _Wave2;
            uniform float _Wave1ZDirection;
            uniform float _Wave1XDirection;
            uniform float _WaveSharpness;
            uniform float _WaveHeight;
            uniform float _WaveSpread;
            uniform float _WaveSpeed;
            uniform float _FoamTimeSpeed;
            uniform float _FoamHorizontalSpeed;
            uniform sampler2D _Foam; uniform float4 _Foam_ST;
            uniform float _FoamVerticalspeed;
            uniform float _FoamFalloff;
            uniform float _Depth;
            uniform float _FoamSpread;
            uniform float _OpacityMinimum;
            uniform float _EdgeLineWidth;
            uniform float _FoamOutlineFall;
            uniform float _FoamIntensity;
            uniform float _NormalScrollSpeed;
            uniform float _Normal1HorizontalSpeed;
            uniform float _Normal1VerticalSpeed;
            uniform float _Normal2HorizontalSpeed;
            uniform float _Normal2VerticalSpeed;
            uniform sampler2D _NormalMap; uniform float4 _NormalMap_ST;
            uniform float _RefractionIntensity;
            uniform float _recapScrollSpeed1;
            uniform float _recapScrollSpeed;
            uniform sampler2D _Whitecap; uniform float4 _Whitecap_ST;
            uniform float _TransitionDistance;
            uniform float _Transitionfa;
            uniform float4 _Color;
            uniform float4 _Lightenedcolor;
            uniform float _ReflectionTint;
            uniform float _whitecappower;
            uniform sampler2D _ReflectionText; uniform float4 _ReflectionText_ST;
            uniform float _ReflectionDistortionIntensity;
            uniform float _ReflectionMin;
            uniform float _ReflectionMax;
            uniform float _Gloss;
            uniform float _Tesselationmin;
            uniform float _Tesselationmax;
            uniform float _Tesselationamp;
            uniform float _TesselationCurve;
            uniform float _node_2257;
            struct VertexInput {
                float4 vertex : POSITION;
                float3 normal : NORMAL;
                float4 tangent : TANGENT;
                float2 texcoord0 : TEXCOORD0;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float2 uv0 : TEXCOORD0;
                float4 posWorld : TEXCOORD1;
                float3 normalDir : TEXCOORD2;
                float3 tangentDir : TEXCOORD3;
                float3 bitangentDir : TEXCOORD4;
                float4 projPos : TEXCOORD5;
                UNITY_FOG_COORDS(6)
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                o.normalDir = UnityObjectToWorldNormal(v.normal);
                o.tangentDir = normalize( mul( unity_ObjectToWorld, float4( v.tangent.xyz, 0.0 ) ).xyz );
                o.bitangentDir = normalize(cross(o.normalDir, o.tangentDir) * v.tangent.w);
                float3 recipObjScale = float3( length(unity_WorldToObject[0].xyz), length(unity_WorldToObject[1].xyz), length(unity_WorldToObject[2].xyz) );
                float3 objScale = 1.0/recipObjScale;
                o.posWorld = mul(unity_ObjectToWorld, v.vertex);
                float3 lightColor = _LightColor0.rgb;
                o.pos = UnityObjectToClipPos( v.vertex );
                UNITY_TRANSFER_FOG(o,o.pos);
                o.projPos = ComputeScreenPos (o.pos);
                COMPUTE_EYEDEPTH(o.projPos.z);
                return o;
            }
            #ifdef UNITY_CAN_COMPILE_TESSELLATION
                struct TessVertex {
                    float4 vertex : INTERNALTESSPOS;
                    float3 normal : NORMAL;
                    float4 tangent : TANGENT;
                    float2 texcoord0 : TEXCOORD0;
                };
                struct OutputPatchConstant {
                    float edge[3]         : SV_TessFactor;
                    float inside          : SV_InsideTessFactor;
                    float3 vTangent[4]    : TANGENT;
                    float2 vUV[4]         : TEXCOORD;
                    float3 vTanUCorner[4] : TANUCORNER;
                    float3 vTanVCorner[4] : TANVCORNER;
                    float4 vCWts          : TANWEIGHTS;
                };
                TessVertex tessvert (VertexInput v) {
                    TessVertex o;
                    o.vertex = v.vertex;
                    o.normal = v.normal;
                    o.tangent = v.tangent;
                    o.texcoord0 = v.texcoord0;
                    return o;
                }
                void displacement (inout VertexInput v){
                    float4 node_799 = _Time;
                    float node_4709 = ((_SwayIntensity*sin((_Swayfrequency*6.28318530718)))+node_799.g);
                    float node_8004 = node_4709;
                    float2 node_1622 = mul(unity_ObjectToWorld, v.vertex).rgb.rb;
                    float3 node_659 = ((Gerstner1( _WaveSharpness , _WaveHeight , _WaveSpread , _WaveSpeed , node_8004 , dot(float2(_Wave1XDirection,_Wave1ZDirection),node_1622) )+Gerstner2( _WaveSharpness , _WaveHeight , _WaveSpread , _WaveSpeed , (node_8004+2.0) , dot(float2(_Wave2,_Wave3XDirection_copy),node_1622) )+Gerstner3( _WaveSharpness , _WaveHeight , _WaveSpread , _WaveSpeed , (node_8004+4.0) , dot(float2(_Wave3XDirection,_Wave3ZDirection),node_1622) ))/0.0);
                    v.vertex.xyz += node_659;
                }
                float Tessellation(TessVertex v){
                    float node_3209_if_leA = step(distance(mul(unity_ObjectToWorld, v.vertex).rgb,_WorldSpaceCameraPos),_TesselationCurve);
                    float node_3209_if_leB = step(_TesselationCurve,distance(mul(unity_ObjectToWorld, v.vertex).rgb,_WorldSpaceCameraPos));
                    float4 node_799 = _Time;
                    float node_4709 = ((_SwayIntensity*sin((_Swayfrequency*6.28318530718)))+node_799.g);
                    float node_8004 = node_4709;
                    float2 node_1622 = mul(unity_ObjectToWorld, v.vertex).rgb.rb;
                    float3 node_659 = ((Gerstner1( _WaveSharpness , _WaveHeight , _WaveSpread , _WaveSpeed , node_8004 , dot(float2(_Wave1XDirection,_Wave1ZDirection),node_1622) )+Gerstner2( _WaveSharpness , _WaveHeight , _WaveSpread , _WaveSpeed , (node_8004+2.0) , dot(float2(_Wave2,_Wave3XDirection_copy),node_1622) )+Gerstner3( _WaveSharpness , _WaveHeight , _WaveSpread , _WaveSpeed , (node_8004+4.0) , dot(float2(_Wave3XDirection,_Wave3ZDirection),node_1622) ))/0.0);
                    float node_5052 = (_WaveHeight*0.0);
                    float node_2422 = (-1*node_5052);
                    float node_6226 = 0.0;
                    float node_4699 = (node_6226 + ( (node_659 - node_2422) * (0.0 - node_6226) ) / (node_5052 - node_2422)).g;
                    float node_8450 = 0.0;
                    return lerp((node_3209_if_leA*(_Tesselationmin + ( (node_4699 - node_8450) * (_Tesselationmax - _Tesselationmin) ) / (1.0 - node_8450)))+(node_3209_if_leB*_Tesselationamp),_Tesselationamp,node_3209_if_leA*node_3209_if_leB);
                }
                float4 Tessellation(TessVertex v, TessVertex v1, TessVertex v2){
                    float tv = Tessellation(v);
                    float tv1 = Tessellation(v1);
                    float tv2 = Tessellation(v2);
                    return float4( tv1+tv2, tv2+tv, tv+tv1, tv+tv1+tv2 ) / float4(2,2,2,3);
                }
                OutputPatchConstant hullconst (InputPatch<TessVertex,3> v) {
                    OutputPatchConstant o = (OutputPatchConstant)0;
                    float4 ts = Tessellation( v[0], v[1], v[2] );
                    o.edge[0] = ts.x;
                    o.edge[1] = ts.y;
                    o.edge[2] = ts.z;
                    o.inside = ts.w;
                    return o;
                }
                [domain("tri")]
                [partitioning("fractional_odd")]
                [outputtopology("triangle_cw")]
                [patchconstantfunc("hullconst")]
                [outputcontrolpoints(3)]
                TessVertex hull (InputPatch<TessVertex,3> v, uint id : SV_OutputControlPointID) {
                    return v[id];
                }
                [domain("tri")]
                VertexOutput domain (OutputPatchConstant tessFactors, const OutputPatch<TessVertex,3> vi, float3 bary : SV_DomainLocation) {
                    VertexInput v = (VertexInput)0;
                    v.vertex = vi[0].vertex*bary.x + vi[1].vertex*bary.y + vi[2].vertex*bary.z;
                    v.normal = vi[0].normal*bary.x + vi[1].normal*bary.y + vi[2].normal*bary.z;
                    v.tangent = vi[0].tangent*bary.x + vi[1].tangent*bary.y + vi[2].tangent*bary.z;
                    v.texcoord0 = vi[0].texcoord0*bary.x + vi[1].texcoord0*bary.y + vi[2].texcoord0*bary.z;
                    displacement(v);
                    VertexOutput o = vert(v);
                    return o;
                }
            #endif
            float4 frag(VertexOutput i) : COLOR {
                float3 recipObjScale = float3( length(unity_WorldToObject[0].xyz), length(unity_WorldToObject[1].xyz), length(unity_WorldToObject[2].xyz) );
                float3 objScale = 1.0/recipObjScale;
                i.normalDir = normalize(i.normalDir);
                float3x3 tangentTransform = float3x3( i.tangentDir, i.bitangentDir, i.normalDir);
                float3 viewDirection = normalize(_WorldSpaceCameraPos.xyz - i.posWorld.xyz);
                float4 node_799 = _Time;
                float node_4709 = ((_SwayIntensity*sin((_Swayfrequency*6.28318530718)))+node_799.g);
                float node_1019 = (node_4709*_NormalScrollSpeed);
                float2 node_8235 = (float2(objScale.r,objScale.b)*i.uv0);
                float2 node_8667 = (((i.uv0*lerp( 1.0, float2(objScale.r,objScale.b), _Flowwithobject ))+(node_4709*_FlowMovementVertical)*float2(1,1))+(node_4709*_FlowMovementHorizontal)*float2(1,1));
                float4 _FlowMap_var = tex2D(_FlowMap,TRANSFORM_TEX(node_8667, _FlowMap));
                float node_3089 = ((_FlowMap_var.rgb.rg*2.0+-1.0)*_FlowPower*1.0);
                float node_9504 = (node_4709*_FlowSpeed);
                float node_9024 = frac(node_9504);
                float node_3633 = 0.5;
                float2 node_5766 = lerp((node_8235+(node_3089*node_9024)),(node_8235+(node_3089*frac((node_9504+0.5)))),abs(((node_3633-node_9024)/node_3633)));
                float2 node_602 = (node_5766*_NormalTilingDiffer);
                float2 node_3751 = ((node_602+(_Normal1VerticalSpeed*node_1019)*float2(1,1))+(node_1019*_Normal1HorizontalSpeed)*float2(1,1));
                float3 node_7637 = UnpackNormal(tex2D(_NormalMap,TRANSFORM_TEX(node_3751, _NormalMap)));
                float2 node_5414 = ((node_5766+(_Normal2VerticalSpeed*node_1019)*float2(1,0))+(node_1019*_Normal2HorizontalSpeed)*float2(0,1));
                float3 node_8301 = UnpackNormal(tex2D(_NormalMap,TRANSFORM_TEX(node_5414, _NormalMap)));
                float3 node_257 = saturate(max(node_7637.rgb,node_8301.rgb));
                float3 normalLocal = node_257;
                float3 normalDirection = normalize(mul( normalLocal, tangentTransform )); // Perturbed normals
                float3 viewReflectDirection = reflect( -viewDirection, normalDirection );
                float sceneZ = max(0,LinearEyeDepth (UNITY_SAMPLE_DEPTH(tex2Dproj(_CameraDepthTexture, UNITY_PROJ_COORD(i.projPos)))) - _ProjectionParams.g);
                float partZ = max(0,i.projPos.z - _ProjectionParams.g);
                float node_3322 = saturate((sceneZ-partZ)/_Depth);
                float2 sceneUVs = (i.projPos.xy / i.projPos.w) + (node_257.rg*_RefractionIntensity*node_3322);
                float4 sceneColor = tex2D(_GrabTexture, sceneUVs);
                float3 lightDirection = normalize(_WorldSpaceLightPos0.xyz);
                float3 lightColor = _LightColor0.rgb;
                float3 halfDirection = normalize(viewDirection+lightDirection);
////// Lighting:
                float attenuation = 1;
                float3 attenColor = attenuation * _LightColor0.xyz;
                float Pi = 3.141592654;
                float InvPi = 0.31830988618;
///////// Gloss:
                float4 node_3340 = tex2D(_Whitecap,TRANSFORM_TEX(i.uv0, _Whitecap));
                float node_8004 = node_4709;
                float2 node_4174 = ((i.uv0+(float2(_recapScrollSpeed1,_recapScrollSpeed)*node_8004))*0.0);
                float4 node_6980 = tex2D(_Whitecap,TRANSFORM_TEX(node_4174, _Whitecap));
                float node_7873 = saturate(((distance(i.posWorld.rgb,_WorldSpaceCameraPos)-_TransitionDistance)/_Transitionfa));
                float node_8676 = lerp(node_3340.a,node_6980.a,node_7873);
                float2 node_1622 = i.posWorld.rgb.rb;
                float3 node_659 = ((Gerstner1( _WaveSharpness , _WaveHeight , _WaveSpread , _WaveSpeed , node_8004 , dot(float2(_Wave1XDirection,_Wave1ZDirection),node_1622) )+Gerstner2( _WaveSharpness , _WaveHeight , _WaveSpread , _WaveSpeed , (node_8004+2.0) , dot(float2(_Wave2,_Wave3XDirection_copy),node_1622) )+Gerstner3( _WaveSharpness , _WaveHeight , _WaveSpread , _WaveSpeed , (node_8004+4.0) , dot(float2(_Wave3XDirection,_Wave3ZDirection),node_1622) ))/0.0);
                float node_5052 = (_WaveHeight*0.0);
                float node_2422 = (-1*node_5052);
                float node_6226 = 0.0;
                float node_4699 = (node_6226 + ( (node_659 - node_2422) * (0.0 - node_6226) ) / (node_5052 - node_2422)).g;
                float gloss = saturate((_Gloss-(node_8676*pow(node_4699,_whitecappower))));
                float perceptualRoughness = 1.0 - saturate((_Gloss-(node_8676*pow(node_4699,_whitecappower))));
                float roughness = perceptualRoughness * perceptualRoughness;
                float specPow = exp2( gloss * 10.0 + 1.0 );
/////// GI Data:
                UnityLight light;
                #ifdef LIGHTMAP_OFF
                    light.color = lightColor;
                    light.dir = lightDirection;
                    light.ndotl = LambertTerm (normalDirection, light.dir);
                #else
                    light.color = half3(0.f, 0.f, 0.f);
                    light.ndotl = 0.0f;
                    light.dir = half3(0.f, 0.f, 0.f);
                #endif
                UnityGIInput d;
                d.light = light;
                d.worldPos = i.posWorld.xyz;
                d.worldViewDir = viewDirection;
                d.atten = attenuation;
                Unity_GlossyEnvironmentData ugls_en_data;
                ugls_en_data.roughness = 1.0 - gloss;
                ugls_en_data.reflUVW = viewReflectDirection;
                UnityGI gi = UnityGlobalIllumination(d, 1, normalDirection, ugls_en_data );
                lightDirection = gi.light.dir;
                lightColor = gi.light.color;
////// Specular:
                float NdotL = saturate(dot( normalDirection, lightDirection ));
                float3 specularAO = node_257.b;
                float LdotH = saturate(dot(lightDirection, halfDirection));
                float3 specularColor = 0.0;
                float specularMonochrome;
                float3 node_7446 = lerp(_Color.rgb,_Lightenedcolor.rgb,node_4699);
                float node_3410 = abs(dot(viewDirection,i.normalDir));
                float2 node_8780 = (sceneUVs.rg+(node_257.rg*_ReflectionDistortionIntensity));
                float4 _ReflectionText_var = tex2D(_ReflectionText,TRANSFORM_TEX(node_8780, _ReflectionText));
                float node_3376 = 0.0;
                float node_9210 = (1.0 - _ReflectionMax);
                float3 node_6858 = lerp(lerp((lerp(node_7446,float3(1,1,1),(node_3410*_ReflectionTint))*_ReflectionText_var.rgb),node_7446,(node_9210 + ( (node_3410 - node_3376) * ((1.0 - _ReflectionMin) - node_9210) ) / (1.0 - node_3376))),lerp(node_3340.rgb,node_6980.rgb,node_7873),node_8676);
                float node_605 = (1.0 - saturate(pow(((1.0 / _FoamSpread)*node_3322),_FoamFalloff)));
                float4 node_5161 = _Time;
                float node_6547 = sin((node_5161.g*_FoamTimeSpeed));
                float2 node_1844 = ((node_602+(node_6547*_FoamHorizontalSpeed)*float2(1,1))+(_FoamVerticalspeed*node_6547)*float2(1,1));
                float4 _Foam_var = tex2D(_Foam,TRANSFORM_TEX(node_1844, _Foam));
                float3 node_4741 = (((node_605*_Foam_var.rgb)+pow((node_605+(_EdgeLineWidth*0.5*(recipObjScale.r+recipObjScale.b))),_FoamOutlineFall))*_FoamIntensity);
                float3 diffuseColor = (node_6858+node_4741); // Need this for specular when using metallic
                diffuseColor = DiffuseAndSpecularFromMetallic( diffuseColor, specularColor, specularColor, specularMonochrome );
                specularMonochrome = 1.0-specularMonochrome;
                float NdotV = abs(dot( normalDirection, viewDirection ));
                float NdotH = saturate(dot( normalDirection, halfDirection ));
                float VdotH = saturate(dot( viewDirection, halfDirection ));
                float visTerm = SmithJointGGXVisibilityTerm( NdotL, NdotV, roughness );
                float normTerm = GGXTerm(NdotH, roughness);
                float specularPBL = (visTerm*normTerm) * UNITY_PI;
                #ifdef UNITY_COLORSPACE_GAMMA
                    specularPBL = sqrt(max(1e-4h, specularPBL));
                #endif
                specularPBL = max(0, specularPBL * NdotL);
                #if defined(_SPECULARHIGHLIGHTS_OFF)
                    specularPBL = 0.0;
                #endif
                half surfaceReduction;
                #ifdef UNITY_COLORSPACE_GAMMA
                    surfaceReduction = 1.0-0.28*roughness*perceptualRoughness;
                #else
                    surfaceReduction = 1.0/(roughness*roughness + 1.0);
                #endif
                specularPBL *= any(specularColor) ? 1.0 : 0.0;
                float3 directSpecular = attenColor*specularPBL*FresnelTerm(specularColor, LdotH);
                half grazingTerm = saturate( gloss + specularMonochrome );
                float3 indirectSpecular = (0 + float3(_node_2257,_node_2257,_node_2257)) * specularAO;
                indirectSpecular *= FresnelLerp (specularColor, grazingTerm, NdotV);
                indirectSpecular *= surfaceReduction;
                float3 specular = (directSpecular + indirectSpecular);
/////// Diffuse:
                NdotL = max(0.0,dot( normalDirection, lightDirection ));
                half fd90 = 0.5 + 2 * LdotH * LdotH * (1-gloss);
                float nlPow5 = Pow5(1-NdotL);
                float nvPow5 = Pow5(1-NdotV);
                float3 directDiffuse = ((1 +(fd90 - 1)*nlPow5) * (1 + (fd90 - 1)*nvPow5) * NdotL) * attenColor;
                float3 indirectDiffuse = float3(0,0,0);
                indirectDiffuse += UNITY_LIGHTMODEL_AMBIENT.rgb; // Ambient Light
                float3 diffuse = (directDiffuse + indirectDiffuse) * diffuseColor;
/// Final Color:
                float3 finalColor = diffuse + specular;
                fixed4 finalRGBA = fixed4(lerp(sceneColor.rgb, finalColor,(node_4741.r+clamp(node_3322,_OpacityMinimum,1.0))),1);
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
            ZWrite Off
            
            CGPROGRAM
            #pragma hull hull
            #pragma domain domain
            #pragma vertex tessvert
            #pragma fragment frag
            #define UNITY_PASS_FORWARDADD
            #include "UnityCG.cginc"
            #include "AutoLight.cginc"
            #include "Tessellation.cginc"
            #include "UnityPBSLighting.cginc"
            #include "UnityStandardBRDF.cginc"
            #pragma multi_compile_fwdadd
            #pragma multi_compile_fog
            #pragma only_renderers d3d9 d3d11 glcore gles 
            #pragma target 5.0
            uniform sampler2D _GrabTexture;
            uniform sampler2D _CameraDepthTexture;
            uniform float _Swayfrequency;
            uniform float _SwayIntensity;
            uniform float _FlowMovementHorizontal;
            uniform float _FlowMovementVertical;
            uniform fixed _Flowwithobject;
            uniform sampler2D _FlowMap; uniform float4 _FlowMap_ST;
            uniform float _FlowPower;
            uniform float _FlowSpeed;
            uniform float _NormalTilingDiffer;
            float3 Gerstner2( float Steepness , float Amplitude , float Wavelength , float Speed , float Time , float DotProd ){
            float phaseCont = Speed * Wavelength;
            float xVal = Steepness * Amplitude * DirectionVec.x * cos(Wavelength * DotProd + Time * phaseCont);
            float yVal = Amplitude * sin(Wavelength * DotProd + Time * phaseConst);
            float zVal = Steepness * Amplitude * DirectionVec.y * cos(Wavelength * DotProd + phaseConst);
            return float3(xVal, yVal, zVal);
            }
            
            float3 Gerstner3( float Steepness , float Amplitude , float Wavelength , float Speed , float Time , float DotProd ){
            float phaseCont = Speed * Wavelength;
            float xVal = Steepness * Amplitude * DirectionVec.x * cos(Wavelength * DotProd + Time * phaseCont);
            float yVal = Amplitude * sin(Wavelength * DotProd + Time * phaseConst);
            float zVal = Steepness * Amplitude * DirectionVec.y * cos(Wavelength * DotProd + phaseConst);
            return float3(xVal, yVal, zVal);
            }
            
            float3 Gerstner1( float Steepness , float Amplitude , float Wavelength , float Speed , float Time , float DotProd ){
            float phaseCont = Speed * Wavelength;
            float xVal = Steepness * Amplitude * DirectionVec.x * cos(Wavelength * DotProd + Time * phaseCont);
            float yVal = Amplitude * sin(Wavelength * DotProd + Time * phaseConst);
            float zVal = Steepness * Amplitude * DirectionVec.y * cos(Wavelength * DotProd + phaseConst);
            return float3(xVal, yVal, zVal);
            }
            
            uniform float _Wave3ZDirection;
            uniform float _Wave3XDirection;
            uniform float _Wave3XDirection_copy;
            uniform float _Wave2;
            uniform float _Wave1ZDirection;
            uniform float _Wave1XDirection;
            uniform float _WaveSharpness;
            uniform float _WaveHeight;
            uniform float _WaveSpread;
            uniform float _WaveSpeed;
            uniform float _FoamTimeSpeed;
            uniform float _FoamHorizontalSpeed;
            uniform sampler2D _Foam; uniform float4 _Foam_ST;
            uniform float _FoamVerticalspeed;
            uniform float _FoamFalloff;
            uniform float _Depth;
            uniform float _FoamSpread;
            uniform float _OpacityMinimum;
            uniform float _EdgeLineWidth;
            uniform float _FoamOutlineFall;
            uniform float _FoamIntensity;
            uniform float _NormalScrollSpeed;
            uniform float _Normal1HorizontalSpeed;
            uniform float _Normal1VerticalSpeed;
            uniform float _Normal2HorizontalSpeed;
            uniform float _Normal2VerticalSpeed;
            uniform sampler2D _NormalMap; uniform float4 _NormalMap_ST;
            uniform float _RefractionIntensity;
            uniform float _recapScrollSpeed1;
            uniform float _recapScrollSpeed;
            uniform sampler2D _Whitecap; uniform float4 _Whitecap_ST;
            uniform float _TransitionDistance;
            uniform float _Transitionfa;
            uniform float4 _Color;
            uniform float4 _Lightenedcolor;
            uniform float _ReflectionTint;
            uniform float _whitecappower;
            uniform sampler2D _ReflectionText; uniform float4 _ReflectionText_ST;
            uniform float _ReflectionDistortionIntensity;
            uniform float _ReflectionMin;
            uniform float _ReflectionMax;
            uniform float _Gloss;
            uniform float _Tesselationmin;
            uniform float _Tesselationmax;
            uniform float _Tesselationamp;
            uniform float _TesselationCurve;
            struct VertexInput {
                float4 vertex : POSITION;
                float3 normal : NORMAL;
                float4 tangent : TANGENT;
                float2 texcoord0 : TEXCOORD0;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float2 uv0 : TEXCOORD0;
                float4 posWorld : TEXCOORD1;
                float3 normalDir : TEXCOORD2;
                float3 tangentDir : TEXCOORD3;
                float3 bitangentDir : TEXCOORD4;
                float4 projPos : TEXCOORD5;
                LIGHTING_COORDS(6,7)
                UNITY_FOG_COORDS(8)
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                o.normalDir = UnityObjectToWorldNormal(v.normal);
                o.tangentDir = normalize( mul( unity_ObjectToWorld, float4( v.tangent.xyz, 0.0 ) ).xyz );
                o.bitangentDir = normalize(cross(o.normalDir, o.tangentDir) * v.tangent.w);
                float3 recipObjScale = float3( length(unity_WorldToObject[0].xyz), length(unity_WorldToObject[1].xyz), length(unity_WorldToObject[2].xyz) );
                float3 objScale = 1.0/recipObjScale;
                o.posWorld = mul(unity_ObjectToWorld, v.vertex);
                float3 lightColor = _LightColor0.rgb;
                o.pos = UnityObjectToClipPos( v.vertex );
                UNITY_TRANSFER_FOG(o,o.pos);
                o.projPos = ComputeScreenPos (o.pos);
                COMPUTE_EYEDEPTH(o.projPos.z);
                TRANSFER_VERTEX_TO_FRAGMENT(o)
                return o;
            }
            #ifdef UNITY_CAN_COMPILE_TESSELLATION
                struct TessVertex {
                    float4 vertex : INTERNALTESSPOS;
                    float3 normal : NORMAL;
                    float4 tangent : TANGENT;
                    float2 texcoord0 : TEXCOORD0;
                };
                struct OutputPatchConstant {
                    float edge[3]         : SV_TessFactor;
                    float inside          : SV_InsideTessFactor;
                    float3 vTangent[4]    : TANGENT;
                    float2 vUV[4]         : TEXCOORD;
                    float3 vTanUCorner[4] : TANUCORNER;
                    float3 vTanVCorner[4] : TANVCORNER;
                    float4 vCWts          : TANWEIGHTS;
                };
                TessVertex tessvert (VertexInput v) {
                    TessVertex o;
                    o.vertex = v.vertex;
                    o.normal = v.normal;
                    o.tangent = v.tangent;
                    o.texcoord0 = v.texcoord0;
                    return o;
                }
                void displacement (inout VertexInput v){
                    float4 node_799 = _Time;
                    float node_4709 = ((_SwayIntensity*sin((_Swayfrequency*6.28318530718)))+node_799.g);
                    float node_8004 = node_4709;
                    float2 node_1622 = mul(unity_ObjectToWorld, v.vertex).rgb.rb;
                    float3 node_659 = ((Gerstner1( _WaveSharpness , _WaveHeight , _WaveSpread , _WaveSpeed , node_8004 , dot(float2(_Wave1XDirection,_Wave1ZDirection),node_1622) )+Gerstner2( _WaveSharpness , _WaveHeight , _WaveSpread , _WaveSpeed , (node_8004+2.0) , dot(float2(_Wave2,_Wave3XDirection_copy),node_1622) )+Gerstner3( _WaveSharpness , _WaveHeight , _WaveSpread , _WaveSpeed , (node_8004+4.0) , dot(float2(_Wave3XDirection,_Wave3ZDirection),node_1622) ))/0.0);
                    v.vertex.xyz += node_659;
                }
                float Tessellation(TessVertex v){
                    float node_3209_if_leA = step(distance(mul(unity_ObjectToWorld, v.vertex).rgb,_WorldSpaceCameraPos),_TesselationCurve);
                    float node_3209_if_leB = step(_TesselationCurve,distance(mul(unity_ObjectToWorld, v.vertex).rgb,_WorldSpaceCameraPos));
                    float4 node_799 = _Time;
                    float node_4709 = ((_SwayIntensity*sin((_Swayfrequency*6.28318530718)))+node_799.g);
                    float node_8004 = node_4709;
                    float2 node_1622 = mul(unity_ObjectToWorld, v.vertex).rgb.rb;
                    float3 node_659 = ((Gerstner1( _WaveSharpness , _WaveHeight , _WaveSpread , _WaveSpeed , node_8004 , dot(float2(_Wave1XDirection,_Wave1ZDirection),node_1622) )+Gerstner2( _WaveSharpness , _WaveHeight , _WaveSpread , _WaveSpeed , (node_8004+2.0) , dot(float2(_Wave2,_Wave3XDirection_copy),node_1622) )+Gerstner3( _WaveSharpness , _WaveHeight , _WaveSpread , _WaveSpeed , (node_8004+4.0) , dot(float2(_Wave3XDirection,_Wave3ZDirection),node_1622) ))/0.0);
                    float node_5052 = (_WaveHeight*0.0);
                    float node_2422 = (-1*node_5052);
                    float node_6226 = 0.0;
                    float node_4699 = (node_6226 + ( (node_659 - node_2422) * (0.0 - node_6226) ) / (node_5052 - node_2422)).g;
                    float node_8450 = 0.0;
                    return lerp((node_3209_if_leA*(_Tesselationmin + ( (node_4699 - node_8450) * (_Tesselationmax - _Tesselationmin) ) / (1.0 - node_8450)))+(node_3209_if_leB*_Tesselationamp),_Tesselationamp,node_3209_if_leA*node_3209_if_leB);
                }
                float4 Tessellation(TessVertex v, TessVertex v1, TessVertex v2){
                    float tv = Tessellation(v);
                    float tv1 = Tessellation(v1);
                    float tv2 = Tessellation(v2);
                    return float4( tv1+tv2, tv2+tv, tv+tv1, tv+tv1+tv2 ) / float4(2,2,2,3);
                }
                OutputPatchConstant hullconst (InputPatch<TessVertex,3> v) {
                    OutputPatchConstant o = (OutputPatchConstant)0;
                    float4 ts = Tessellation( v[0], v[1], v[2] );
                    o.edge[0] = ts.x;
                    o.edge[1] = ts.y;
                    o.edge[2] = ts.z;
                    o.inside = ts.w;
                    return o;
                }
                [domain("tri")]
                [partitioning("fractional_odd")]
                [outputtopology("triangle_cw")]
                [patchconstantfunc("hullconst")]
                [outputcontrolpoints(3)]
                TessVertex hull (InputPatch<TessVertex,3> v, uint id : SV_OutputControlPointID) {
                    return v[id];
                }
                [domain("tri")]
                VertexOutput domain (OutputPatchConstant tessFactors, const OutputPatch<TessVertex,3> vi, float3 bary : SV_DomainLocation) {
                    VertexInput v = (VertexInput)0;
                    v.vertex = vi[0].vertex*bary.x + vi[1].vertex*bary.y + vi[2].vertex*bary.z;
                    v.normal = vi[0].normal*bary.x + vi[1].normal*bary.y + vi[2].normal*bary.z;
                    v.tangent = vi[0].tangent*bary.x + vi[1].tangent*bary.y + vi[2].tangent*bary.z;
                    v.texcoord0 = vi[0].texcoord0*bary.x + vi[1].texcoord0*bary.y + vi[2].texcoord0*bary.z;
                    displacement(v);
                    VertexOutput o = vert(v);
                    return o;
                }
            #endif
            float4 frag(VertexOutput i) : COLOR {
                float3 recipObjScale = float3( length(unity_WorldToObject[0].xyz), length(unity_WorldToObject[1].xyz), length(unity_WorldToObject[2].xyz) );
                float3 objScale = 1.0/recipObjScale;
                i.normalDir = normalize(i.normalDir);
                float3x3 tangentTransform = float3x3( i.tangentDir, i.bitangentDir, i.normalDir);
                float3 viewDirection = normalize(_WorldSpaceCameraPos.xyz - i.posWorld.xyz);
                float4 node_799 = _Time;
                float node_4709 = ((_SwayIntensity*sin((_Swayfrequency*6.28318530718)))+node_799.g);
                float node_1019 = (node_4709*_NormalScrollSpeed);
                float2 node_8235 = (float2(objScale.r,objScale.b)*i.uv0);
                float2 node_8667 = (((i.uv0*lerp( 1.0, float2(objScale.r,objScale.b), _Flowwithobject ))+(node_4709*_FlowMovementVertical)*float2(1,1))+(node_4709*_FlowMovementHorizontal)*float2(1,1));
                float4 _FlowMap_var = tex2D(_FlowMap,TRANSFORM_TEX(node_8667, _FlowMap));
                float node_3089 = ((_FlowMap_var.rgb.rg*2.0+-1.0)*_FlowPower*1.0);
                float node_9504 = (node_4709*_FlowSpeed);
                float node_9024 = frac(node_9504);
                float node_3633 = 0.5;
                float2 node_5766 = lerp((node_8235+(node_3089*node_9024)),(node_8235+(node_3089*frac((node_9504+0.5)))),abs(((node_3633-node_9024)/node_3633)));
                float2 node_602 = (node_5766*_NormalTilingDiffer);
                float2 node_3751 = ((node_602+(_Normal1VerticalSpeed*node_1019)*float2(1,1))+(node_1019*_Normal1HorizontalSpeed)*float2(1,1));
                float3 node_7637 = UnpackNormal(tex2D(_NormalMap,TRANSFORM_TEX(node_3751, _NormalMap)));
                float2 node_5414 = ((node_5766+(_Normal2VerticalSpeed*node_1019)*float2(1,0))+(node_1019*_Normal2HorizontalSpeed)*float2(0,1));
                float3 node_8301 = UnpackNormal(tex2D(_NormalMap,TRANSFORM_TEX(node_5414, _NormalMap)));
                float3 node_257 = saturate(max(node_7637.rgb,node_8301.rgb));
                float3 normalLocal = node_257;
                float3 normalDirection = normalize(mul( normalLocal, tangentTransform )); // Perturbed normals
                float sceneZ = max(0,LinearEyeDepth (UNITY_SAMPLE_DEPTH(tex2Dproj(_CameraDepthTexture, UNITY_PROJ_COORD(i.projPos)))) - _ProjectionParams.g);
                float partZ = max(0,i.projPos.z - _ProjectionParams.g);
                float node_3322 = saturate((sceneZ-partZ)/_Depth);
                float2 sceneUVs = (i.projPos.xy / i.projPos.w) + (node_257.rg*_RefractionIntensity*node_3322);
                float4 sceneColor = tex2D(_GrabTexture, sceneUVs);
                float3 lightDirection = normalize(lerp(_WorldSpaceLightPos0.xyz, _WorldSpaceLightPos0.xyz - i.posWorld.xyz,_WorldSpaceLightPos0.w));
                float3 lightColor = _LightColor0.rgb;
                float3 halfDirection = normalize(viewDirection+lightDirection);
////// Lighting:
                float attenuation = LIGHT_ATTENUATION(i);
                float3 attenColor = attenuation * _LightColor0.xyz;
                float Pi = 3.141592654;
                float InvPi = 0.31830988618;
///////// Gloss:
                float4 node_3340 = tex2D(_Whitecap,TRANSFORM_TEX(i.uv0, _Whitecap));
                float node_8004 = node_4709;
                float2 node_4174 = ((i.uv0+(float2(_recapScrollSpeed1,_recapScrollSpeed)*node_8004))*0.0);
                float4 node_6980 = tex2D(_Whitecap,TRANSFORM_TEX(node_4174, _Whitecap));
                float node_7873 = saturate(((distance(i.posWorld.rgb,_WorldSpaceCameraPos)-_TransitionDistance)/_Transitionfa));
                float node_8676 = lerp(node_3340.a,node_6980.a,node_7873);
                float2 node_1622 = i.posWorld.rgb.rb;
                float3 node_659 = ((Gerstner1( _WaveSharpness , _WaveHeight , _WaveSpread , _WaveSpeed , node_8004 , dot(float2(_Wave1XDirection,_Wave1ZDirection),node_1622) )+Gerstner2( _WaveSharpness , _WaveHeight , _WaveSpread , _WaveSpeed , (node_8004+2.0) , dot(float2(_Wave2,_Wave3XDirection_copy),node_1622) )+Gerstner3( _WaveSharpness , _WaveHeight , _WaveSpread , _WaveSpeed , (node_8004+4.0) , dot(float2(_Wave3XDirection,_Wave3ZDirection),node_1622) ))/0.0);
                float node_5052 = (_WaveHeight*0.0);
                float node_2422 = (-1*node_5052);
                float node_6226 = 0.0;
                float node_4699 = (node_6226 + ( (node_659 - node_2422) * (0.0 - node_6226) ) / (node_5052 - node_2422)).g;
                float gloss = saturate((_Gloss-(node_8676*pow(node_4699,_whitecappower))));
                float perceptualRoughness = 1.0 - saturate((_Gloss-(node_8676*pow(node_4699,_whitecappower))));
                float roughness = perceptualRoughness * perceptualRoughness;
                float specPow = exp2( gloss * 10.0 + 1.0 );
////// Specular:
                float NdotL = saturate(dot( normalDirection, lightDirection ));
                float LdotH = saturate(dot(lightDirection, halfDirection));
                float3 specularColor = 0.0;
                float specularMonochrome;
                float3 node_7446 = lerp(_Color.rgb,_Lightenedcolor.rgb,node_4699);
                float node_3410 = abs(dot(viewDirection,i.normalDir));
                float2 node_8780 = (sceneUVs.rg+(node_257.rg*_ReflectionDistortionIntensity));
                float4 _ReflectionText_var = tex2D(_ReflectionText,TRANSFORM_TEX(node_8780, _ReflectionText));
                float node_3376 = 0.0;
                float node_9210 = (1.0 - _ReflectionMax);
                float3 node_6858 = lerp(lerp((lerp(node_7446,float3(1,1,1),(node_3410*_ReflectionTint))*_ReflectionText_var.rgb),node_7446,(node_9210 + ( (node_3410 - node_3376) * ((1.0 - _ReflectionMin) - node_9210) ) / (1.0 - node_3376))),lerp(node_3340.rgb,node_6980.rgb,node_7873),node_8676);
                float node_605 = (1.0 - saturate(pow(((1.0 / _FoamSpread)*node_3322),_FoamFalloff)));
                float4 node_5161 = _Time;
                float node_6547 = sin((node_5161.g*_FoamTimeSpeed));
                float2 node_1844 = ((node_602+(node_6547*_FoamHorizontalSpeed)*float2(1,1))+(_FoamVerticalspeed*node_6547)*float2(1,1));
                float4 _Foam_var = tex2D(_Foam,TRANSFORM_TEX(node_1844, _Foam));
                float3 node_4741 = (((node_605*_Foam_var.rgb)+pow((node_605+(_EdgeLineWidth*0.5*(recipObjScale.r+recipObjScale.b))),_FoamOutlineFall))*_FoamIntensity);
                float3 diffuseColor = (node_6858+node_4741); // Need this for specular when using metallic
                diffuseColor = DiffuseAndSpecularFromMetallic( diffuseColor, specularColor, specularColor, specularMonochrome );
                specularMonochrome = 1.0-specularMonochrome;
                float NdotV = abs(dot( normalDirection, viewDirection ));
                float NdotH = saturate(dot( normalDirection, halfDirection ));
                float VdotH = saturate(dot( viewDirection, halfDirection ));
                float visTerm = SmithJointGGXVisibilityTerm( NdotL, NdotV, roughness );
                float normTerm = GGXTerm(NdotH, roughness);
                float specularPBL = (visTerm*normTerm) * UNITY_PI;
                #ifdef UNITY_COLORSPACE_GAMMA
                    specularPBL = sqrt(max(1e-4h, specularPBL));
                #endif
                specularPBL = max(0, specularPBL * NdotL);
                #if defined(_SPECULARHIGHLIGHTS_OFF)
                    specularPBL = 0.0;
                #endif
                specularPBL *= any(specularColor) ? 1.0 : 0.0;
                float3 directSpecular = attenColor*specularPBL*FresnelTerm(specularColor, LdotH);
                float3 specular = directSpecular;
/////// Diffuse:
                NdotL = max(0.0,dot( normalDirection, lightDirection ));
                half fd90 = 0.5 + 2 * LdotH * LdotH * (1-gloss);
                float nlPow5 = Pow5(1-NdotL);
                float nvPow5 = Pow5(1-NdotV);
                float3 directDiffuse = ((1 +(fd90 - 1)*nlPow5) * (1 + (fd90 - 1)*nvPow5) * NdotL) * attenColor;
                float3 diffuse = directDiffuse * diffuseColor;
/// Final Color:
                float3 finalColor = diffuse + specular;
                fixed4 finalRGBA = fixed4(finalColor * (node_4741.r+clamp(node_3322,_OpacityMinimum,1.0)),0);
                UNITY_APPLY_FOG(i.fogCoord, finalRGBA);
                return finalRGBA;
            }
            ENDCG
        }
        Pass {
            Name "ShadowCaster"
            Tags {
                "LightMode"="ShadowCaster"
            }
            Offset 1, 1
            Cull Back
            
            CGPROGRAM
            #pragma hull hull
            #pragma domain domain
            #pragma vertex tessvert
            #pragma fragment frag
            #define UNITY_PASS_SHADOWCASTER
            #include "UnityCG.cginc"
            #include "Lighting.cginc"
            #include "Tessellation.cginc"
            #include "UnityPBSLighting.cginc"
            #include "UnityStandardBRDF.cginc"
            #pragma fragmentoption ARB_precision_hint_fastest
            #pragma multi_compile_shadowcaster
            #pragma multi_compile_fog
            #pragma only_renderers d3d9 d3d11 glcore gles 
            #pragma target 5.0
            uniform float _Swayfrequency;
            uniform float _SwayIntensity;
            float3 Gerstner2( float Steepness , float Amplitude , float Wavelength , float Speed , float Time , float DotProd ){
            float phaseCont = Speed * Wavelength;
            float xVal = Steepness * Amplitude * DirectionVec.x * cos(Wavelength * DotProd + Time * phaseCont);
            float yVal = Amplitude * sin(Wavelength * DotProd + Time * phaseConst);
            float zVal = Steepness * Amplitude * DirectionVec.y * cos(Wavelength * DotProd + phaseConst);
            return float3(xVal, yVal, zVal);
            }
            
            float3 Gerstner3( float Steepness , float Amplitude , float Wavelength , float Speed , float Time , float DotProd ){
            float phaseCont = Speed * Wavelength;
            float xVal = Steepness * Amplitude * DirectionVec.x * cos(Wavelength * DotProd + Time * phaseCont);
            float yVal = Amplitude * sin(Wavelength * DotProd + Time * phaseConst);
            float zVal = Steepness * Amplitude * DirectionVec.y * cos(Wavelength * DotProd + phaseConst);
            return float3(xVal, yVal, zVal);
            }
            
            float3 Gerstner1( float Steepness , float Amplitude , float Wavelength , float Speed , float Time , float DotProd ){
            float phaseCont = Speed * Wavelength;
            float xVal = Steepness * Amplitude * DirectionVec.x * cos(Wavelength * DotProd + Time * phaseCont);
            float yVal = Amplitude * sin(Wavelength * DotProd + Time * phaseConst);
            float zVal = Steepness * Amplitude * DirectionVec.y * cos(Wavelength * DotProd + phaseConst);
            return float3(xVal, yVal, zVal);
            }
            
            uniform float _Wave3ZDirection;
            uniform float _Wave3XDirection;
            uniform float _Wave3XDirection_copy;
            uniform float _Wave2;
            uniform float _Wave1ZDirection;
            uniform float _Wave1XDirection;
            uniform float _WaveSharpness;
            uniform float _WaveHeight;
            uniform float _WaveSpread;
            uniform float _WaveSpeed;
            uniform float _Tesselationmin;
            uniform float _Tesselationmax;
            uniform float _Tesselationamp;
            uniform float _TesselationCurve;
            struct VertexInput {
                float4 vertex : POSITION;
                float3 normal : NORMAL;
                float4 tangent : TANGENT;
            };
            struct VertexOutput {
                V2F_SHADOW_CASTER;
                float4 posWorld : TEXCOORD1;
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.posWorld = mul(unity_ObjectToWorld, v.vertex);
                o.pos = UnityObjectToClipPos( v.vertex );
                TRANSFER_SHADOW_CASTER(o)
                return o;
            }
            #ifdef UNITY_CAN_COMPILE_TESSELLATION
                struct TessVertex {
                    float4 vertex : INTERNALTESSPOS;
                    float3 normal : NORMAL;
                    float4 tangent : TANGENT;
                };
                struct OutputPatchConstant {
                    float edge[3]         : SV_TessFactor;
                    float inside          : SV_InsideTessFactor;
                    float3 vTangent[4]    : TANGENT;
                    float2 vUV[4]         : TEXCOORD;
                    float3 vTanUCorner[4] : TANUCORNER;
                    float3 vTanVCorner[4] : TANVCORNER;
                    float4 vCWts          : TANWEIGHTS;
                };
                TessVertex tessvert (VertexInput v) {
                    TessVertex o;
                    o.vertex = v.vertex;
                    o.normal = v.normal;
                    o.tangent = v.tangent;
                    return o;
                }
                void displacement (inout VertexInput v){
                    float4 node_799 = _Time;
                    float node_4709 = ((_SwayIntensity*sin((_Swayfrequency*6.28318530718)))+node_799.g);
                    float node_8004 = node_4709;
                    float2 node_1622 = mul(unity_ObjectToWorld, v.vertex).rgb.rb;
                    float3 node_659 = ((Gerstner1( _WaveSharpness , _WaveHeight , _WaveSpread , _WaveSpeed , node_8004 , dot(float2(_Wave1XDirection,_Wave1ZDirection),node_1622) )+Gerstner2( _WaveSharpness , _WaveHeight , _WaveSpread , _WaveSpeed , (node_8004+2.0) , dot(float2(_Wave2,_Wave3XDirection_copy),node_1622) )+Gerstner3( _WaveSharpness , _WaveHeight , _WaveSpread , _WaveSpeed , (node_8004+4.0) , dot(float2(_Wave3XDirection,_Wave3ZDirection),node_1622) ))/0.0);
                    v.vertex.xyz += node_659;
                }
                float Tessellation(TessVertex v){
                    float node_3209_if_leA = step(distance(mul(unity_ObjectToWorld, v.vertex).rgb,_WorldSpaceCameraPos),_TesselationCurve);
                    float node_3209_if_leB = step(_TesselationCurve,distance(mul(unity_ObjectToWorld, v.vertex).rgb,_WorldSpaceCameraPos));
                    float4 node_799 = _Time;
                    float node_4709 = ((_SwayIntensity*sin((_Swayfrequency*6.28318530718)))+node_799.g);
                    float node_8004 = node_4709;
                    float2 node_1622 = mul(unity_ObjectToWorld, v.vertex).rgb.rb;
                    float3 node_659 = ((Gerstner1( _WaveSharpness , _WaveHeight , _WaveSpread , _WaveSpeed , node_8004 , dot(float2(_Wave1XDirection,_Wave1ZDirection),node_1622) )+Gerstner2( _WaveSharpness , _WaveHeight , _WaveSpread , _WaveSpeed , (node_8004+2.0) , dot(float2(_Wave2,_Wave3XDirection_copy),node_1622) )+Gerstner3( _WaveSharpness , _WaveHeight , _WaveSpread , _WaveSpeed , (node_8004+4.0) , dot(float2(_Wave3XDirection,_Wave3ZDirection),node_1622) ))/0.0);
                    float node_5052 = (_WaveHeight*0.0);
                    float node_2422 = (-1*node_5052);
                    float node_6226 = 0.0;
                    float node_4699 = (node_6226 + ( (node_659 - node_2422) * (0.0 - node_6226) ) / (node_5052 - node_2422)).g;
                    float node_8450 = 0.0;
                    return lerp((node_3209_if_leA*(_Tesselationmin + ( (node_4699 - node_8450) * (_Tesselationmax - _Tesselationmin) ) / (1.0 - node_8450)))+(node_3209_if_leB*_Tesselationamp),_Tesselationamp,node_3209_if_leA*node_3209_if_leB);
                }
                float4 Tessellation(TessVertex v, TessVertex v1, TessVertex v2){
                    float tv = Tessellation(v);
                    float tv1 = Tessellation(v1);
                    float tv2 = Tessellation(v2);
                    return float4( tv1+tv2, tv2+tv, tv+tv1, tv+tv1+tv2 ) / float4(2,2,2,3);
                }
                OutputPatchConstant hullconst (InputPatch<TessVertex,3> v) {
                    OutputPatchConstant o = (OutputPatchConstant)0;
                    float4 ts = Tessellation( v[0], v[1], v[2] );
                    o.edge[0] = ts.x;
                    o.edge[1] = ts.y;
                    o.edge[2] = ts.z;
                    o.inside = ts.w;
                    return o;
                }
                [domain("tri")]
                [partitioning("fractional_odd")]
                [outputtopology("triangle_cw")]
                [patchconstantfunc("hullconst")]
                [outputcontrolpoints(3)]
                TessVertex hull (InputPatch<TessVertex,3> v, uint id : SV_OutputControlPointID) {
                    return v[id];
                }
                [domain("tri")]
                VertexOutput domain (OutputPatchConstant tessFactors, const OutputPatch<TessVertex,3> vi, float3 bary : SV_DomainLocation) {
                    VertexInput v = (VertexInput)0;
                    v.vertex = vi[0].vertex*bary.x + vi[1].vertex*bary.y + vi[2].vertex*bary.z;
                    v.normal = vi[0].normal*bary.x + vi[1].normal*bary.y + vi[2].normal*bary.z;
                    v.tangent = vi[0].tangent*bary.x + vi[1].tangent*bary.y + vi[2].tangent*bary.z;
                    displacement(v);
                    VertexOutput o = vert(v);
                    return o;
                }
            #endif
            float4 frag(VertexOutput i) : COLOR {
                SHADOW_CASTER_FRAGMENT(i)
            }
            ENDCG
        }
    }
    FallBack "Diffuse"
    CustomEditor "ShaderForgeMaterialInspector"
}
