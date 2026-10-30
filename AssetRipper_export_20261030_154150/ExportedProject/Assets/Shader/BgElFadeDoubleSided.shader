Shader "BgElFadeDoubleSided" {
	Properties {
		_Color0 ("Color 0", Vector) = (0,0,0,0)
		_TransitionDistance ("Transition Distance", Float) = 5.1
		_Cutoff ("Mask Clip Value", Float) = 0.5
		_EmissionTexture ("Emission Texture", 2D) = "white" {}
		_Float0 ("Float 0", Float) = 13.46
		_EmmTextureAmount ("EmmTextureAmount", Float) = 0
		_Float1 ("Float 1", Float) = 0.29
		_Ramp ("Ramp", 2D) = "white" {}
		_NormalMap ("Normal Map", 2D) = "bump" {}
		_MainTex ("_MainTex", 2D) = "white" {}
		_Tint ("Tint", Vector) = (1,1,1,0)
		_palette1 ("palette", 2D) = "white" {}
		_NormalStrength ("Normal Strength", Float) = 1
		_Color1 ("Color 1", Vector) = (1,1,1,0)
		_CloseUpFade ("CloseUpFade", Float) = 0
		_GraffitiOverlay ("GraffitiOverlay", Vector) = (0,0,0,0)
		_Graffiti ("Graffiti", 2D) = "black" {}
		_Graffiti2 ("Graffiti 2", 2D) = "black" {}
		_Graffiti3 ("Graffiti 3", 2D) = "black" {}
		_Graffiti4 ("Graffiti 4", 2D) = "black" {}
		_TextureSample0 ("Texture Sample 0", 2D) = "black" {}
		[HideInInspector] _texcoord ("", 2D) = "white" {}
		[HideInInspector] __dirty ("", Float) = 1
		[Header(Forward Rendering Options)] [ToggleOff] _SpecularHighlights ("Specular Highlights", Float) = 1
	}
	//DummyShaderTextExporter
	SubShader{
		Tags { "RenderType"="Opaque" }
		LOD 200

		Pass
		{
			HLSLPROGRAM
			#pragma vertex vert
			#pragma fragment frag

			float4x4 unity_ObjectToWorld;
			float4x4 unity_MatrixVP;
			float4 _MainTex_ST;

			struct Vertex_Stage_Input
			{
				float4 pos : POSITION;
				float2 uv : TEXCOORD0;
			};

			struct Vertex_Stage_Output
			{
				float2 uv : TEXCOORD0;
				float4 pos : SV_POSITION;
			};

			Vertex_Stage_Output vert(Vertex_Stage_Input input)
			{
				Vertex_Stage_Output output;
				output.uv = (input.uv.xy * _MainTex_ST.xy) + _MainTex_ST.zw;
				output.pos = mul(unity_MatrixVP, mul(unity_ObjectToWorld, input.pos));
				return output;
			}

			Texture2D<float4> _MainTex;
			SamplerState sampler_MainTex;

			struct Fragment_Stage_Input
			{
				float2 uv : TEXCOORD0;
			};

			float4 frag(Fragment_Stage_Input input) : SV_TARGET
			{
				return _MainTex.Sample(sampler_MainTex, input.uv.xy);
			}

			ENDHLSL
		}
	}
	Fallback "Diffuse"
	//CustomEditor "ASEMaterialInspector"
}