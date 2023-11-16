using UnityEngine;

namespace ProceduralPlanet.Parametres.Visualisation
{
    [System.Serializable]
    public class Geometry
    {
        enum MeshResolution : int
        {
            Resolution_8x8 = 8,
            Resolution_16x16 = 16,
            Resolution_32x32 = 32,
            Resolution_64x64 = 64,
            Resolution_128x128 = 128,
            Resolution_256x256 = 256,
            Resolution_512x512 = 512
        }

        [SerializeField]
        private MeshResolution _resolution = MeshResolution.Resolution_128x128;

        public int Resolution => (int)_resolution;
    }
}
