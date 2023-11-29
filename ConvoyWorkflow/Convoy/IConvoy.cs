namespace ConvoyWorkflow
{
    public interface IConvoy
    {
        public bool CompleteStage();
        public void Run();
        public void Release();
    }
}