using ConvoyWorkflow;
using GeometryWorkflow;

namespace Planet.Geometry
{
    public abstract class GeometryStage : IStage
    {
        protected GeometryData _geometryData;
        protected GeometryBuffers _geometryBuffers;

        public GeometryStage(GeometryData geometryData, GeometryBuffers geometryBuffers)
        {
            _geometryData = geometryData;
            _geometryBuffers = geometryBuffers;
        }

        public abstract void Complete();
    }
}