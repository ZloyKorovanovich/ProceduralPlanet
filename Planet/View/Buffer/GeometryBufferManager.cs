using ComputeWorkflow;
using GeometryWorkflow;

namespace Planet.View
{
    public class GeometryBufferManager : IBufferDataManager
    {
        private BufferData _vertexBuffer;
        private BufferData _triangleBuffer;
        private BufferData _uVBuffer;

        public GeometryBufferManager(BufferData vertexBuffer, BufferData triangleBuffer, BufferData uVBuffer)
        {
            _vertexBuffer = vertexBuffer;
            _triangleBuffer = triangleBuffer;
            _uVBuffer = uVBuffer;
        }

        public void SetData(GeometryData data)
        {
            _vertexBuffer.ComputeBuffer.SetData(data.Vertices);
            _triangleBuffer.ComputeBuffer.SetData(data.Triangles);
            _uVBuffer.ComputeBuffer.SetData(data.UVs);
        }

        public void GetData(GeometryData data)
        {
            _vertexBuffer.ComputeBuffer.GetData(data.Vertices);
            _triangleBuffer.ComputeBuffer.GetData(data.Triangles);
            _uVBuffer.ComputeBuffer.GetData(data.UVs);
        }
    }
}