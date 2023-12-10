using GeometryWorkflow;

namespace Planet.Geometry
{
    public class GeometryAssignableConfigurator
    {
        private GeometryData _geometry;
        private int _resolution;
        private float _scale;

        public GeometryAssignableConfigurator(GeometryData geometry, int resolution, float scale)
        {
            _geometry = geometry;
            _resolution = resolution;
            _scale = scale;
        }

        public void Configure(out GeometryBuffers buffers, out GeometryParametres parametres) 
        { 
            ConfigureBuffers(_geometry, out buffers);
            ConfigureParametres(_resolution, _scale, out parametres);
        }

        private void ConfigureBuffers(GeometryData geometry, out GeometryBuffers buffers)
        {
            buffers = new GeometryBuffers(geometry.Vertices.Length, geometry.Triangles.Length);
        }

        private void ConfigureParametres(int resolution, float scale, out GeometryParametres parametres)
        {
            parametres = new GeometryParametres(resolution, scale);
        }
    }
}