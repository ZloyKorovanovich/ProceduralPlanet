using ConvoyWorkflow;
using System;

namespace ComputeWorkflow.Stage
{
    public abstract class KernelStage : IStage
    {
        protected KernelData _kernelData;
        protected Action _onComplete;

        public void FollowAction(Action action)
        {
            _onComplete += action;
        }

        public void UnFollowAction(Action action)
        {
            _onComplete -= action;
        }

        public virtual void Complete()
        {
            _onComplete?.Invoke();
        }
    }
}