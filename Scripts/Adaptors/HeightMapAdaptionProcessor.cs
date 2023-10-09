using UnityEngine;

namespace ProceduralPlanet.Adaptors
{
    public static class HeightMapAdaptionProcessor
    {
        public static Generators.HillFrameHeightMap FillHillHeightMapGenerator(Parametres.Generation.Biom biom, 
            Parametres.Visualisation.HeightMap heightMap, Parametres.Generation.Landscape landscape, 
            Parametres.CalculatingComponents.Compute calculting, out RenderTexture heightMapResult)
        {
            return new Generators.HillFrameHeightMap(ConfigureHillHeightMapParametres(biom, landscape.Seed),
                ConfigureFrameHeightMapStaticParametres(heightMap), calculting.ComputeShader, calculting.KernelName, out heightMapResult);
        }
        public static Generators.FrameHeightMapDynamicParametres ConfigureFrameHeightMapDynamicParametres(Vector3 start, Vector3 endX, Vector3 endY, Vector3 peak)
        {
            return new Generators.FrameHeightMapDynamicParametres(start, endX, endY, peak);
        }

        private static Generators.FrameHeightMapStaticParametres ConfigureFrameHeightMapStaticParametres(Parametres.Visualisation.HeightMap parametres)
        {
            return new Generators.FrameHeightMapStaticParametres(parametres.Resolution, parametres.Depth);
        }
        private static Generators.HillHeightMapParametres ConfigureHillHeightMapParametres(Parametres.Generation.Biom parametres, float seed)
        {
            return new Generators.HillHeightMapParametres(parametres.Scale, parametres.Octaves, parametres.Persistance, parametres.Lacunarity, seed);
        }
    }
}