using Planet.Configuration;
using UnityEngine;

namespace Planet
{
    [CreateAssetMenu(fileName = "New Planet", menuName = "Modules/Planet")]
    public class PlanetData : ScriptableObject
    {
        [SerializeField]
        private General _general;
        [SerializeField]
        private Compute _heightMapCompute;
        [SerializeField]
        private TextureMap _heightMap;
        [SerializeField]
        private Compute _geometryCompute;
        [SerializeField]
        private Geometry _geometry;

        public General General => _general;
        public Compute HeightMapCompute => _heightMapCompute;
        public TextureMap HeightMap => _heightMap;
        public Compute GeometryCompute => _geometryCompute;
        public Geometry Geometry => _geometry;
    }
}