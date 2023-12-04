using BuilderWorkflow;
using ComputeWorkflow;

namespace Planet.View
{
    public class GeometryBufferBuilder : IBuilder
    {
        private BufferData _vertexBuffer;
        private BufferData _triangleBuffer;
        private BufferData _uVBuffer;

        public GeometryBufferBuilder(BufferData vertexBuffer, BufferData triangleBuffer, BufferData uVBuffer)
        {
            _vertexBuffer = vertexBuffer;
            _triangleBuffer = triangleBuffer;
            _uVBuffer = uVBuffer;
        }

        public void ConstructModel(out GeometryBuffer model)
        {
            model = new GeometryBuffer(_vertexBuffer, _triangleBuffer, _uVBuffer);
        }
    }
}