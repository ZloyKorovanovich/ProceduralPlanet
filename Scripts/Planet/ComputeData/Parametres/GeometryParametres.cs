using ComputeWorkflow.Handler;
using Planet.Configuration;

namespace Planet.ComputeData
{
    public class GeometryParametres : Parametres
    {
        private const string _RESOLUTION = "Resolution";
        private const string _SCALE = "Scale";

        private int _resolution;
        private float _scale;

        public GeometryParametres(Geometry geometry, General general)
        {
            _resolution = geometry.Resolution - 1;
            _scale = general.Radius + general.Height;
        }

        public override void ToCompute()
        {
            _convoy.Compute.SetInt(_RESOLUTION, _resolution);
            _convoy.Compute.SetFloat(_SCALE, _scale);
        }
    }
}