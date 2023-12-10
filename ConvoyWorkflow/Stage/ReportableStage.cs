using System;

namespace ConvoyWorkflow.Stage
{
    public abstract class ReportableStage : IStage
    {
        public Action OnStarted;
        public Action OnCompleted;

        protected void Started()
        {
            OnStarted?.Invoke();
        }

        protected void Completed()
        {
            OnCompleted?.Invoke();
        }

        public abstract void Complete();
    }
}