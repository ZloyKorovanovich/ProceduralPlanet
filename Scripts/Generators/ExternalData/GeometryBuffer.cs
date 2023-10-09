using UnityEngine;

namespace ProceduralPlanet.Generators.ExternalData
{
    public class GeometryBuffer
    {
        private const string _VERTEX_BUFFER = "Vertices";
        private const string _UV_BUFFER = "UVs";
        private const string _TRIANGLE_BUFFER = "Triangles";

        private ComputeBuffer _vertexBuffer;
        private ComputeBuffer _uVBuffer;
        private ComputeBuffer _triangleBuffer;

        public GeometryBuffer(Vector3[] vertices, Vector2[] uVs, int[] triangles)
        {
            _vertexBuffer = new ComputeBuffer(vertices.Length, sizeof(float) * 3);
            _uVBuffer = new ComputeBuffer(uVs.Length, sizeof(float) * 2);
            _triangleBuffer = new ComputeBuffer(triangles.Length, sizeof(int));

            _vertexBuffer.SetData(vertices);
            _uVBuffer.SetData(uVs);
            _triangleBuffer.SetData(triangles);
        }

        public void SetBuffersToCompute(ComputeShader compute, int kernelId)
        {
            compute.SetBuffer(kernelId, _VERTEX_BUFFER, _vertexBuffer);
            compute.SetBuffer(kernelId, _UV_BUFFER, _uVBuffer);
            compute.SetBuffer(kernelId, _TRIANGLE_BUFFER, _triangleBuffer);
        }

        public void ReadDataFromBuffers(ref GeometryData data)
        {
            _vertexBuffer.GetData(data.Vertices);
            _uVBuffer.GetData(data.UVs);
            _triangleBuffer.GetData(data.Triangles);
        }

        public void Dispose()
        {
            if (_vertexBuffer.IsValid())
                _vertexBuffer.Release();
            if (_uVBuffer.IsValid())
                _uVBuffer.Release();
            if (_triangleBuffer.IsValid())
                _triangleBuffer.Release();
        }
    }
}