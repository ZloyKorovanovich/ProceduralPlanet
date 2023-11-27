using ComputeWorkflow;
using ComputeWorkflow.Configuration;
using ConvoyWorkflow;

namespace Planet.View
{
    public class ComputeConfigurator : KernelConfigurator
    {
        public ComputeConfigurator(KernelModel kernelModel, IStageConfigurator assign, IStageConfigurator dispatch)
            : base(kernelModel, assign, dispatch)
        {
            
        }
    }
}