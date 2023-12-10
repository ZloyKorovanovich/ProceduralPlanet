using GeometryWorkflow;

namespace Planet.Geometry
{
    public class SetData : GeometryStage
    {
        public SetData(ref GeometryData geometryData, GeometryBuffers geometryBuffers) : base(ref geometryData, geometryBuffers)
        {

        }

        public override void Complete()
        {
            _geometryBuffers.SetData(ref _geometryData);
        }
    }
}