using System;

namespace GeneratorWorkflow
{
    public abstract class Generator
    {
        public Action OnGenerated;
        public virtual void Generate()
        {
            OnGenerated?.Invoke();
        }
    }
}