using ProceduralPlanet.Adaptors;
using UnityEngine;

namespace ProceduralPlanet.Components.Handlers
{
    public class HeightMapHandler
    {
        private Parametres.CalculatingComponents.Compute _computeParametres;
        private Parametres.Generation.Biom _biomParametres;
        private Parametres.Generation.Landscape _landscapeParametres;
        private Parametres.Visualisation.HeightMap _parametres;
        private RenderTexture _heightMap;

        private Generators.HillFrameHeightMap _heightMapGenerator;

        public RenderTexture HeightMap => _heightMap;

        public HeightMapHandler(Parametres.CalculatingComponents.Compute computeParametres, Parametres.Generation.Biom biomParametres,
            Parametres.Generation.Landscape landscapeParametres, Parametres.Visualisation.HeightMap parametres)
        {
            _computeParametres = computeParametres;
            _biomParametres = biomParametres;
            _landscapeParametres = landscapeParametres;
            _parametres = parametres;
            SetUpGenerator();
        }

        public void GenerateHeightMap()
        {
            _heightMapGenerator.GenerateHeightMap();
        }

        private void SetUpGenerator()
        {
            _heightMapGenerator = HeightMapAdaptionProcessor.FillHillHeightMapGenerator(_biomParametres, _parametres, _landscapeParametres, _computeParametres, out _heightMap);
        }

        public void SetDynamicParametres(float density, Matrix4x4 rotationMatrix)
        {
            _heightMapGenerator.SetDynamicParametres(new Generators.FrameHeightMapDynamicParametres(density, rotationMatrix));
        }
    }
}
