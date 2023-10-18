using ProceduralPlanet.Parametres.CalculatingComponents;
using ProceduralPlanet.Parametres.Generation;
using ProceduralPlanet.Parametres.Visualisation;
using UnityEngine;

namespace ProceduralPlanet.Parametres
{
    [System.Serializable]
    public class PlanetConfiguration
    {
        [Header("Generation")]
        [SerializeField]
        private General _general;
        [SerializeField]
        private Landscape _landscape;
        [SerializeField]
        private Biom _biom;

        [Header("Visualisation")]
        [SerializeField]
        private Compute _geometryCompute;
        [SerializeField]
        private Geometry _geometry;
        [SerializeField]
        private Compute _heightMapCompute;
        [SerializeField]
        private HeightMap _heightMap;
        [SerializeField]
        private MaterialParametres _materialParametres;
        [SerializeField]
        private Detalisation _detalisationParametres;

        public General General => _general;
        public Landscape Landscape => _landscape;
        public Biom Biom => _biom;
        public Compute GeometryCompute => _geometryCompute;
        public Compute HeightMapCompute => _heightMapCompute;
        public Geometry Geometry => _geometry;
        public HeightMap HeightMap => _heightMap;
        public MaterialParametres Material => _materialParametres;
        public Detalisation Detalisation => _detalisationParametres;
    }
}

