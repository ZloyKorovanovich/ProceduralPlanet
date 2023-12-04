using System;

namespace GeneratorWorkflow
{
    public abstract class Generator
    {
        public Action OnGenerate;

        public virtual void Generate()
        {
            OnGenerate?.Invoke();
        }
    }
}