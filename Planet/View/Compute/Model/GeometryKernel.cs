using ComputeWorkflow;

namespace Planet.View
{
    public class GeometryKernel : KernelModel
    {
        private GeometryBuffer _buffer;
        private GeometryParametres _parametres;

        public GeometryBuffer Buffer => _buffer;
        public GeometryParametres Parametres => _parametres;

        public GeometryKernel(KernelData kernelData, ThreadSize threadSize, 
            GeometryBuffer buffer, GeometryParametres parametres) : base(kernelData, threadSize)
        {
            _buffer = buffer;
            _parametres = parametres;
        }
    }
}