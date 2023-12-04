namespace Planet.View
{
    public class GeometryModel : IModel
    {
        private GeometryKernel _kernel;
        private GeometryBuffer _buffer;
        private GeometryParametres _parametres;

        public GeometryKernel KernelModel => _kernel;
        public GeometryBuffer BufferModel => _buffer;
        public GeometryParametres ParametresModel => _parametres;

        public GeometryModel(GeometryKernel kernel, GeometryBuffer buffer, GeometryParametres parametres)
        {
            _kernel = kernel;
            _parametres = parametres;
            _buffer = buffer;
        }
    }
}