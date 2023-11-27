using ConvoyWorkflow;

namespace ComputeWorkflow.Stage
{
    public abstract class KernelStage : IStage
    {
        protected KernelData _kernelData;

        public abstract void Complete();
    }
}