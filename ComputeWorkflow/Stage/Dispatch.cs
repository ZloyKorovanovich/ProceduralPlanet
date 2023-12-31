namespace ComputeWorkflow.Stage
{
    public class Dispatch : KernelStage
    {
        private ThreadSize _threadSize;

        public Dispatch(KernelData kernelData, ThreadSize threadSize) : base(kernelData)
        {
            _threadSize = threadSize;
        }

        protected override void ExecuteWork()
        {
            var dispSize = new ThreadSize(_threadSize.X / _kernelData.ThreadSize.X, 
                _threadSize.Y / _kernelData.ThreadSize.Y, _threadSize.Z / _kernelData.ThreadSize.Z);
            _kernelData.Compute.Dispatch(_kernelData.ID, dispSize.X, dispSize.Y, dispSize.Z);
        }
    }
}