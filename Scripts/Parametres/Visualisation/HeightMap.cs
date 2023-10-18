using UnityEngine;

namespace ProceduralPlanet.Parametres.Visualisation
{
    [System.Serializable]
    public class HeightMap
    {
        enum HeightMapResolution : int
        {
            Resolution_64x64 = 64,
            Resolution_128x128 = 128,
            Resolution_256x256 = 256,
            Resolution_512x512 = 512,
            Resolution_1024x1024 = 1024,
            Resolution_2048x2048 = 2048,
            Resolution_4096x4096 = 4096,
            Resolution_8192x8192 = 8192,
        }
        enum HeightMapDepth : int
        {
            Depth_16 = 16,
            Depth_32 = 32
        }

        [SerializeField]
        private HeightMapResolution _resolution = HeightMapResolution.Resolution_512x512;
        [SerializeField]
        private HeightMapDepth _depth = HeightMapDepth.Depth_16;

        public int Resolution => (int)_resolution;
        public int Depth => (int)_depth;
    }
}
