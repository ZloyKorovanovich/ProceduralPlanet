namespace ComputeWorkflow.Stage
{
    public class AssignTexture : KernelStage
    {
        private TextureData _texture;

        public AssignTexture(TextureData texture, KernelData kernelData) : base(kernelData)
        {
            _texture = texture;
        }

        public override void Complete()
        {
            _kernelData.Compute.SetTexture(_kernelData.ID, _texture.Name, _texture.RenderTexture);
            base.Complete();
        }
    }
}