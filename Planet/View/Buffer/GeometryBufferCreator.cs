using ComputeWorkflow;
using UnityEngine;

namespace Planet.View
{
    public static class GeometryBufferCreator
    {
        private static string _VERTEX_BUFFER = "Vertices";
        private static string _TRIANGLE_BUFFER = "Triangles";
        private static string _UV_BUFFER = "UVs";

        public static void CreateVertexBuffer(int vertexCount, out BufferData buffer)
        {
            var computeBuffer = new ComputeBuffer(vertexCount, sizeof(float) * 3);
            buffer = new BufferData(computeBuffer, _VERTEX_BUFFER);
        }

        public static void CreateTriangleBuffer(int triangleCount, out BufferData buffer)
        {
            var computeBuffer = new ComputeBuffer(triangleCount, sizeof(int));
            buffer = new BufferData(computeBuffer, _TRIANGLE_BUFFER);
        }

        public static void CreateUVBuffer(int vertexCount, out BufferData buffer)
        {
            var computeBuffer = new ComputeBuffer(vertexCount, sizeof(float) * 2);
            buffer = new BufferData(computeBuffer, _UV_BUFFER);
        }
    }
}