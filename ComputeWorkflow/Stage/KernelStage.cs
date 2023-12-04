using ConvoyWorkflow.Stage;

namespace ComputeWorkflow.Stage
{
    public abstract class KernelStage : ReportableStage
    {
        protected KernelData _kernelData;

        public KernelStage(KernelData kernelData)
        {
            _kernelData = kernelData;
        }
    }
}