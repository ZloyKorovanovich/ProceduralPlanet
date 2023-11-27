using ConvoyWorkflow;
using System.Collections.Generic;

namespace ComputeWorkflow.Configuration
{
    public class KernelConfigurator : IStageConfigurator
    {
        private KernelModel _kernelModel;
        private IStageConfigurator _assign;
        private IStageConfigurator _dispatch;

        public KernelConfigurator(KernelModel kernelModel, IStageConfigurator assign, IStageConfigurator dispatch)
        {
            _kernelModel = kernelModel;
            _assign = assign;
        }

        public virtual void Configure(ref Stack<IStage> stages)
        {
            _dispatch.Configure(ref stages);
            _assign.Configure(ref stages);
        }
    }
}