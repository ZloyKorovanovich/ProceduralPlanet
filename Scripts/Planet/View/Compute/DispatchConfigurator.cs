using ComputeWorkflow;
using ComputeWorkflow.Stage;
using ConvoyWorkflow;
using System.Collections.Generic;

namespace Planet.View
{
    public class DispatchConfigurator : IStageConfigurator
    {
        private KernelData _kernelData;
        private ThreadSize _threadSize;

        public DispatchConfigurator(KernelData kernelData, ThreadSize threadSize)
        {
            _kernelData = kernelData;
            _threadSize = threadSize;
        }

        public void Configure(ref Stack<IStage> stages)
        {
            stages.Push(new Dispatch(_kernelData, _threadSize));
        }
    }
}

