// Shader created with Shader Forge v1.26 
// Shader Forge (c) Neat Corporation / Joachim Holmer - http://www.acegikmo.com/shaderforge/
// Note: Manually altering this data may prevent you from opening it in Shader Forge
/*SF_DATA;ver:1.26;sub:START;pass:START;ps:flbk:,iptp:0,cusa:False,bamd:0,lico:1,lgpr:1,limd:1,spmd:1,trmd:0,grmd:0,uamb:True,mssp:True,bkdf:True,hqlp:False,rprd:False,enco:False,rmgx:True,rpth:0,vtps:0,hqsc:True,nrmq:1,nrsp:0,vomd:0,spxs:False,tesm:0,olmd:1,culm:0,bsrc:0,bdst:1,dpts:2,wrdp:True,dith:0,rfrpo:True,rfrpn:Refraction,coma:15,ufog:True,aust:True,igpj:False,qofs:0,qpre:1,rntp:1,fgom:False,fgoc:False,fgod:False,fgor:False,fgmd:0,fgcr:0.5,fgcg:0.5,fgcb:0.5,fgca:1,fgde:0.01,fgrn:0,fgrf:300,stcl:False,stva:128,stmr:255,stmw:255,stcp:6,stps:0,stfa:0,stfz:0,ofsf:0,ofsu:0,f2p0:False,fnsp:False,fnfb:False;n:type:ShaderForge.SFN_Final,id:1,x:33443,y:32423,varname:node_1,prsc:2|diff-151-RGB,spec-6988-RGB,gloss-4921-OUT,normal-4935-OUT,emission-166-OUT,transm-133-OUT,lwrap-133-OUT,voffset-140-OUT;n:type:ShaderForge.SFN_Subtract,id:18,x:32114,y:32340,varname:node_18,prsc:2|A-22-OUT,B-19-OUT;n:type:ShaderForge.SFN_Vector1,id:19,x:31935,y:32422,varname:node_19,prsc:2,v1:0.5;n:type:ShaderForge.SFN_Abs,id:21,x:32286,y:32340,varname:node_21,prsc:2|IN-18-OUT;n:type:ShaderForge.SFN_Frac,id:22,x:31935,y:32288,varname:node_22,prsc:2|IN-24-OUT;n:type:ShaderForge.SFN_ComponentMask,id:24,x:31773,y:32285,varname:node_24,prsc:2,cc1:0,cc2:-1,cc3:-1,cc4:-1|IN-4767-UVOUT;n:type:ShaderForge.SFN_Multiply,id:25,x:32461,y:32390,cmnt:Triangle Wave,varname:node_25,prsc:2|A-21-OUT,B-26-OUT;n:type:ShaderForge.SFN_Vector1,id:26,x:32286,y:32476,varname:node_26,prsc:2,v1:2;n:type:ShaderForge.SFN_Power,id:133,x:32665,y:32453,cmnt:Panning gradient,varname:node_133,prsc:2|VAL-25-OUT,EXP-8547-OUT;n:type:ShaderForge.SFN_NormalVector,id:139,x:32892,y:32957,prsc:2,pt:False;n:type:ShaderForge.SFN_Multiply,id:140,x:33119,y:32787,varname:node_140,prsc:2|A-1924-OUT,B-142-OUT,C-139-OUT;n:type:ShaderForge.SFN_ValueProperty,id:142,x:32892,y:32789,ptovrint:False,ptlb:Bulge Scale,ptin:_BulgeScale,varname:_BulgeScale,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0.3;n:type:ShaderForge.SFN_Tex2d,id:151,x:33123,y:31569,ptovrint:False,ptlb:Diffuse,ptin:_Diffuse,varname:_Diffuse,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:b2cf93675453a29458d7ea59815b90f3,ntxv:0,isnm:False|UVIN-8742-UVOUT;n:type:ShaderForge.SFN_Multiply,id:166,x:33017,y:32346,cmnt:Glow,varname:node_166,prsc:2|A-168-RGB,B-8677-OUT,C-1924-OUT;n:type:ShaderForge.SFN_Color,id:168,x:32818,y:32321,ptovrint:False,ptlb:Glow Color,ptin:_GlowColor,varname:_GlowColor,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:1,c2:0.2391481,c3:0.1102941,c4:1;n:type:ShaderForge.SFN_Vector3,id:265,x:32726,y:32200,varname:node_265,prsc:2,v1:0,v2:1,v3:1;n:type:ShaderForge.SFN_Vector1,id:4921,x:33193,y:32149,varname:node_4921,prsc:2,v1:1;n:type:ShaderForge.SFN_Normalize,id:4935,x:33148,y:32212,varname:node_4935,prsc:2|IN-5190-OUT;n:type:ShaderForge.SFN_ValueProperty,id:8547,x:32461,y:32537,ptovrint:False,ptlb:Bulge Shape,ptin:_BulgeShape,varname:_BulgeShape,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:5;n:type:ShaderForge.SFN_ValueProperty,id:8677,x:32818,y:32510,ptovrint:False,ptlb:Glow Intensity,ptin:_GlowIntensity,varname:_GlowIntensity,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:1;n:type:ShaderForge.SFN_Relay,id:1924,x:32892,y:32697,varname:node_1924,prsc:2|IN-133-OUT;n:type:ShaderForge.SFN_Tex2d,id:7748,x:32818,y:31968,ptovrint:False,ptlb:Normal,ptin:_Normal,varname:node_7748,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:a0d5dd0a12d41fa4894e55be85b96b65,ntxv:3,isnm:False|UVIN-8742-UVOUT;n:type:ShaderForge.SFN_Multiply,id:5190,x:32973,y:32135,varname:node_5190,prsc:2|A-7748-RGB,B-265-OUT,C-6988-RGB;n:type:ShaderForge.SFN_TexCoord,id:818,x:32400,y:31715,varname:node_818,prsc:2,uv:0;n:type:ShaderForge.SFN_ValueProperty,id:4848,x:32518,y:31854,ptovrint:False,ptlb:Tiling,ptin:_Tiling,varname:_BulgeScale_copy_copy,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:1;n:type:ShaderForge.SFN_UVTile,id:8742,x:32760,y:31692,varname:node_8742,prsc:2|UVIN-818-UVOUT,WDT-4848-OUT,HGT-4848-OUT,TILE-4848-OUT;n:type:ShaderForge.SFN_Distance,id:3330,x:31611,y:31848,varname:node_3330,prsc:2|A-6519-UVOUT,B-2449-OUT;n:type:ShaderForge.SFN_Vector2,id:2449,x:31442,y:31935,varname:node_2449,prsc:2,v1:0.5,v2:0.5;n:type:ShaderForge.SFN_Multiply,id:2018,x:31883,y:31818,varname:node_2018,prsc:2|A-3330-OUT,B-6914-OUT;n:type:ShaderForge.SFN_ValueProperty,id:3764,x:32114,y:32226,ptovrint:False,ptlb:Time_Wave,ptin:_Time_Wave,varname:node_3764,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:1;n:type:ShaderForge.SFN_OneMinus,id:504,x:32060,y:31829,varname:node_504,prsc:2|IN-2018-OUT;n:type:ShaderForge.SFN_Clamp01,id:5526,x:32210,y:31866,varname:node_5526,prsc:2|IN-504-OUT;n:type:ShaderForge.SFN_Multiply,id:7490,x:32089,y:31989,varname:node_7490,prsc:2|A-5526-OUT,B-2613-OUT,C-957-OUT;n:type:ShaderForge.SFN_Slider,id:2613,x:31697,y:32085,ptovrint:False,ptlb:Forme_Wave,ptin:_Forme_Wave,varname:node_2613,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:1,max:2;n:type:ShaderForge.SFN_Rotator,id:4757,x:32339,y:31989,varname:node_4757,prsc:2|UVIN-6278-UVOUT,ANG-7490-OUT;n:type:ShaderForge.SFN_TexCoord,id:6278,x:32125,y:31663,varname:node_6278,prsc:2,uv:0;n:type:ShaderForge.SFN_Time,id:2541,x:32089,y:32103,varname:node_2541,prsc:2;n:type:ShaderForge.SFN_Panner,id:4767,x:32483,y:32157,varname:node_4767,prsc:2,spu:1.5,spv:1.5|UVIN-4757-UVOUT,DIST-122-OUT;n:type:ShaderForge.SFN_Pi,id:957,x:31991,y:32148,varname:node_957,prsc:2;n:type:ShaderForge.SFN_Vector1,id:6914,x:31748,y:31938,varname:node_6914,prsc:2,v1:2;n:type:ShaderForge.SFN_Multiply,id:122,x:32298,y:32157,varname:node_122,prsc:2|A-2541-TSL,B-3764-OUT;n:type:ShaderForge.SFN_UVTile,id:8203,x:31821,y:31658,varname:node_8203,prsc:2|UVIN-4767-UVOUT,WDT-4114-OUT,HGT-4114-OUT,TILE-4114-OUT;n:type:ShaderForge.SFN_ValueProperty,id:4114,x:31637,y:31742,ptovrint:False,ptlb:Tiling_copy,ptin:_Tiling_copy,varname:_Tiling_copy,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:1;n:type:ShaderForge.SFN_TexCoord,id:6519,x:31209,y:31819,varname:node_6519,prsc:2,uv:0;n:type:ShaderForge.SFN_Tex2d,id:6988,x:33097,y:31896,ptovrint:False,ptlb:Diffuse_copy,ptin:_Diffuse_copy,varname:_Diffuse_copy,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:b2cf93675453a29458d7ea59815b90f3,ntxv:3,isnm:False;proporder:151-168-142-8547-8677-4848-7748-3764-2613-4114-6988;pass:END;sub:END;*/

