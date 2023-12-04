using BuilderWorkflow;

namespace Planet.View
{
    public class GeometryParametresBuilder : IBuilder
    {
        private const string _NAME_RESOLUTION = "Resolution";
        private const string _NAME_SCALE = "Scale";

        private int _resolution;
        private float _scale;

        public GeometryParametresBuilder(int resolution, float scale)
        {
            _resolution = resolution;
            _scale = scale;
        }

        public void ConstructModel(out GeometryParametres model)
        {
            model = new GeometryParametres(_resolution, _scale, _NAME_RESOLUTION, _NAME_SCALE);
        }
    }
}