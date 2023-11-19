using UnityEngine;

namespace ComputeWorkflow.Handler
{
    public abstract class RWBuffer : ShaderBuffer
    {
        protected ComputeBuffer _buffer;

        public RWBuffer(ComputeConvoy convoy, string name, int count, int stride) : base(convoy, name)
        {
            _buffer = new ComputeBuffer(count, stride);
        }

        public override void Dispose()
        {
            if(_buffer != null)
                _buffer.Release();
        }

        public override void ToCompute()
        {
            _convoy.Compute.SetBuffer(_convoy.KernelData.KernelId, _name, _buffer);
        }

        public abstract void ReadData();
    }
}