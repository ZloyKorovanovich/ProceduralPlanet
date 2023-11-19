using ComputeWorkflow.Kernel;
using UnityEngine;

namespace ComputeWorkflow.Handler
{
    public class Dispatcher
    {
        protected ComputeConvoy _convoy;
        protected ComputeShader _compute;
        protected KernelData _kernelData;

        public Dispatcher(ComputeConvoy convoy, ComputeShader compute, KernelData kernelData)
        {
            _convoy = convoy;
            _compute = compute;
            _kernelData = kernelData;
        }

        public virtual void Dispatch()
        {
            _compute.Dispatch(_kernelData.KernelId, _kernelData.XSize, _kernelData.YSize, _kernelData.ZSize);
        }
    }
}