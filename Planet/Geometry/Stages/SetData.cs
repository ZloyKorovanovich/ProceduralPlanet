using GeometryWorkflow;

namespace Planet.Geometry
{
    public class SetData : GeometryStage
    {
        public SetData(GeometryData geometryData, GeometryBuffers geometryBuffers) : base(geometryData, geometryBuffers)
        {

        }

        public override void Complete()
        {
            _geometryBuffers.SetData(_geometryData);
        }
    }
}