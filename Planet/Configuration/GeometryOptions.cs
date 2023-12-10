using UnityEngine;

namespace Planet.Configuration
{
    public enum MeshResolution
    {
        Res_32x32 = 32,
        Res_64x64 = 64,
        Res_128x128 = 128
    }

    [System.Serializable]
    public class GeometryOptions
    {
        [SerializeField]
        private ComputeOptions _compute;
        [SerializeField]
        private MeshResolution _resolution = MeshResolution.Res_64x64;

        public ComputeOptions Compute => _compute;
        public int Resolution => (int)_resolution;
    }
}