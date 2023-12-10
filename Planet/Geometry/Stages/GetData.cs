using GeometryWorkflow;

namespace Planet.Geometry
{
    public class GetData : GeometryStage
    {
        public GetData(ref GeometryData geometryData, GeometryBuffers geometryBuffers) : base(ref geometryData, geometryBuffers)
        {

        }

        public override void Complete()
        {
            _geometryBuffers.GetData(ref _geometryData);
        }
    }
}