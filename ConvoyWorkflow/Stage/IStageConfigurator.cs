using ConvoyWorkflow;
using System.Collections.Generic;

namespace ConvoyWorkflow
{
    public interface IStageConfigurator
    {
        public void Configure(ref Stack<IStage> stages);
    }
}