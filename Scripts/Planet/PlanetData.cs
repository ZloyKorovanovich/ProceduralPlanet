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
        private Compute _meshCompute;
        [SerializeField]
        private Geometry _mesh;

        public General General => _general;
        public Compute HeightMapCompute => _heightMapCompute;
        public TextureMap HeightMap => _heightMap;
        public Compute MeshCompute => _meshCompute;
        public Geometry Mesh => _mesh;
    }
}