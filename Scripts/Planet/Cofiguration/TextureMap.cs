using UnityEngine;

namespace Planet.Configuration
{
    [System.Serializable]
    public class TextureMap
    {
        private enum TextureResolution : int
        {
            Resolution_64x64 = 64,
            Resolution_128x128 = 128,
            Resolution_256x256 = 256,
            Resolution_512x512 = 512,
            Resolution_1024x1024 = 1024
        }
        
        private enum TextureDepth : int
        {
            Depth_16 = 16,
            Depth_24 = 24,
            Depth_32 = 32
        }

        [SerializeField]
        private TextureResolution _resolution = TextureResolution.Resolution_256x256;
        [SerializeField]
        private TextureDepth _depth = TextureDepth.Depth_16;

        public int Resolution => (int)_resolution;
        public int Depth => (int)_depth;
    }
}