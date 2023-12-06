using BuilderWorkflow;
using ComputeWorkflow;

namespace Planet.View
{
    public class GeometryModelBuilder : IBuilder
    {
        private KernelModel _kernel;
        private GeometryBuffer _buffer;
        private GeometryParametres _parametres;

        public void ConstructGeometryModel(out GeometryModel model)
        {
            model = new GeometryModel(_kernel, _buffer, _parametres);
        }

        public void ConstructKernelModel(KernelData kernelData, ThreadSize dispatchSize)
        {
            _kernel = new KernelModel(kernelData, dispatchSize);
        }

        public void ConstructBufferModel(BufferData vertexBuffer, BufferData triangleBuffer, BufferData uVBuffer)
        {
            _buffer = new GeometryBuffer(vertexBuffer, triangleBuffer, uVBuffer);
        }

        public void ConstructParametresModel(int resolution, float scale)
        {
            _parametres = new GeometryParametres(resolution, scale);
        }
    }
}