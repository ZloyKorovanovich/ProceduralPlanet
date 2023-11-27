namespace ComputeWorkflow
{
    public abstract class KernelModel : IModel
    {
        protected KernelData _kernelData;
        protected ThreadSize _dispatchSize;

        public KernelData KernelData => _kernelData;
        public ThreadSize DispatchSize => _dispatchSize;

        public KernelModel(KernelData kernelData, ThreadSize dispatchDimension)
        {
            _kernelData = kernelData;
            _dispatchSize = dispatchDimension;
        }
    }
}