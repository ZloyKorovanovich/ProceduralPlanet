namespace ComputeWorkflow.Stage
{
    public class AssignTexture : KernelStage
    {
        private TextureData _texture;

        public AssignTexture(TextureData texture, KernelData kernelData)
        {
            _texture = texture;
            _kernelData = kernelData;
        }

        public override void Complete()
        {
            _kernelData.Compute.SetTexture(_kernelData.ID, _texture.Name, _texture.RenderTexture);
        }
    }
}