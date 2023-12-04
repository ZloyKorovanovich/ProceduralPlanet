using System;

namespace ConvoyWorkflow.Stage
{
    public abstract class ReportableStage : IStage
    {
        public Action OnComplete;

        public virtual void Complete()
        {
            OnComplete?.Invoke();
        }
    }
}