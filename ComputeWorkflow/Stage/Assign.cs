namespace ComputeWorkflow.Stage
{
    public class Assign : KernelStage
    {
        private IKernelAssignable _assignable;

        public Assign(IKernelBuffer assignable, KernelData kernelData) : base(kernelData)
        {
            _assignable = assignable;
        }
        
        protected override void ExecuteWork()
        {
            _assignable.Assign(_kernelData);
        }
    }
}