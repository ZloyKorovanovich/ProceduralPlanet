namespace ComputeWorkflow.Stage
{
    public class AssignBuffer : KernelStage
    {
        private BufferData _buffer;

        public AssignBuffer(BufferData buffer, KernelData kernelData) : base(kernelData)
        {
            _buffer = buffer;
        }
        
        public override void Complete()
        {
            _kernelData.Compute.SetBuffer(_kernelData.ID, _buffer.Name, _buffer.ComputeBuffer);
            base.Complete();
        }
    }
}