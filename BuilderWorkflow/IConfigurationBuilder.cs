using ConvoyWorkflow;

namespace BuilderWorkflow
{
    public interface IConfigurationBuilder : IBuilder
    {
        public void ConstructConfiguartor(out IStageConfigurator configurator);
    }
}