using ConvoyWorkflow;

namespace ComputeWorkflow
{
    public class Dispose : IStage
    {
        private IKernelBuffer _kernelBuffer;

        public Dispose(IKernelBuffer kernelBuffer)
        {
            _kernelBuffer = kernelBuffer;
        }

        public void Complete()
        {
            _kernelBuffer.Dispose();
        }
    }
}
