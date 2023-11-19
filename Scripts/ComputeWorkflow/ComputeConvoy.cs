using UnityEngine;
using ComputeWorkflow.Handler;
using ComputeWorkflow.Kernel;

namespace ComputeWorkflow
{
    public abstract class ComputeConvoy
    {
        protected ComputeShader _compute;
        protected KernelData _kernelData;

        public ComputeShader Compute => _compute;
        public KernelData KernelData => _kernelData;

        protected Dispatcher _dispatcher;

        public ComputeConvoy(ComputeShader compute, string kernelName)
        {
            _compute = compute;
            KernelInfo.ReadKernelData(_compute, kernelName, out _kernelData);
            InitDispatcher();

            ComputeProcessor.AddConvoy(this);
        }

        public virtual void ProcessImmediately()
        {
            ParametresToCompute();
            InitBuffers();
            BuffersToCompute();

            Dispatch();
        }

        protected virtual void Dispatch()
        {
            _dispatcher.Dispatch();
        }

        protected virtual void InitDispatcher()
        {
            _dispatcher = new Dispatcher(this, _compute, _kernelData);
        }

        public abstract void End();
        protected abstract void ParametresToCompute();
        protected abstract void BuffersToCompute();
        protected abstract void InitBuffers();
    }
}