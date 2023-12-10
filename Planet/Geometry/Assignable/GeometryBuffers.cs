using ComputeWorkflow;
using GeometryWorkflow;
using UnityEngine;

namespace Planet.Geometry
{
    public class GeometryBuffers : IKernelBuffer
    {
        private const string _NAME_VERTICES = "Vertices";
        private const string _NAME_TRIANGLES = "Triangles";
        private const string _NAME_UVS = "UVs";

        private ComputeBuffer _vertices;
        private ComputeBuffer _triangles;
        private ComputeBuffer _uVs;

        public GeometryBuffers(int vertexCount, int triangleCount)
        {
            _vertices = new ComputeBuffer(vertexCount, sizeof(float) * 3);
            _triangles = new ComputeBuffer(triangleCount, sizeof(int));
            _uVs = new ComputeBuffer(vertexCount, sizeof(float) * 2);
        }

        public void SetData(ref GeometryData geometryData)
        {
            _vertices.SetData(geometryData.Vertices);
            _triangles.SetData(geometryData.Triangles);
            _uVs.SetData(geometryData.UVs);
        }

        public void GetData(ref GeometryData geometryData)
        {
            _vertices.GetData(geometryData.Vertices);
            _triangles.GetData(geometryData.Triangles);
            _uVs.GetData(geometryData.UVs);
        }

        public void Assign(KernelData kernel)
        {
            kernel.Compute.SetBuffer(kernel.ID, _NAME_VERTICES, _vertices);
            kernel.Compute.SetBuffer(kernel.ID, _NAME_TRIANGLES, _triangles);
            kernel.Compute.SetBuffer(kernel.ID, _NAME_UVS, _uVs);
        }

        public void Dispose()
        {
            _vertices?.Release();
            _triangles?.Release();
            _uVs?.Release();
        }
    }
}