using ComputeWorkflow;

namespace Planet.View
{
    public class GeometryBuffer : IBufferModel
    {
        private BufferData _vertexBuffer;
        private BufferData _triangleBuffer;
        private BufferData _uVBuffer;

        public BufferData VertexBuffer => _vertexBuffer;
        public BufferData TriangleBuffer => _triangleBuffer;
        public BufferData UVBuffer => _uVBuffer;

        public void Dispose()
        {
            _vertexBuffer.ComputeBuffer.Dispose();
            _triangleBuffer.ComputeBuffer.Dispose();
            _uVBuffer.ComputeBuffer.Dispose();
        }
    }
}