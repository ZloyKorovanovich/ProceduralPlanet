using ProceduralPlanet.Adaptors;
using UnityEngine;

namespace ProceduralPlanet.Components.Handlers
{
    public class GeometryHandler
    {
        private Parametres.CalculatingComponents.Compute _computeParametres;
        private Parametres.Visualisation.Geometry _parametres;
        private Mesh _mesh;

        public GeometryHandler(Parametres.CalculatingComponents.Compute computeParametres, Parametres.Visualisation.Geometry parametres)
        {
            _computeParametres = computeParametres;
            _parametres = parametres;
        }

        public void GenerateMesh()
        {
            Generators.PeakGeometry generator = GeometryAdaptionProcessor.FillPeakGeometry(_parametres, _computeParametres);
            generator.GenerateMesh(out _mesh);
        }

        public void ApplyMesh(ref MeshFilter meshFilter)
        {
            meshFilter.mesh = _mesh;
        }
    }
}
