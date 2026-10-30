Shader "CelShaded" {
	Properties {
		_ASEOutlineColor ("Outline Color", Vector) = (0,0,0,0)
		_ASEOutlineWidth ("Outline Width", Float) = 0
		_Cutoff ("Mask Clip Value", Float) = 0.5
		_TextureSample0 ("Texture Sample 0", 2D) = "white" {}
		_Color0 ("Color 0", Vector) = (0,0,0,0)
		_MainColor ("_MainColor", Vector) = (1,1,1,0)
		_TextureSample1 ("Texture Sample 1", 2D) = "white" {}
		_EmmTextureAmount ("EmmTextureAmount", Float) = 0
		[HideInInspector] _texcoord ("", 2D) = "white" {}
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