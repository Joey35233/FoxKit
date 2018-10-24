Shader "FoxShaders/tpp3DDF_MetalicBacteriaHair" {
Properties {
	MatParamIndex_0("MatParamIndex_0", Vector) = (0.0, 0.0, 0.0, 0.0)
	Anistropic_MainLightDir("Anistropic_MainLightDir", Vector) = (0.0, 0.0, 0.0, 0.0)
	Anistropic_Diffusion("Anistropic_Diffusion", Vector) = (0.0, 0.0, 0.0, 0.0)
	HairShiftScale("HairShiftScale", Vector) = (0.0, 0.0, 0.0, 0.0)
	EdgeRoughness("EdgeRoughness", Vector) = (0.0, 0.0, 0.0, 0.0)
	EdgeTrans("EdgeTrans", Vector) = (0.0, 0.0, 0.0, 0.0)
	Incidence_Roughness("Incidence_Roughness", Vector) = (0.0, 0.0, 0.0, 0.0)
	MimeticCenter("MimeticCenter", Vector) = (0.0, 0.0, 0.0, 0.0)
	MimeticRadiusMin("MimeticRadiusMin", Vector) = (0.0, 0.0, 0.0, 0.0)
	MimeticRadiusMax("MimeticRadiusMax", Vector) = (0.0, 0.0, 0.0, 0.0)
	InnerMimeticRadiusMin("InnerMimeticRadiusMin", Vector) = (0.0, 0.0, 0.0, 0.0)
	InnerMimeticRadiusMax("InnerMimeticRadiusMax", Vector) = (0.0, 0.0, 0.0, 0.0)
	MimeticRateAlphaRadiusMin("MimeticRateAlphaRadiusMin", Vector) = (0.0, 0.0, 0.0, 0.0)
	MimeticRateAlphaRadiusMax("MimeticRateAlphaRadiusMax", Vector) = (0.0, 0.0, 0.0, 0.0)
	MimeticAlphaOffseet("MimeticAlphaOffseet", Vector) = (0.0, 0.0, 0.0, 0.0)
	Incidence_Color("Incidence_Color", Vector) = (0.0, 0.0, 0.0, 0.0)
	Base_Tex_SRGB("Base_Tex_SRGB", 2D) = "white" {}
	SpecularMap_Tex_LIN("SpecularMap_Tex_LIN", 2D) = "white" {}
	Translucent_Tex_LIN("Translucent_Tex_LIN", 2D) = "white" {}
	MetalicLayer_Tex_LIN("MetalicLayer_Tex_LIN", 2D) = "white" {}
	MetalicBacteria_Tex_LIN("MetalicBacteria_Tex_LIN", 2D) = "white" {}
	_Cutoff ("Alpha cutoff", Range(0,1)) = 0.5
}

SubShader {
	Tags {"Queue"="AlphaTest" "IgnoreProjector"="True" "RenderType"="TransparentCutout"}
	LOD 400

CGPROGRAM
#pragma surface surf BlinnPhong alphatest:_Cutoff
#pragma target 3.0

sampler2D Base_Tex_SRGB;
sampler2D SpecularMap_Tex_LIN;

struct Input {
	float2 uvBase_Tex_SRGB;
	float2 uvSpecularMap_Tex_LIN;
};

void surf (Input IN, inout SurfaceOutput o) {
	fixed4 tex = tex2D(Base_Tex_SRGB, IN.uvBase_Tex_SRGB);
	o.Albedo = tex.rgb;
	o.Gloss = tex.a;
	o.Alpha = tex.a;
	fixed4 specularTex = tex2D(SpecularMap_Tex_LIN, IN.uvSpecularMap_Tex_LIN);
	o.Specular = specularTex.r;
}
ENDCG
}

FallBack "Standard"
}