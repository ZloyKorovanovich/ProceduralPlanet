using ConvoyWorkflow;
using System.Collections.Generic;

namespace ComputeWorkflow.Configuration
{
    public class KernelConfigurator : IStageConfigurator
    {
        private IStageConfigurator _assign;
        private IStageConfigurator _dispatch;

        public KernelConfigurator(IStageConfigurator assign, IStageConfigurator dispatch)
        {
            _assign = assign;
        }

        public virtual void Configure(ref Stack<IStage> stages)
        {
            _dispatch.Configure(ref stages);
            _assign.Configure(ref stages);
        }
    }
}