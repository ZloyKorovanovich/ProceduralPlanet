using System.Collections.Generic;

namespace ConvoyWorkflow
{
    public class DirectConvoy : IConvoy
    {
        private Stack<IStage> _stages;
        private bool _isActive;

        public bool IsActive => _isActive;

        public void Configure(Stack<IStage> stages)
        {
            _stages = stages;
        }

        public bool CompleteStage()
        {
            if(_stages.TryPop(out IStage stage))
            {
                stage.Complete();
                return true;
            }

            return false;
        }

        public void Release()
        {
            _isActive = false;
        }

        public void Run()
        {
            _isActive = true;
        }
    }
}