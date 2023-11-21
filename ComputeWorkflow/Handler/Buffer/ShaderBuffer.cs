using UnityEngine;

namespace ComputeWorkflow.Handler
{
    public abstract class ShaderBuffer : IComputeInput
    {
        protected string _name;
        protected ComputeConvoy _convoy;

        public ShaderBuffer(ComputeConvoy convoy, string name)
        {
            _convoy = convoy;
            _name = name;
        }

        public abstract void Dispose();
        public abstract void ToCompute();
    }
}

