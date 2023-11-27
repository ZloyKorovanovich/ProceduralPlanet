namespace ComputeWorkflow.Stage
{
    public class AssignBuffer : KernelStage
    {
        private BufferData _buffer;

        public AssignBuffer(BufferData buffer, KernelData kernelData)
        {
            _buffer = buffer;
            _kernelData = kernelData;
        }
        
        public override void Complete()
        {
            _kernelData.Compute.SetBuffer(_kernelData.ID, _buffer.Name, _buffer.ComputeBuffer);
        }
    }
}