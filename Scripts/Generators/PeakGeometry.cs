using ProceduralPlanet.Generators.ExternalData;
using UnityEngine;

namespace ProceduralPlanet.Generators
{
    public class PeakGeometry : Geometry
    {
        private const string _RESOLUTION = "Resolution";
        private const string _SCALE = "Scale";

        private int _resolution;
        private GeometryBuffer _geometryBuffer;

        private GeometryData _geometryData;

        public PeakGeometry(int resolution, ComputeShader compute, string kernelName) : base(compute, kernelName)
        {
            _resolution = resolution;
        }

        public override void GenerateMesh(out Mesh mesh)
        {
            SetUpGeometryData();
            SetUpBuffer();
            SetUpCompute();
            DispatchCompute();
            ReadData();
            EndBuffer();

            GeometryProcessor.ConvertDataToMesh(_geometryData, out mesh);
        }

        private void SetUpGeometryData()
        {
            _geometryData = new GeometryData(new Vector3[_resolution * _resolution], 
                new Vector2[_resolution * _resolution], new int[(_resolution - 1) * (_resolution - 1) * 6]);
        }

        private void SetUpBuffer()
        {
            _geometryBuffer = new GeometryBuffer(_geometryData.Vertices, _geometryData.UVs, _geometryData.Triangles);
        }

        private void SetUpCompute()
        {
            _compute.Shader.SetInt(_RESOLUTION, _resolution - 1);
            _compute.Shader.SetFloat(_SCALE, 1.0f);
            _geometryBuffer.SetBuffersToCompute(_compute.Shader, _compute.KernelData.KernelIndex);
        }

        private void DispatchCompute()
        {
            _compute.Dispatch(_resolution, _resolution, _resolution);
        }

        private void ReadData()
        {
            _geometryBuffer.ReadDataFromBuffers(ref _geometryData);
        }

        private void EndBuffer()
        {
            _geometryBuffer.Dispose();
        }
    }
}
