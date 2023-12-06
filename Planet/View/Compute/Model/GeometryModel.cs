using ComputeWorkflow;

namespace Planet.View
{
    public class GeometryModel : IModel
    {
        private KernelModel _kernel;
        private GeometryBuffer _buffer;
        private GeometryParametres _parametres;

        public KernelModel KernelModel => _kernel;
        public GeometryBuffer BufferModel => _buffer;
        public GeometryParametres ParametresModel => _parametres;

        public GeometryModel(KernelModel kernel, GeometryBuffer buffer, GeometryParametres parametres)
        {
            _kernel = kernel;
            _parametres = parametres;
            _buffer = buffer;
        }
    }
}