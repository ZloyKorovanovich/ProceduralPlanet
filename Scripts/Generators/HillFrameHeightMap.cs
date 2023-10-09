using UnityEngine;

namespace ProceduralPlanet.Generators
{
    public struct HillHeightMapParametres
    {
        private const string _SCALE = "Scale";
        private const string _OCTAVES = "Octaves";
        private const string _PERSISTANCE = "Persistance";
        private const string _LACUNARITY = "Lacunarity";
        private const string _SEED = "Seed";

        public string NameScale => _SCALE;
        public string NameOctaves => _OCTAVES;
        public string NamePersistance => _PERSISTANCE;
        public string NameLacunarity => _LACUNARITY;
        public string NameSeed => _SEED;

        public float Scale;
        public int Octaves;
        public float Persistance;
        public float Lacunarity;
        public float Seed;

        public HillHeightMapParametres(float scale, int octaves, float persistance, float lacunarity, float seed)
        {
            Scale = scale;
            Octaves = octaves;
            Persistance = persistance;
            Lacunarity = lacunarity;
            Seed = seed;
        }
    }

    public class HillFrameHeightMap : FrameHeightMap
    {
        private HillHeightMapParametres _parametres;

        public HillFrameHeightMap(HillHeightMapParametres biomParametres, FrameHeightMapStaticParametres parametres, ComputeShader compute, string kernelName, out RenderTexture heightMap)
            : base(parametres, compute, kernelName, out heightMap)
        {
            _parametres = biomParametres;
            SetUpNoiseParametres();
        }

        private void SetUpNoiseParametres()
        {
            _compute.Shader.SetInt(_parametres.NameOctaves, _parametres.Octaves);
            _compute.Shader.SetFloat(_parametres.NameScale, _parametres.Scale);
            _compute.Shader.SetFloat(_parametres.NameLacunarity, _parametres.Lacunarity);
            _compute.Shader.SetFloat(_parametres.NamePersistance, _parametres.Persistance);
            _compute.Shader.SetFloat(_parametres.NameSeed, _parametres.Seed);
        }
    }
}
