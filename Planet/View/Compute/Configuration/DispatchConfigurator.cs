using ComputeWorkflow;
using ComputeWorkflow.Stage;
using ConvoyWorkflow;
using System;
using System.Collections.Generic;

namespace Planet.View
{
    public class DispatchConfigurator : IStageConfigurator
    {
        private KernelModel _kernelModel;
        private Action _onDispatch;

        public DispatchConfigurator(KernelModel kernel, Action onDispatch)
        {
            _kernelModel = kernel;
            _onDispatch = onDispatch;
        }

        public void Configure(ref Stack<IStage> stages)
        {
            var stage = new Dispatch(_kernelModel.KernelData, _kernelModel.DispatchSize);
            stage.OnComplete += _onDispatch;
            stages.Push(stage);
        }
    }
}

