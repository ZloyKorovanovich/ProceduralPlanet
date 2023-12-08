using ComputeWorkflow;

namespace Planet.Geometry
{
    public class GeometryParametres : IKernelParametres
    {
        private const string _NAME_RESOLUTION = "Resolution";
        private const string _NAME_SCALE = "Scale";

        private int _resolution;
        private float _scale;

        public GeometryParametres(int resolution, float scale)
        {
            _resolution = resolution;
            _scale = scale;
        }

        public void Assign(KernelData kernel)
        {
            kernel.Compute.SetInt(_NAME_RESOLUTION, _resolution);
            kernel.Compute.SetFloat(_NAME_SCALE, _scale);
        }
    }
}