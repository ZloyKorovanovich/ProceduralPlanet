using ConvoyWorkflow;
using System.Collections.Generic;

namespace GeneratorWorkflow
{
    public class ComputeGenerator : Generator
    {
        private IStageConfigurator _configurator;

        public ComputeGenerator(IStageConfigurator configurator)
        {
            _configurator = configurator;
        }

        public override void Generate()
        {
            Stack<IStage> stages = new Stack<IStage>();
            _configurator.Configure(ref stages);

            ServiceLocator.ComputeProcessor.ConfigureConvoy(stages, out IConvoy convoy);
            while (convoy.CompleteStage()) ;
            convoy.Release();

            base.Generate();
        }
    }
}