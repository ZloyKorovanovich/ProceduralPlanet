using ComputeWorkflow.Kernel;

namespace ComputeWorkflow.Handler
{
    public class DisposableDispatcher : Dispatcher
    {
        public DisposableDispatcher(ComputeConvoy convoy, KernelData kernelData) : base(convoy, convoy.Compute, kernelData)
        {

        }

        public override void Dispatch()
        {
            base.Dispatch();
            ComputeProcessor.End(_convoy);
        }
    }
}