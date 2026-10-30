Shader "Cans" {
	Properties {
		[Header(Translucency)] _Translucency ("Strength", Range(0, 50)) = 1
		_TransNormalDistortion ("Normal Distortion", Range(0, 1)) = 0.1
		_TransScattering ("Scaterring Falloff", Range(1, 50)) = 2
		_TransDirect ("Direct", Range(0, 1)) = 1
		_TransAmbient ("Ambient", Range(0, 1)) = 0.2
		_TransShadow ("Shadow", Range(0, 1)) = 0.9
		_Color0 ("Color 0", Vector) = (0.7827414,1,0.3160377,0)
		[HideInInspector] __dirty ("", Float) = 1
	}
	//DummyShaderTextExporter
	SubShader{
		Tags { "RenderType" = "Opaque" }
		LOD 200

		Pass
		{
			HLSLPROGRAM
			#pragma vertex vert
			#pragma fragment frag

			float4x4 unity_ObjectToWorld;
			float4x4 unity_MatrixVP;

			struct Vertex_Stage_Input
			{
				float4 pos : POSITION;
			};

			struct Vertex_Stage_Output
			{
				float4 pos : SV_POSITION;
			};

			Vertex_Stage_Output vert(Vertex_Stage_Input input)
			{
				Vertex_Stage_Output output;
				output.pos = mul(unity_MatrixVP, mul(unity_ObjectToWorld, input.pos));
				return output;
			}

			float4 frag(Vertex_Stage_Output input) : SV_TARGET
			{
				return float4(1.0, 1.0, 1.0, 1.0); // RGBA
			}

			ENDHLSL
		}
	}
	Fallback "Diffuse"
	//CustomEditor "ASEMaterialInspector"
}