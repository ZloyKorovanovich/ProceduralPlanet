using ComputeWorkflow.Stage;
using ConvoyWorkflow;
using System.Collections.Generic;

namespace ComputeWorkflow
{
    public abstract class KernelConfigurator : IStageConfigurator
    {
        protected KernelData _kernelData;
        protected ThreadSize _threadSize;

        public KernelConfigurator(KernelData kernelData, ThreadSize threadSize)
        {
            _kernelData = kernelData;
            _threadSize = threadSize;
        }

        public virtual void Configure(ref Stack<IStage> stages)
        {
            stages.Push(new Dispatch(_kernelData, _threadSize));
        }
    }
}