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
        private const string _START = "Start";
        private const string _END_X = "EndX";
        private const string _END_Y = "EndY";
        private const string _PEAK = "Peak";

        public string NameStart => _START;
        public string NameEndX => _END_X;
        public string NameEndY => _END_Y;
        public string NamePeak => _PEAK;

        public Vector3 Start;
        public Vector3 EndX;
        public Vector3 EndY;
        public Vector3 Peak;

        public FrameHeightMapDynamicParametres(Vector3 start, Vector3 endX, Vector3 endY, Vector3 peak)
        {
            Start = start;
            EndX = endX;
            EndY = endY;
            Peak = peak;
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
            _compute.Shader.SetVector(parametres.NameStart, parametres.Start);
            _compute.Shader.SetVector(parametres.NameEndX, parametres.EndX);
            _compute.Shader.SetVector(parametres.NameEndY, parametres.EndY);
            _compute.Shader.SetVector(parametres.NamePeak, parametres.Peak);
        }
    }
}

