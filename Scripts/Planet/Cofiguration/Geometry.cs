using UnityEngine;

namespace Planet.Configuration
{
    [System.Serializable]
    public class Geometry
    {
        private enum MeshResolution : int
        {
            Resolution_32x32 = 32,
            Resolution_64x64 = 64,
            Resolution_128x128 = 128,
            Resolution_256x256 = 256,
            Resolution_512x512 = 512
        }

        [SerializeField]
        private MeshResolution _meshResolution = MeshResolution.Resolution_128x128;

        public int Resolution => (int)_meshResolution;
    }
}