Shader "Shader Forge/Examples/Vertex Animation" {
    Properties {
        _Diffuse ("Diffuse", 2D) = "white" {}
        _GlowColor ("Glow Color", Color) = (1,0.2391481,0.1102941,1)
        _BulgeScale ("Bulge Scale", Float ) = 0.3
        _BulgeShape ("Bulge Shape", Float ) = 5
        _GlowIntensity ("Glow Intensity", Float ) = 1
        _Tiling ("Tiling", Float ) = 1
        _Normal ("Normal", 2D) = "bump" {}
        _Time_Wave ("Time_Wave", Float ) = 1
        _Forme_Wave ("Forme_Wave", Range(0, 2)) = 1
        _Tiling_copy ("Tiling_copy", Float ) = 1
        _Diffuse_copy ("Diffuse_copy", 2D) = "bump" {}
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
            #define SHOULD_SAMPLE_SH ( defined (LIGHTMAP_OFF) && defined(DYNAMICLIGHTMAP_OFF) )
            #include "UnityCG.cginc"
            #include "AutoLight.cginc"
            #include "Lighting.cginc"
            #include "UnityPBSLighting.cginc"
            #include "UnityStandardBRDF.cginc"
            #pragma multi_compile_fwdbase_fullshadows
            #pragma multi_compile LIGHTMAP_OFF LIGHTMAP_ON
            #pragma multi_compile DIRLIGHTMAP_OFF DIRLIGHTMAP_COMBINED DIRLIGHTMAP_SEPARATE
            #pragma multi_compile DYNAMICLIGHTMAP_OFF DYNAMICLIGHTMAP_ON
            #pragma multi_compile_fog
            #pragma exclude_renderers xbox360 ps3 
            #pragma target 3.0
            uniform float4 _TimeEditor;
            uniform float _BulgeScale;
            uniform sampler2D _Diffuse; uniform float4 _Diffuse_ST;
            uniform float4 _GlowColor;
            uniform float _BulgeShape;
            uniform float _GlowIntensity;
            uniform sampler2D _Normal; uniform float4 _Normal_ST;
            uniform float _Tiling;
            uniform float _Time_Wave;
            uniform float _Forme_Wave;
            uniform sampler2D _Diffuse_copy; uniform float4 _Diffuse_copy_ST;
            struct VertexInput {
                float4 vertex : POSITION;
                float3 normal : NORMAL;
                float4 tangent : TANGENT;
                float2 texcoord0 : TEXCOORD0;
                float2 texcoord1 : TEXCOORD1;
                float2 texcoord2 : TEXCOORD2;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float2 uv0 : TEXCOORD0;
                float2 uv1 : TEXCOORD1;
                float2 uv2 : TEXCOORD2;
                float4 posWorld : TEXCOORD3;
                float3 normalDir : TEXCOORD4;
                float3 tangentDir : TEXCOORD5;
                float3 bitangentDir : TEXCOORD6;
                LIGHTING_COORDS(7,8)
                UNITY_FOG_COORDS(9)
                #if defined(LIGHTMAP_ON) || defined(UNITY_SHOULD_SAMPLE_SH)
                    float4 ambientOrLightmapUV : TEXCOORD10;
                #endif
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                o.uv1 = v.texcoord1;
                o.uv2 = v.texcoord2;
                #ifdef LIGHTMAP_ON
                    o.ambientOrLightmapUV.xy = v.texcoord1.xy * unity_LightmapST.xy + unity_LightmapST.zw;
                    o.ambientOrLightmapUV.zw = 0;
                #elif UNITY_SHOULD_SAMPLE_SH
                #endif
                #ifdef DYNAMICLIGHTMAP_ON
                    o.ambientOrLightmapUV.zw = v.texcoord2.xy * unity_DynamicLightmapST.xy + unity_DynamicLightmapST.zw;
                #endif
                o.normalDir = UnityObjectToWorldNormal(v.normal);
                o.tangentDir = normalize( mul( _Object2World, float4( v.tangent.xyz, 0.0 ) ).xyz );
                o.bitangentDir = normalize(cross(o.normalDir, o.tangentDir) * v.tangent.w);
                float4 node_2541 = _Time + _TimeEditor;
                float node_4757_ang = (saturate((1.0 - (distance(o.uv0,float2(0.5,0.5))*2.0)))*_Forme_Wave*3.141592654);
                float node_4757_spd = 1.0;
                float node_4757_cos = cos(node_4757_spd*node_4757_ang);
                float node_4757_sin = sin(node_4757_spd*node_4757_ang);
                float2 node_4757_piv = float2(0.5,0.5);
                float2 node_4757 = (mul(o.uv0-node_4757_piv,float2x2( node_4757_cos, -node_4757_sin, node_4757_sin, node_4757_cos))+node_4757_piv);
                float2 node_4767 = (node_4757+(node_2541.r*_Time_Wave)*float2(1.5,1.5));
                float node_133 = pow((abs((frac(node_4767.r)-0.5))*2.0),_BulgeShape); // Panning gradient
                float node_1924 = node_133;
                v.vertex.xyz += (node_1924*_BulgeScale*v.normal);
                o.posWorld = mul(_Object2World, v.vertex);
                float3 lightColor = _LightColor0.rgb;
                o.pos = mul(UNITY_MATRIX_MVP, v.vertex );
                UNITY_TRANSFER_FOG(o,o.pos);
                TRANSFER_VERTEX_TO_FRAGMENT(o)
                return o;
            }
            float4 frag(VertexOutput i) : COLOR {
                i.normalDir = normalize(i.normalDir);
                float3x3 tangentTransform = float3x3( i.tangentDir, i.bitangentDir, i.normalDir);
                float3 viewDirection = normalize(_WorldSpaceCameraPos.xyz - i.posWorld.xyz);
                float2 node_8742_tc_rcp = float2(1.0,1.0)/float2( _Tiling, _Tiling );
                float node_8742_ty = floor(_Tiling * node_8742_tc_rcp.x);
                float node_8742_tx = _Tiling - _Tiling * node_8742_ty;
                float2 node_8742 = (i.uv0 + float2(node_8742_tx, node_8742_ty)) * node_8742_tc_rcp;
                float4 _Normal_var = tex2D(_Normal,TRANSFORM_TEX(node_8742, _Normal));
                float4 _Diffuse_copy_var = tex2D(_Diffuse_copy,TRANSFORM_TEX(i.uv0, _Diffuse_copy));
                float3 normalLocal = normalize((_Normal_var.rgb*float3(0,1,1)*_Diffuse_copy_var.rgb));
                float3 normalDirection = normalize(mul( normalLocal, tangentTransform )); // Perturbed normals
                float3 viewReflectDirection = reflect( -viewDirection, normalDirection );
                float3 lightDirection = normalize(_WorldSpaceLightPos0.xyz);
                float3 lightColor = _LightColor0.rgb;
                float3 halfDirection = normalize(viewDirection+lightDirection);
////// Lighting:
                float attenuation = LIGHT_ATTENUATION(i);
                float3 attenColor = attenuation * _LightColor0.xyz;
///////// Gloss:
                float gloss = 1.0;
                float specPow = exp2( gloss * 10.0+1.0);
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
                #if defined(LIGHTMAP_ON) || defined(DYNAMICLIGHTMAP_ON)
                    d.ambient = 0;
                    d.lightmapUV = i.ambientOrLightmapUV;
                #else
                    d.ambient = i.ambientOrLightmapUV;
                #endif
                Unity_GlossyEnvironmentData ugls_en_data;
                ugls_en_data.roughness = 1.0 - gloss;
                ugls_en_data.reflUVW = viewReflectDirection;
                UnityGI gi = UnityGlobalIllumination(d, 1, normalDirection, ugls_en_data );
                lightDirection = gi.light.dir;
                lightColor = gi.light.color;
////// Specular:
                float NdotL = max(0, dot( normalDirection, lightDirection ));
                float3 specularColor = _Diffuse_copy_var.rgb;
                float3 directSpecular = 1 * pow(max(0,dot(halfDirection,normalDirection)),specPow)*specularColor;
                float3 specular = directSpecular;
/////// Diffuse:
                NdotL = dot( normalDirection, lightDirection );
                float4 node_2541 = _Time + _TimeEditor;
                float node_4757_ang = (saturate((1.0 - (distance(i.uv0,float2(0.5,0.5))*2.0)))*_Forme_Wave*3.141592654);
                float node_4757_spd = 1.0;
                float node_4757_cos = cos(node_4757_spd*node_4757_ang);
                float node_4757_sin = sin(node_4757_spd*node_4757_ang);
                float2 node_4757_piv = float2(0.5,0.5);
                float2 node_4757 = (mul(i.uv0-node_4757_piv,float2x2( node_4757_cos, -node_4757_sin, node_4757_sin, node_4757_cos))+node_4757_piv);
                float2 node_4767 = (node_4757+(node_2541.r*_Time_Wave)*float2(1.5,1.5));
                float node_133 = pow((abs((frac(node_4767.r)-0.5))*2.0),_BulgeShape); // Panning gradient
                float3 w = float3(node_133,node_133,node_133)*0.5; // Light wrapping
                float3 NdotLWrap = NdotL * ( 1.0 - w );
                float3 forwardLight = max(float3(0.0,0.0,0.0), NdotLWrap + w );
                float3 backLight = max(float3(0.0,0.0,0.0), -NdotLWrap + w ) * float3(node_133,node_133,node_133);
                NdotL = max(0.0,dot( normalDirection, lightDirection ));
                float3 directDiffuse = (forwardLight+backLight) * attenColor;
                float3 indirectDiffuse = float3(0,0,0);
                indirectDiffuse += gi.indirect.diffuse;
                float4 _Diffuse_var = tex2D(_Diffuse,TRANSFORM_TEX(node_8742, _Diffuse));
                float3 diffuseColor = _Diffuse_var.rgb;
                float3 diffuse = (directDiffuse + indirectDiffuse) * diffuseColor;
////// Emissive:
                float node_1924 = node_133;
                float3 emissive = (_GlowColor.rgb*_GlowIntensity*node_1924);
/// Final Color:
                float3 finalColor = diffuse + specular + emissive;
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
            #define SHOULD_SAMPLE_SH ( defined (LIGHTMAP_OFF) && defined(DYNAMICLIGHTMAP_OFF) )
            #include "UnityCG.cginc"
            #include "AutoLight.cginc"
            #include "Lighting.cginc"
            #include "UnityPBSLighting.cginc"
            #include "UnityStandardBRDF.cginc"
            #pragma multi_compile_fwdadd_fullshadows
            #pragma multi_compile LIGHTMAP_OFF LIGHTMAP_ON
            #pragma multi_compile DIRLIGHTMAP_OFF DIRLIGHTMAP_COMBINED DIRLIGHTMAP_SEPARATE
            #pragma multi_compile DYNAMICLIGHTMAP_OFF DYNAMICLIGHTMAP_ON
            #pragma multi_compile_fog
            #pragma exclude_renderers xbox360 ps3 
            #pragma target 3.0
            uniform float4 _TimeEditor;
            uniform float _BulgeScale;
            uniform sampler2D _Diffuse; uniform float4 _Diffuse_ST;
            uniform float4 _GlowColor;
            uniform float _BulgeShape;
            uniform float _GlowIntensity;
            uniform sampler2D _Normal; uniform float4 _Normal_ST;
            uniform float _Tiling;
            uniform float _Time_Wave;
            uniform float _Forme_Wave;
            uniform sampler2D _Diffuse_copy; uniform float4 _Diffuse_copy_ST;
            struct VertexInput {
                float4 vertex : POSITION;
                float3 normal : NORMAL;
                float4 tangent : TANGENT;
                float2 texcoord0 : TEXCOORD0;
                float2 texcoord1 : TEXCOORD1;
                float2 texcoord2 : TEXCOORD2;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float2 uv0 : TEXCOORD0;
                float2 uv1 : TEXCOORD1;
                float2 uv2 : TEXCOORD2;
                float4 posWorld : TEXCOORD3;
                float3 normalDir : TEXCOORD4;
                float3 tangentDir : TEXCOORD5;
                float3 bitangentDir : TEXCOORD6;
                LIGHTING_COORDS(7,8)
                UNITY_FOG_COORDS(9)
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                o.uv1 = v.texcoord1;
                o.uv2 = v.texcoord2;
                o.normalDir = UnityObjectToWorldNormal(v.normal);
                o.tangentDir = normalize( mul( _Object2World, float4( v.tangent.xyz, 0.0 ) ).xyz );
                o.bitangentDir = normalize(cross(o.normalDir, o.tangentDir) * v.tangent.w);
                float4 node_2541 = _Time + _TimeEditor;
                float node_4757_ang = (saturate((1.0 - (distance(o.uv0,float2(0.5,0.5))*2.0)))*_Forme_Wave*3.141592654);
                float node_4757_spd = 1.0;
                float node_4757_cos = cos(node_4757_spd*node_4757_ang);
                float node_4757_sin = sin(node_4757_spd*node_4757_ang);
                float2 node_4757_piv = float2(0.5,0.5);
                float2 node_4757 = (mul(o.uv0-node_4757_piv,float2x2( node_4757_cos, -node_4757_sin, node_4757_sin, node_4757_cos))+node_4757_piv);
                float2 node_4767 = (node_4757+(node_2541.r*_Time_Wave)*float2(1.5,1.5));
                float node_133 = pow((abs((frac(node_4767.r)-0.5))*2.0),_BulgeShape); // Panning gradient
                float node_1924 = node_133;
                v.vertex.xyz += (node_1924*_BulgeScale*v.normal);
                o.posWorld = mul(_Object2World, v.vertex);
                float3 lightColor = _LightColor0.rgb;
                o.pos = mul(UNITY_MATRIX_MVP, v.vertex );
                UNITY_TRANSFER_FOG(o,o.pos);
                TRANSFER_VERTEX_TO_FRAGMENT(o)
                return o;
            }
            float4 frag(VertexOutput i) : COLOR {
                i.normalDir = normalize(i.normalDir);
                float3x3 tangentTransform = float3x3( i.tangentDir, i.bitangentDir, i.normalDir);
                float3 viewDirection = normalize(_WorldSpaceCameraPos.xyz - i.posWorld.xyz);
                float2 node_8742_tc_rcp = float2(1.0,1.0)/float2( _Tiling, _Tiling );
                float node_8742_ty = floor(_Tiling * node_8742_tc_rcp.x);
                float node_8742_tx = _Tiling - _Tiling * node_8742_ty;
                float2 node_8742 = (i.uv0 + float2(node_8742_tx, node_8742_ty)) * node_8742_tc_rcp;
                float4 _Normal_var = tex2D(_Normal,TRANSFORM_TEX(node_8742, _Normal));
                float4 _Diffuse_copy_var = tex2D(_Diffuse_copy,TRANSFORM_TEX(i.uv0, _Diffuse_copy));
                float3 normalLocal = normalize((_Normal_var.rgb*float3(0,1,1)*_Diffuse_copy_var.rgb));
                float3 normalDirection = normalize(mul( normalLocal, tangentTransform )); // Perturbed normals
                float3 lightDirection = normalize(lerp(_WorldSpaceLightPos0.xyz, _WorldSpaceLightPos0.xyz - i.posWorld.xyz,_WorldSpaceLightPos0.w));
                float3 lightColor = _LightColor0.rgb;
                float3 halfDirection = normalize(viewDirection+lightDirection);
////// Lighting:
                float attenuation = LIGHT_ATTENUATION(i);
                float3 attenColor = attenuation * _LightColor0.xyz;
///////// Gloss:
                float gloss = 1.0;
                float specPow = exp2( gloss * 10.0+1.0);
////// Specular:
                float NdotL = max(0, dot( normalDirection, lightDirection ));
                float3 specularColor = _Diffuse_copy_var.rgb;
                float3 directSpecular = attenColor * pow(max(0,dot(halfDirection,normalDirection)),specPow)*specularColor;
                float3 specular = directSpecular;
/////// Diffuse:
                NdotL = dot( normalDirection, lightDirection );
                float4 node_2541 = _Time + _TimeEditor;
                float node_4757_ang = (saturate((1.0 - (distance(i.uv0,float2(0.5,0.5))*2.0)))*_Forme_Wave*3.141592654);
                float node_4757_spd = 1.0;
                float node_4757_cos = cos(node_4757_spd*node_4757_ang);
                float node_4757_sin = sin(node_4757_spd*node_4757_ang);
                float2 node_4757_piv = float2(0.5,0.5);
                float2 node_4757 = (mul(i.uv0-node_4757_piv,float2x2( node_4757_cos, -node_4757_sin, node_4757_sin, node_4757_cos))+node_4757_piv);
                float2 node_4767 = (node_4757+(node_2541.r*_Time_Wave)*float2(1.5,1.5));
                float node_133 = pow((abs((frac(node_4767.r)-0.5))*2.0),_BulgeShape); // Panning gradient
                float3 w = float3(node_133,node_133,node_133)*0.5; // Light wrapping
                float3 NdotLWrap = NdotL * ( 1.0 - w );
                float3 forwardLight = max(float3(0.0,0.0,0.0), NdotLWrap + w );
                float3 backLight = max(float3(0.0,0.0,0.0), -NdotLWrap + w ) * float3(node_133,node_133,node_133);
                NdotL = max(0.0,dot( normalDirection, lightDirection ));
                float3 directDiffuse = (forwardLight+backLight) * attenColor;
                float4 _Diffuse_var = tex2D(_Diffuse,TRANSFORM_TEX(node_8742, _Diffuse));
                float3 diffuseColor = _Diffuse_var.rgb;
                float3 diffuse = directDiffuse * diffuseColor;
/// Final Color:
                float3 finalColor = diffuse + specular;
                fixed4 finalRGBA = fixed4(finalColor * 1,0);
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
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #define UNITY_PASS_SHADOWCASTER
            #define SHOULD_SAMPLE_SH ( defined (LIGHTMAP_OFF) && defined(DYNAMICLIGHTMAP_OFF) )
            #include "UnityCG.cginc"
            #include "Lighting.cginc"
            #include "UnityPBSLighting.cginc"
            #include "UnityStandardBRDF.cginc"
            #pragma fragmentoption ARB_precision_hint_fastest
            #pragma multi_compile_shadowcaster
            #pragma multi_compile LIGHTMAP_OFF LIGHTMAP_ON
            #pragma multi_compile DIRLIGHTMAP_OFF DIRLIGHTMAP_COMBINED DIRLIGHTMAP_SEPARATE
            #pragma multi_compile DYNAMICLIGHTMAP_OFF DYNAMICLIGHTMAP_ON
            #pragma multi_compile_fog
            #pragma exclude_renderers xbox360 ps3 
            #pragma target 3.0
            uniform float4 _TimeEditor;
            uniform float _BulgeScale;
            uniform float _BulgeShape;
            uniform float _Time_Wave;
            uniform float _Forme_Wave;
            struct VertexInput {
                float4 vertex : POSITION;
                float3 normal : NORMAL;
                float2 texcoord0 : TEXCOORD0;
                float2 texcoord1 : TEXCOORD1;
                float2 texcoord2 : TEXCOORD2;
            };
            struct VertexOutput {
                V2F_SHADOW_CASTER;
                float2 uv0 : TEXCOORD1;
                float2 uv1 : TEXCOORD2;
                float2 uv2 : TEXCOORD3;
                float4 posWorld : TEXCOORD4;
                float3 normalDir : TEXCOORD5;
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                o.uv1 = v.texcoord1;
                o.uv2 = v.texcoord2;
                o.normalDir = UnityObjectToWorldNormal(v.normal);
                float4 node_2541 = _Time + _TimeEditor;
                float node_4757_ang = (saturate((1.0 - (distance(o.uv0,float2(0.5,0.5))*2.0)))*_Forme_Wave*3.141592654);
                float node_4757_spd = 1.0;
                float node_4757_cos = cos(node_4757_spd*node_4757_ang);
                float node_4757_sin = sin(node_4757_spd*node_4757_ang);
                float2 node_4757_piv = float2(0.5,0.5);
                float2 node_4757 = (mul(o.uv0-node_4757_piv,float2x2( node_4757_cos, -node_4757_sin, node_4757_sin, node_4757_cos))+node_4757_piv);
                float2 node_4767 = (node_4757+(node_2541.r*_Time_Wave)*float2(1.5,1.5));
                float node_133 = pow((abs((frac(node_4767.r)-0.5))*2.0),_BulgeShape); // Panning gradient
                float node_1924 = node_133;
                v.vertex.xyz += (node_1924*_BulgeScale*v.normal);
                o.posWorld = mul(_Object2World, v.vertex);
                o.pos = mul(UNITY_MATRIX_MVP, v.vertex );
                TRANSFER_SHADOW_CASTER(o)
                return o;
            }
            float4 frag(VertexOutput i) : COLOR {
                i.normalDir = normalize(i.normalDir);
                float3 viewDirection = normalize(_WorldSpaceCameraPos.xyz - i.posWorld.xyz);
                float3 normalDirection = i.normalDir;
                SHADOW_CASTER_FRAGMENT(i)
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
            #define SHOULD_SAMPLE_SH ( defined (LIGHTMAP_OFF) && defined(DYNAMICLIGHTMAP_OFF) )
            #include "UnityCG.cginc"
            #include "Lighting.cginc"
            #include "UnityPBSLighting.cginc"
            #include "UnityStandardBRDF.cginc"
            #include "UnityMetaPass.cginc"
            #pragma fragmentoption ARB_precision_hint_fastest
            #pragma multi_compile_shadowcaster
            #pragma multi_compile LIGHTMAP_OFF LIGHTMAP_ON
            #pragma multi_compile DIRLIGHTMAP_OFF DIRLIGHTMAP_COMBINED DIRLIGHTMAP_SEPARATE
            #pragma multi_compile DYNAMICLIGHTMAP_OFF DYNAMICLIGHTMAP_ON
            #pragma multi_compile_fog
            #pragma exclude_renderers xbox360 ps3 
            #pragma target 3.0
            uniform float4 _TimeEditor;
            uniform float _BulgeScale;
            uniform sampler2D _Diffuse; uniform float4 _Diffuse_ST;
            uniform float4 _GlowColor;
            uniform float _BulgeShape;
            uniform float _GlowIntensity;
            uniform float _Tiling;
            uniform float _Time_Wave;
            uniform float _Forme_Wave;
            uniform sampler2D _Diffuse_copy; uniform float4 _Diffuse_copy_ST;
            struct VertexInput {
                float4 vertex : POSITION;
                float3 normal : NORMAL;
                float2 texcoord0 : TEXCOORD0;
                float2 texcoord1 : TEXCOORD1;
                float2 texcoord2 : TEXCOORD2;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float2 uv0 : TEXCOORD0;
                float2 uv1 : TEXCOORD1;
                float2 uv2 : TEXCOORD2;
                float4 posWorld : TEXCOORD3;
                float3 normalDir : TEXCOORD4;
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                o.uv1 = v.texcoord1;
                o.uv2 = v.texcoord2;
                o.normalDir = UnityObjectToWorldNormal(v.normal);
                float4 node_2541 = _Time + _TimeEditor;
                float node_4757_ang = (saturate((1.0 - (distance(o.uv0,float2(0.5,0.5))*2.0)))*_Forme_Wave*3.141592654);
                float node_4757_spd = 1.0;
                float node_4757_cos = cos(node_4757_spd*node_4757_ang);
                float node_4757_sin = sin(node_4757_spd*node_4757_ang);
                float2 node_4757_piv = float2(0.5,0.5);
                float2 node_4757 = (mul(o.uv0-node_4757_piv,float2x2( node_4757_cos, -node_4757_sin, node_4757_sin, node_4757_cos))+node_4757_piv);
                float2 node_4767 = (node_4757+(node_2541.r*_Time_Wave)*float2(1.5,1.5));
                float node_133 = pow((abs((frac(node_4767.r)-0.5))*2.0),_BulgeShape); // Panning gradient
                float node_1924 = node_133;
                v.vertex.xyz += (node_1924*_BulgeScale*v.normal);
                o.posWorld = mul(_Object2World, v.vertex);
                o.pos = UnityMetaVertexPosition(v.vertex, v.texcoord1.xy, v.texcoord2.xy, unity_LightmapST, unity_DynamicLightmapST );
                return o;
            }
            float4 frag(VertexOutput i) : SV_Target {
                i.normalDir = normalize(i.normalDir);
                float3 viewDirection = normalize(_WorldSpaceCameraPos.xyz - i.posWorld.xyz);
                float3 normalDirection = i.normalDir;
                UnityMetaInput o;
                UNITY_INITIALIZE_OUTPUT( UnityMetaInput, o );
                
                float4 node_2541 = _Time + _TimeEditor;
                float node_4757_ang = (saturate((1.0 - (distance(i.uv0,float2(0.5,0.5))*2.0)))*_Forme_Wave*3.141592654);
                float node_4757_spd = 1.0;
                float node_4757_cos = cos(node_4757_spd*node_4757_ang);
                float node_4757_sin = sin(node_4757_spd*node_4757_ang);
                float2 node_4757_piv = float2(0.5,0.5);
                float2 node_4757 = (mul(i.uv0-node_4757_piv,float2x2( node_4757_cos, -node_4757_sin, node_4757_sin, node_4757_cos))+node_4757_piv);
                float2 node_4767 = (node_4757+(node_2541.r*_Time_Wave)*float2(1.5,1.5));
                float node_133 = pow((abs((frac(node_4767.r)-0.5))*2.0),_BulgeShape); // Panning gradient
                float node_1924 = node_133;
                o.Emission = (_GlowColor.rgb*_GlowIntensity*node_1924);
                
                float2 node_8742_tc_rcp = float2(1.0,1.0)/float2( _Tiling, _Tiling );
                float node_8742_ty = floor(_Tiling * node_8742_tc_rcp.x);
                float node_8742_tx = _Tiling - _Tiling * node_8742_ty;
                float2 node_8742 = (i.uv0 + float2(node_8742_tx, node_8742_ty)) * node_8742_tc_rcp;
                float4 _Diffuse_var = tex2D(_Diffuse,TRANSFORM_TEX(node_8742, _Diffuse));
                float3 diffColor = _Diffuse_var.rgb;
                float4 _Diffuse_copy_var = tex2D(_Diffuse_copy,TRANSFORM_TEX(i.uv0, _Diffuse_copy));
                float3 specColor = _Diffuse_copy_var.rgb;
                float roughness = 1.0 - 1.0;
                o.Albedo = diffColor + specColor * roughness * roughness * 0.5;
                
                return UnityMetaFragment( o );
            }
            ENDCG
        }
    }
    FallBack "Diffuse"
    CustomEditor "ShaderForgeMaterialInspector"
}
