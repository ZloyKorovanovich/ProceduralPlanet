using GeometryWorkflow;

namespace Planet.Geometry
{
    public class GetData : GeometryStage
    {
        public GetData(GeometryData geometryData, GeometryBuffers geometryBuffers) : base(geometryData, geometryBuffers)
        {

        }

        public override void Complete()
        {
            _geometryBuffers.GetData(_geometryData);
        }
    }
}