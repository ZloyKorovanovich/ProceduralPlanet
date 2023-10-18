using UnityEngine;

namespace ProceduralPlanet.Generators
{
    public struct FrameHeightMapStaticParametres
    {
        private const string _RESOLUTION = "Resolution";

        public string NameResolution => _RESOLUTION;

        public int Resolution;
        public int Depth;

        public FrameHeightMapStaticParametres(int resolution, int depth)
        {
            Resolution = resolution;
            Depth = depth;
        }
    }

    public struct FrameHeightMapDynamicParametres
    {
        private const string _DENSITY = "_Density";
        private const string _ROTATION_MATRIX = "_RotationMatrix";

        public string NameDensity => _DENSITY;
        public string NameRotationMatrix => _ROTATION_MATRIX;

        public float Density;
        public Matrix4x4 RotationMatrix;

        public FrameHeightMapDynamicParametres(float density, Matrix4x4 rotationMatrix)
        {
            Density = density;
            RotationMatrix = rotationMatrix;
        }
    }

    public class FrameHeightMap : HeightMap
    {
        private const string _HEIGHT_MAP = "HeightMap";

        private FrameHeightMapStaticParametres _parametres;
        private RenderTexture _heightMap;

        public FrameHeightMap(FrameHeightMapStaticParametres parametres, ComputeShader compute, string kernelName, out RenderTexture heightMap) : base(compute, kernelName)
        {
            _parametres = parametres;
            CreateHeightMap();
            SetUpCompute();
            heightMap = _heightMap;
        }

        public override void GenerateHeightMap()
        {
            _compute.Dispatch(_parametres.Resolution, _parametres.Resolution, 1);
        }

        public override void ReleaseHeightMap()
        {
            _heightMap.Release();
        }

        private void CreateHeightMap()
        {
            _heightMap = new RenderTexture(_parametres.Resolution, _parametres.Resolution, _parametres.Depth);
            _heightMap.wrapMode = TextureWrapMode.Clamp;
            _heightMap.enableRandomWrite = true;
        }

        private void SetUpCompute()
        {
            _compute.Shader.SetTexture(_compute.KernelData.KernelIndex, _HEIGHT_MAP, _heightMap);
            _compute.Shader.SetInt(_parametres.NameResolution, _parametres.Resolution);
        }

        public void SetDynamicParametres(FrameHeightMapDynamicParametres parametres)
        {
            _compute.Shader.SetFloat(parametres.NameDensity, parametres.Density);
            _compute.Shader.SetMatrix(parametres.NameRotationMatrix, parametres.RotationMatrix);
        }
    }
}

