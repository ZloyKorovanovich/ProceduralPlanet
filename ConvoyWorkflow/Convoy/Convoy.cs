using System.Collections.Generic;

namespace ConvoyWorkflow
{
    public class Convoy
    {
        private bool _isActive;
        private Stack<IStage> _stages;

        public bool IsActive => _isActive;

        public void Configure(Stack<IStage> stages)
        {
            _stages = stages;
        }

        public bool CompleteStage()
        {
            if (!_isActive)
                return false;

            if(_stages.TryPop(out IStage stage))
            {
                stage.Complete();
                return true;
            }

            return false;
        }

        public void SetActive(bool active)
        {
            _isActive = active;
        }
    }
}