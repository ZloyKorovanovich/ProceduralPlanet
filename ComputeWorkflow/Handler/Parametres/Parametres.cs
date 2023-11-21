using UnityEngine;

namespace ComputeWorkflow.Handler
{
    public abstract class Parametres : IComputeInput
    {
        protected ComputeConvoy _convoy;

        public abstract void ToCompute();
    }
}