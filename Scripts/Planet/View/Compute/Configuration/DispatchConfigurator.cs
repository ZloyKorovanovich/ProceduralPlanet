using ComputeWorkflow;
using ComputeWorkflow.Stage;
using ConvoyWorkflow;
using System.Collections.Generic;

namespace Planet.View
{
    public class DispatchConfigurator : IStageConfigurator
    {
        private KernelModel _kernelModel;

        public DispatchConfigurator(KernelModel kernelModel)
        {
            _kernelModel = kernelModel;
        }

        public void Configure(ref Stack<IStage> stages)
        {
            stages.Push(new Dispatch(_kernelModel.KernelData, _kernelModel.DispatchSize));
        }
    }
}

