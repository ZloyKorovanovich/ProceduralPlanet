using ConvoyWorkflow;
using System.Collections.Generic;

namespace ComputeWorkflow
{
    public class ComputeManager
    {
        private IStageConfigurator _configurator;

        public ComputeManager(IStageConfigurator configurator)
        {
            _configurator = configurator;
        }

        public void Generate()
        {
            Stack<IStage> stages = new Stack<IStage>();
            _configurator.Configure(ref stages);

            ServiceLocator.ComputeProcessor.ConfigureConvoy(stages, out IConvoy convoy);
            while (convoy.CompleteStage()) ;
            convoy.Release();
        }
    }
}