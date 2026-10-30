Shader "Water" {
	Properties {
		_SpecColor ("Specular Color", Vector) = (1,1,1,1)
		_Color0 ("Color 0", Vector) = (0,0,0,0)
		_EmissionTexture ("Emission Texture", 2D) = "white" {}
		_EmmTextureAmount ("EmmTextureAmount", Float) = 0
		_Float1 ("Float 1", Float) = 0.29
		_Ramp ("Ramp", 2D) = "white" {}
		_NormalMap ("Normal Map", 2D) = "white" {}
		_Tint ("Tint", Vector) = (1,1,1,0)
		_WaterSpeed ("WaterSpeed", Float) = 1
		_Scale ("Scale", Float) = 5
		_Slimness ("Slimness", Float) = 2
		_RippleColor ("RippleColor", Vector) = (0.759434,0.9474553,1,0)
		_Color1 ("Color 1", Vector) = (0.1839623,0.5964688,1,0)
		_Gloss ("Gloss", Float) = 50
		_Opacity ("Opacity", Float) = 0
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