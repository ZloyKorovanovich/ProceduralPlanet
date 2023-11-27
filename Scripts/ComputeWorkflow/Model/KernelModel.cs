namespace ComputeWorkflow
{
    public abstract class KernelModel : IModel
    {
        protected KernelData _kernelData;

        protected IBufferModel _buffer;
        protected IParametresModel _parametres;


        public KernelData KernelData => _kernelData;
        public IBufferModel Buffer => _buffer;
        public IParametresModel Parametres => _parametres;

        public virtual void Configure(IBufferModel buffer, IParametresModel parametres)
        {
            _buffer = buffer;
            _parametres = parametres;
        }

        public virtual void Dispose()
        {
            _buffer.Dispose();
        }
    }
}